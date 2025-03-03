namespace WindowsFormsApp1
{
    partial class FrmClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClient));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_disconn = new System.Windows.Forms.Button();
            this.btn_conn = new System.Windows.Forms.Button();
            this.cmb_serip = new System.Windows.Forms.ComboBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lst_info = new System.Windows.Forms.ListView();
            this.InfoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_topic_sub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_qos_sub = new System.Windows.Forms.ComboBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_unsub = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_publish = new System.Windows.Forms.Button();
            this.cmb_qos_pub = new System.Windows.Forms.ComboBox();
            this.txt_topic_pub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_msg_pub = new System.Windows.Forms.TextBox();
            this.chk_isuserpwd = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ckb_auto_pub = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_state);
            this.splitContainer1.Panel1.Controls.Add(this.chk_isuserpwd);
            this.splitContainer1.Panel1.Controls.Add(this.txt_password);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txt_username);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.btn_unsub);
            this.splitContainer1.Panel1.Controls.Add(this.btn_disconn);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sub);
            this.splitContainer1.Panel1.Controls.Add(this.btn_conn);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_qos_sub);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_serip);
            this.splitContainer1.Panel1.Controls.Add(this.txt_topic_sub);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_port);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(684, 484);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_disconn
            // 
            this.btn_disconn.Location = new System.Drawing.Point(570, 22);
            this.btn_disconn.Name = "btn_disconn";
            this.btn_disconn.Size = new System.Drawing.Size(71, 28);
            this.btn_disconn.TabIndex = 3;
            this.btn_disconn.Text = "DisConn";
            this.btn_disconn.UseVisualStyleBackColor = true;
            this.btn_disconn.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(466, 22);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(71, 28);
            this.btn_conn.TabIndex = 3;
            this.btn_conn.Text = "Conn";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_serip
            // 
            this.cmb_serip.FormattingEnabled = true;
            this.cmb_serip.Location = new System.Drawing.Point(125, 21);
            this.cmb_serip.Name = "cmb_serip";
            this.cmb_serip.Size = new System.Drawing.Size(121, 28);
            this.cmb_serip.TabIndex = 2;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(311, 22);
            this.txt_port.Name = "txt_port";
            this.txt_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_port.Size = new System.Drawing.Size(121, 26);
            this.txt_port.TabIndex = 1;
            this.txt_port.Text = "1883";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel5.Text = "  系统时间：";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel6.Text = "2025-02-20 01:46:00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "  当前连接：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel3.Text = "  版本说明：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel4.Text = "V1";
            // 
            // lst_info
            // 
            this.lst_info.BackColor = System.Drawing.SystemColors.Control;
            this.lst_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InfoName,
            this.Content});
            this.lst_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lst_info.HideSelection = false;
            this.lst_info.Location = new System.Drawing.Point(0, 0);
            this.lst_info.Name = "lst_info";
            this.lst_info.Size = new System.Drawing.Size(682, 201);
            this.lst_info.SmallImageList = this.imageList1;
            this.lst_info.TabIndex = 0;
            this.lst_info.UseCompatibleStateImageBehavior = false;
            this.lst_info.View = System.Windows.Forms.View.Details;
            // 
            // InfoName
            // 
            this.InfoName.Text = "InfoName";
            this.InfoName.Width = 160;
            // 
            // Content
            // 
            this.Content.Text = "Content";
            this.Content.Width = 400;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "INFO.ICO");
            this.imageList1.Images.SetKeyName(1, "W95MBX01.ICO");
            this.imageList1.Images.SetKeyName(2, "W95MBX03.ICO");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Topic：";
            // 
            // txt_topic_sub
            // 
            this.txt_topic_sub.Location = new System.Drawing.Point(125, 105);
            this.txt_topic_sub.Name = "txt_topic_sub";
            this.txt_topic_sub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_topic_sub.Size = new System.Drawing.Size(121, 26);
            this.txt_topic_sub.TabIndex = 1;
            this.txt_topic_sub.Text = "topic sub";
            this.txt_topic_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "QoS：";
            // 
            // cmb_qos_sub
            // 
            this.cmb_qos_sub.FormattingEnabled = true;
            this.cmb_qos_sub.Location = new System.Drawing.Point(311, 104);
            this.cmb_qos_sub.Name = "cmb_qos_sub";
            this.cmb_qos_sub.Size = new System.Drawing.Size(121, 28);
            this.cmb_qos_sub.TabIndex = 2;
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(466, 104);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(71, 28);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "Sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_unsub
            // 
            this.btn_unsub.Location = new System.Drawing.Point(570, 104);
            this.btn_unsub.Name = "btn_unsub";
            this.btn_unsub.Size = new System.Drawing.Size(71, 28);
            this.btn_unsub.TabIndex = 3;
            this.btn_unsub.Text = "UnSub";
            this.btn_unsub.UseVisualStyleBackColor = true;
            this.btn_unsub.Click += new System.EventHandler(this.btn_unsub_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lst_info);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ckb_auto_pub);
            this.splitContainer2.Panel2.Controls.Add(this.btn_publish);
            this.splitContainer2.Panel2.Controls.Add(this.cmb_qos_pub);
            this.splitContainer2.Panel2.Controls.Add(this.txt_msg_pub);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txt_topic_pub);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Size = new System.Drawing.Size(684, 310);
            this.splitContainer2.SplitterDistance = 203;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 2;
            // 
            // btn_publish
            // 
            this.btn_publish.Location = new System.Drawing.Point(497, 18);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(71, 28);
            this.btn_publish.TabIndex = 8;
            this.btn_publish.Text = "Publish";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // cmb_qos_pub
            // 
            this.cmb_qos_pub.FormattingEnabled = true;
            this.cmb_qos_pub.Location = new System.Drawing.Point(353, 18);
            this.cmb_qos_pub.Name = "cmb_qos_pub";
            this.cmb_qos_pub.Size = new System.Drawing.Size(121, 28);
            this.cmb_qos_pub.TabIndex = 7;
            // 
            // txt_topic_pub
            // 
            this.txt_topic_pub.Location = new System.Drawing.Point(125, 20);
            this.txt_topic_pub.Name = "txt_topic_pub";
            this.txt_topic_pub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_topic_pub.Size = new System.Drawing.Size(162, 26);
            this.txt_topic_pub.TabIndex = 6;
            this.txt_topic_pub.Text = "topic pub";
            this.txt_topic_pub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Topic：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "QoS：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Message：";
            // 
            // txt_msg_pub
            // 
            this.txt_msg_pub.Location = new System.Drawing.Point(125, 61);
            this.txt_msg_pub.Name = "txt_msg_pub";
            this.txt_msg_pub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_msg_pub.Size = new System.Drawing.Size(527, 26);
            this.txt_msg_pub.TabIndex = 6;
            this.txt_msg_pub.Text = "msg pub";
            this.txt_msg_pub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_isuserpwd
            // 
            this.chk_isuserpwd.AutoSize = true;
            this.chk_isuserpwd.Location = new System.Drawing.Point(466, 65);
            this.chk_isuserpwd.Name = "chk_isuserpwd";
            this.chk_isuserpwd.Size = new System.Drawing.Size(84, 24);
            this.chk_isuserpwd.TabIndex = 9;
            this.chk_isuserpwd.Text = "启用账号";
            this.chk_isuserpwd.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(311, 64);
            this.txt_password.Name = "txt_password";
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.Size = new System.Drawing.Size(121, 26);
            this.txt_password.TabIndex = 7;
            this.txt_password.Text = "123456";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "PWD：";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(125, 64);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_username.Size = new System.Drawing.Size(121, 26);
            this.txt_username.TabIndex = 8;
            this.txt_username.Text = "admin";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "UserName：";
            // 
            // txt_state
            // 
            this.txt_state.BackColor = System.Drawing.SystemColors.Control;
            this.txt_state.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_state.Location = new System.Drawing.Point(570, 68);
            this.txt_state.Name = "txt_state";
            this.txt_state.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_state.Size = new System.Drawing.Size(82, 19);
            this.txt_state.TabIndex = 10;
            this.txt_state.Text = "启用";
            this.txt_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ckb_auto_pub
            // 
            this.ckb_auto_pub.AutoSize = true;
            this.ckb_auto_pub.Location = new System.Drawing.Point(583, 20);
            this.ckb_auto_pub.Name = "ckb_auto_pub";
            this.ckb_auto_pub.Size = new System.Drawing.Size(88, 24);
            this.ckb_auto_pub.TabIndex = 9;
            this.ckb_auto_pub.Text = "AutoPub";
            this.ckb_auto_pub.UseVisualStyleBackColor = true;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于开源MQTT NET开发Client端";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_serip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_disconn;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView lst_info;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader InfoName;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.Button btn_unsub;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.ComboBox cmb_qos_sub;
        private System.Windows.Forms.TextBox txt_topic_sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.ComboBox cmb_qos_pub;
        private System.Windows.Forms.TextBox txt_msg_pub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_topic_pub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_isuserpwd;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ckb_auto_pub;
    }
}

