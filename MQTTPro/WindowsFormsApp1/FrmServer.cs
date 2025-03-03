using MQTTnet;
using MQTTnet.Server;
using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //【委托】1步_创建委托(日志信息的委托)一个命名空间只需要创建一个委托—client再创建“委托对象”、“委托方法体”“初始化绑定”
    public delegate void AddlogDelegate(int index, string info);
    public partial class FrmServer : Form
    {
        //初始化
        public FrmServer()
        {
            InitializeComponent();

            //调整列表视图宽度(动态显示第二列的值)
            this.lst_info.Columns[1].Width = this.lst_info.ClientSize.Width - this.lst_info.Columns[0].Width;

            //【委托1】4步_对象绑定方法（添加日志调用AddLog对象即可）
            this.AddLog = this.AddlogMothod;

            //获取Ip集合
            string[] ips = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Select(ip => ip.ToString()).ToArray();
            //绑定到控件
            this.cmb_iplist.DataSource = ips;
            //默认选中第一个
            this.cmb_iplist.SelectedIndex = 0;
            //绑定端口
            this.txt_port.Text = "1883";
            //绑定状态
            this.txt_state.Text = "未启动";


        }

        #region 创建服务器对象、启动服务、停止服务、绑定事件-日志显示
        //创建服务器对象
        private IMqttServer mqttServer = null;
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (mqttServer != null)
            {
                //绑定状态
                this.txt_state.Text = "已启动";
                return;
            }

            //创建服务器配置
            var optionsBuilder = new MqttServerOptionsBuilder()
                .WithConnectionBacklog(100)
                .WithDefaultEndpointPort(int.Parse(this.txt_port.Text))
                .WithDefaultEndpointBoundIPAddress(System.Net.IPAddress.Parse(this.cmb_iplist.Text))

                .WithConnectionValidator(c =>
                {
                    //验证ID长度
                    if (c.ClientId.Length < 10)
                    {
                        c.ReturnCode = MqttConnectReturnCode.ConnectionRefusedIdentifierRejected;
                        return;
                    }
                    //验证账户和密码
                    if (chk_isuserpwd.Checked)
                    {
                        if (c.Username != this.txt_username.Text || c.Password != this.txt_password.Text)
                        {
                            c.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                            return;
                        }
                    }

                    c.ReturnCode = MqttConnectReturnCode.ConnectionAccepted;
                });


            //创建服务对象:初始化（实例化）对象（调用对象的成员 mqttServer.ClientConnected 时先 new 一个）
            //否则“未将对象引用到实例报错”
            mqttServer = new MqttFactory().CreateMqttServer();

            //______________绑定MQTT事件
            mqttServer.ClientConnected += MqttServer_ClientConnected;   //客户端已连接
            mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;  //客户端未连接
            mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;  //客户端已订阅
            mqttServer.ClientUnsubscribedTopic += MqttServer_ClientUnsubscribedTopic;  //客户端取消订阅
            mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;  //接收信息事件
            mqttServer.Started += MqttServer_Started;  //服务端已开启
            mqttServer.Stopped += MqttServer_Stopped;  //服务端已停止

            //启动服务
            mqttServer.StartAsync(optionsBuilder.Build());
            //绑定状态
            this.txt_state.Text = "已启动";
        }

        //停止服务
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (mqttServer != null)
            {
                mqttServer.StopAsync();
                mqttServer = null;
                //绑定状态
                this.txt_state.Text = "未启动";
            }
        }

        //清空日志
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.lst_info.Items.Clear();
        }

        #endregion

        #region 事件日志显示
        private void MqttServer_Stopped(object sender, EventArgs e)
        {
            this.AddLog(0, "MQTT服务端已停止");
        }

        private void MqttServer_Started(object sender, EventArgs e)
        {
            this.AddLog(0, "MQTT服务端已启动");
        }

        private void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            this.AddLog(0, "MQTT服务器接收到客户端信息" + "ClietID:" + e.ClientId.Length + "Topic:" + e.ApplicationMessage.Topic + "Payload:" + Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
        }

        private void MqttServer_ClientUnsubscribedTopic(object sender, MqttClientUnsubscribedTopicEventArgs e)
        {
            this.AddLog(0, "MQTT客户端取消订阅" + "ClietID:" + e.ClientId.Length + "Topic:" + e.TopicFilter);
        }

        private void MqttServer_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e)
        {
            this.AddLog(0, "MQTT客户端订阅" + "ClietID:" + e.ClientId.Length + "Topic:" + e.TopicFilter);
        }

        private void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            this.AddLog(0, "MQTT客户端断开连接" + "ClietID:" + e.ClientId.Length);
            Invoke(new Action(() =>   //Invoke异常处理？应用场景
            {
                this.tss_connnum.Text = mqttServer.GetClientSessionsStatusAsync().Result.Count.ToString();
            }));

        }

        private void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {
            this.AddLog(0, "MQTT客户端已连接" + "ClietID:" + e.ClientId.Length);
            Invoke(new Action(() =>
            {
                this.tss_connnum.Text = mqttServer.GetClientSessionsStatusAsync().Result.Count.ToString();
            }));
        }
        #endregion

        #region 创建委托对象、委托方法、获取当前时间
        //【委托1】3步_创建委托对象（日志对象）
        private AddlogDelegate AddLog;

        /// <summary>
        /// 【委托1】2步_方法（写入日志的方法体）
        /// </summary>
        /// <param name="index"></param>
        /// <param name="info"></param>
        private void AddlogMothod(int index, string info)
        {
            //判断是否跨线程访问
            if (this.lst_info.InvokeRequired)
            {
                //跨线程访问
                this.lst_info.Invoke(new Action(() =>
                {
                    ListViewItem lst = new ListViewItem("" + CurrentTime, index);
                    lst.SubItems.Add(info);
                    lst_info.Items.Insert(0, lst);
                }));
            }
            else
            {
                //不跨线程访问
                ListViewItem lst = new ListViewItem("" + CurrentTime, index);  //获取当前时间方法
                lst.SubItems.Add(info);
                lst_info.Items.Insert(0, lst);
            }
        }


        //获取当前时间
        private string CurrentTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        //状态栏时间（组件的timer使能需要True）
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tss_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //关闭窗体停止服务
        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mqttServer != null)
            {
                mqttServer.StopAsync();
            }
        }
        #endregion

        //客户端窗体
        private void btn_client_Click(object sender, EventArgs e)
        {
            new FrmClient(this.cmb_iplist.Text, this.txt_port.Text).Show();
        }

       
    }
}
