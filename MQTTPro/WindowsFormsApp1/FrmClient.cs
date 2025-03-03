using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmClient : Form
    {

        public FrmClient()
        {
            InitializeComponent();


            #region 发布消息
            //QoS
            this.cmb_qos_sub.DataSource = this.cmb_qos_pub.DataSource = Enum.GetNames(typeof(MqttQualityOfServiceLevel));



            #endregion


            //调整列表视图宽度(动态显示第二列的值)
            this.lst_info.Columns[1].Width = this.lst_info.ClientSize.Width - this.lst_info.Columns[0].Width;
            //【委托2】3步_对象绑定方法（添加日志调用AddLog对象即可）
            this.AddLog = this.AddlogMothod;

            #region  独立的获取Ip集合
            string[] ips = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Select(ip => ip.ToString()).ToArray();
            //绑定到控件
            this.cmb_serip.DataSource = ips;
            //默认选中第一个
            this.cmb_serip.SelectedIndex = 0;
            //绑定端口
            this.txt_port.Text = "1883";
            //绑定状态
            this.txt_state.Text = "未连接";
            #endregion

        }

        #region 创建客户端对象、连接服务器、断开服务器、消息显示
        //创建客户端对象
        private IMqttClient mqttClient = null;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //创建客户端配置
            var option = new MqttClientOptions() { ClientId = Guid.NewGuid().ToString("D") };

            //创建通道配置
            option.ChannelOptions = new MqttClientTcpOptions()
            {
                Server = this.cmb_serip.Text,
                Port = int.Parse(this.txt_port.Text)
            };

            //是否启用账户
            if (this.chk_isuserpwd.Checked)
            {
                option.Credentials = new MqttClientCredentials()
                {
                    Username = this.txt_username.Text,
                    Password = this.txt_password.Text
                };
            }

            //创建会话配置
            option.CleanSession = true;
            option.KeepAlivePeriod = TimeSpan.FromSeconds(60);
            option.KeepAliveSendInterval = TimeSpan.FromSeconds(20);

            try
            {

                //创建客户端对象
                mqttClient = new MqttFactory().CreateMqttClient();

                //绑定事件
                mqttClient.Connected += mqttClient_Connected;
                mqttClient.Disconnected += mqttClient_Disconnected;
                mqttClient.ApplicationMessageReceived += mqttClient_ApplicationMessageReceived;

                //连接服务器
                mqttClient.ConnectAsync(option);

                if (this.ckb_auto_pub.Checked)
                {
                    //连接服务后自动发布消息—定时器
                    this.timer1.Enabled = true;  //可引用通讯类库改成链接BOll对象；链接成功启动定时器

                }
                else
                {
                    this.timer1.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                AddLog(1, "连接失败：" + ex.Message);
                return;
            }

            //绑定状态  
            this.txt_state.Text = "已连接";

        }

        //消息显示
        private void mqttClient_Disconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            AddLog(0, "连接已断开" + "ClientWadConnected:" + e.ClientWasConnected);
        }

        private void mqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            AddLog(0, "接收到消息：" + Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
        }

        private void mqttClient_Connected(object sender, MqttClientConnectedEventArgs e)
        {
            AddLog(0, "连接成功" + "IsSessionPresent:" + e.IsSessionPresent);
        }

        //断开连接
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (mqttClient != null)
            {
                mqttClient.DisconnectAsync();
                mqttClient = null;
            }
            //绑定状态
            this.txt_state.Text = "未连接";
        }

        #endregion

        #region  委托2—日志显示
        //【委托2】2步_创建委托对象
        public AddlogDelegate AddLog = null;

        //【委托2】1步_创建委托方法体
        public void AddlogMothod(int index, string info)
        {
            //判断是否跨线程访问
            if (this.lst_info.InvokeRequired)
            {
                //跨线程访问
                this.lst_info.Invoke(new AddlogDelegate(AddlogMothod), index, info);
            }
            else
            {
                //不跨线程访问
                ListViewItem item = new ListViewItem();
                item.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                item.SubItems.Add(info);
                this.lst_info.Items.Insert(0, item);
            }
        }
        #endregion

        #region 从服务器直接复制参数过来-增加有参数的构造方法-FrmServer点击按钮填写参数
        public FrmClient(string ip, string port)
        {
            InitializeComponent();

            //QoS
            this.cmb_qos_sub.DataSource = this.cmb_qos_pub.DataSource = Enum.GetNames(typeof(MqttQualityOfServiceLevel));


            #region  初始化构造函数一样的代码
            //调整列表视图宽度(动态显示第二列的值)
            this.lst_info.Columns[1].Width = this.lst_info.ClientSize.Width - this.lst_info.Columns[0].Width;
            //【委托2】3步_对象绑定方法（添加日志调用AddLog对象即可）
            this.AddLog = this.AddlogMothod;
            #endregion

            //绑定到控件
            this.cmb_serip.Text = ip;
            //绑定端口
            this.txt_port.Text = port;
            //绑定状态
            this.txt_state.Text = "未连接";
        }

        #endregion

        #region 订阅主题、取消订阅
        //订阅主题
        private void btn_sub_Click(object sender, EventArgs e)
        {

            try
            {
                mqttClient.SubscribeAsync(new List<TopicFilter>()
                {
                new TopicFilter(this.txt_topic_sub.Text,(MqttQualityOfServiceLevel)Enum.Parse(typeof(MqttQualityOfServiceLevel),this.cmb_qos_sub.Text))
                 });

            }
            catch (Exception ex)
            {
                AddLog(1, "订阅失败" + ex.Message);
                return;
            }
            AddLog(0, "订阅成功" + "Topic：" + this.txt_topic_sub.Text);

        }

        //取消订阅
        private void btn_unsub_Click(object sender, EventArgs e)
        {

            try
            {
                mqttClient.UnsubscribeAsync(this.txt_topic_sub.Text);
            }
            catch (Exception ex)
            {
                AddLog(1, "取消订阅失败" + ex.Message);
                return;
            }
            AddLog(0, "取消订阅成功" + this.txt_topic_sub.Text);
        }
        #endregion

        #region 发布消息
        //发布消息
        private void btn_publish_Click(object sender, EventArgs e)
        {

            if (mqttClient == null)
            {
                AddLog(1, "客户端未连接无法发送消息");
                return;
            }

            var msg = new MqttApplicationMessage()
            {
                Topic = this.txt_topic_pub.Text,
                QualityOfServiceLevel = (MqttQualityOfServiceLevel)Enum.Parse(typeof(MqttQualityOfServiceLevel), this.cmb_qos_pub.Text),
                Payload = Encoding.UTF8.GetBytes(this.txt_msg_pub.Text),
                Retain = false,
            };

            try
            {
                mqttClient.PublishAsync(msg);
            }
            catch (Exception ex)
            {
                AddLog(1, "发布消息失败" + ex.Message); return;
            }
            AddLog(0, "发布消息成功" + "Topic:" + this.txt_topic_pub.Text + "payload:" + this.txt_msg_pub.Text);
        }
        #endregion

        #region  定时发布
        //创建PLC对象
        private string plcmsg { get; set; }
        //定时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            plcmsg = "1.0E-4Pa";

            var msg = new MqttApplicationMessage()
            {
                Topic = this.txt_topic_pub.Text,
                QualityOfServiceLevel = (MqttQualityOfServiceLevel)Enum.Parse(typeof(MqttQualityOfServiceLevel), this.cmb_qos_pub.Text),
                Payload = Encoding.UTF8.GetBytes(plcmsg),
                Retain = false,
            };

            mqttClient.PublishAsync(msg);
        }
    }
    #endregion
}
