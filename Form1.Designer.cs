namespace SMC6490_Monitor
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.state_lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.ip_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setZero_btn = new System.Windows.Forms.Button();
            this.backZero_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.uMoveRev_btn = new System.Windows.Forms.Button();
            this.uMovePlus_btn = new System.Windows.Forms.Button();
            this.zMoveRev_btn = new System.Windows.Forms.Button();
            this.zMovePlus_btn = new System.Windows.Forms.Button();
            this.yMoveRev_btn = new System.Windows.Forms.Button();
            this.yMovePlus_btn = new System.Windows.Forms.Button();
            this.xMoveRev_btn = new System.Windows.Forms.Button();
            this.xMovePlus_btn = new System.Windows.Forms.Button();
            this.setCoor_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.gotoCoor_btn = new System.Windows.Forms.Button();
            this.uSetCoor_tbx = new System.Windows.Forms.TextBox();
            this.zSetCoor_tbx = new System.Windows.Forms.TextBox();
            this.ySetCoor_tbx = new System.Windows.Forms.TextBox();
            this.xSetCoor_tbx = new System.Windows.Forms.TextBox();
            this.uGotoCoor_tbx = new System.Windows.Forms.TextBox();
            this.zGotoCoor_tbx = new System.Windows.Forms.TextBox();
            this.yGotoCoor_tbx = new System.Windows.Forms.TextBox();
            this.xGotoCoor_tbx = new System.Windows.Forms.TextBox();
            this.uMachCoor_tbx = new System.Windows.Forms.TextBox();
            this.zMachCoor_tbx = new System.Windows.Forms.TextBox();
            this.yMachCoor_tbx = new System.Windows.Forms.TextBox();
            this.xMachCoor_tbx = new System.Windows.Forms.TextBox();
            this.uSpeed_tbx = new System.Windows.Forms.TextBox();
            this.zSpeed_tbx = new System.Windows.Forms.TextBox();
            this.ySpeed_tbx = new System.Windows.Forms.TextBox();
            this.xSpeed_tbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.terminate_btn = new System.Windows.Forms.Button();
            this.run_btn = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.lineNum_lab = new System.Windows.Forms.Label();
            this.gcode_richtbx = new System.Windows.Forms.RichTextBox();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.check_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearGraph_btn = new System.Windows.Forms.Button();
            this.zedGraph1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.setSpeed_tbx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.setSpeed_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLab_ErrMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.state_lab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.ip_tbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接设备";
            // 
            // state_lab
            // 
            this.state_lab.AutoSize = true;
            this.state_lab.Location = new System.Drawing.Point(99, 49);
            this.state_lab.Name = "state_lab";
            this.state_lab.Size = new System.Drawing.Size(41, 12);
            this.state_lab.TabIndex = 4;
            this.state_lab.Text = "未连接";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "连接状态：";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(171, 18);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "连接设备";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // ip_tbx
            // 
            this.ip_tbx.Location = new System.Drawing.Point(65, 20);
            this.ip_tbx.Name = "ip_tbx";
            this.ip_tbx.Size = new System.Drawing.Size(100, 21);
            this.ip_tbx.TabIndex = 1;
            this.ip_tbx.Text = "192.168.1.11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setZero_btn);
            this.groupBox2.Controls.Add(this.backZero_btn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.uMoveRev_btn);
            this.groupBox2.Controls.Add(this.uMovePlus_btn);
            this.groupBox2.Controls.Add(this.zMoveRev_btn);
            this.groupBox2.Controls.Add(this.zMovePlus_btn);
            this.groupBox2.Controls.Add(this.yMoveRev_btn);
            this.groupBox2.Controls.Add(this.yMovePlus_btn);
            this.groupBox2.Controls.Add(this.xMoveRev_btn);
            this.groupBox2.Controls.Add(this.xMovePlus_btn);
            this.groupBox2.Controls.Add(this.setCoor_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.gotoCoor_btn);
            this.groupBox2.Controls.Add(this.uSetCoor_tbx);
            this.groupBox2.Controls.Add(this.zSetCoor_tbx);
            this.groupBox2.Controls.Add(this.ySetCoor_tbx);
            this.groupBox2.Controls.Add(this.xSetCoor_tbx);
            this.groupBox2.Controls.Add(this.uGotoCoor_tbx);
            this.groupBox2.Controls.Add(this.zGotoCoor_tbx);
            this.groupBox2.Controls.Add(this.yGotoCoor_tbx);
            this.groupBox2.Controls.Add(this.xGotoCoor_tbx);
            this.groupBox2.Controls.Add(this.uMachCoor_tbx);
            this.groupBox2.Controls.Add(this.zMachCoor_tbx);
            this.groupBox2.Controls.Add(this.yMachCoor_tbx);
            this.groupBox2.Controls.Add(this.xMachCoor_tbx);
            this.groupBox2.Controls.Add(this.uSpeed_tbx);
            this.groupBox2.Controls.Add(this.zSpeed_tbx);
            this.groupBox2.Controls.Add(this.ySpeed_tbx);
            this.groupBox2.Controls.Add(this.xSpeed_tbx);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前运动状态";
            // 
            // setZero_btn
            // 
            this.setZero_btn.Location = new System.Drawing.Point(325, 61);
            this.setZero_btn.Name = "setZero_btn";
            this.setZero_btn.Size = new System.Drawing.Size(75, 23);
            this.setZero_btn.TabIndex = 35;
            this.setZero_btn.Text = "设零点";
            this.setZero_btn.UseVisualStyleBackColor = true;
            this.setZero_btn.Click += new System.EventHandler(this.MoveControl_Click);
            // 
            // backZero_btn
            // 
            this.backZero_btn.Location = new System.Drawing.Point(325, 34);
            this.backZero_btn.Name = "backZero_btn";
            this.backZero_btn.Size = new System.Drawing.Size(75, 23);
            this.backZero_btn.TabIndex = 34;
            this.backZero_btn.Text = "回零点";
            this.backZero_btn.UseVisualStyleBackColor = true;
            this.backZero_btn.Click += new System.EventHandler(this.MoveControl_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "手动操作";
            // 
            // uMoveRev_btn
            // 
            this.uMoveRev_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uMoveRev_btn.Location = new System.Drawing.Point(292, 142);
            this.uMoveRev_btn.Name = "uMoveRev_btn";
            this.uMoveRev_btn.Size = new System.Drawing.Size(27, 23);
            this.uMoveRev_btn.TabIndex = 32;
            this.uMoveRev_btn.Text = "-";
            this.uMoveRev_btn.UseVisualStyleBackColor = true;
            this.uMoveRev_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.uMoveRev_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // uMovePlus_btn
            // 
            this.uMovePlus_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uMovePlus_btn.Location = new System.Drawing.Point(260, 142);
            this.uMovePlus_btn.Name = "uMovePlus_btn";
            this.uMovePlus_btn.Size = new System.Drawing.Size(27, 23);
            this.uMovePlus_btn.TabIndex = 31;
            this.uMovePlus_btn.Text = "+";
            this.uMovePlus_btn.UseVisualStyleBackColor = true;
            this.uMovePlus_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.uMovePlus_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // zMoveRev_btn
            // 
            this.zMoveRev_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zMoveRev_btn.Location = new System.Drawing.Point(227, 142);
            this.zMoveRev_btn.Name = "zMoveRev_btn";
            this.zMoveRev_btn.Size = new System.Drawing.Size(27, 23);
            this.zMoveRev_btn.TabIndex = 30;
            this.zMoveRev_btn.Text = "-";
            this.zMoveRev_btn.UseVisualStyleBackColor = true;
            this.zMoveRev_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.zMoveRev_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // zMovePlus_btn
            // 
            this.zMovePlus_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zMovePlus_btn.Location = new System.Drawing.Point(195, 142);
            this.zMovePlus_btn.Name = "zMovePlus_btn";
            this.zMovePlus_btn.Size = new System.Drawing.Size(27, 23);
            this.zMovePlus_btn.TabIndex = 29;
            this.zMovePlus_btn.Text = "+";
            this.zMovePlus_btn.UseVisualStyleBackColor = true;
            this.zMovePlus_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.zMovePlus_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // yMoveRev_btn
            // 
            this.yMoveRev_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yMoveRev_btn.Location = new System.Drawing.Point(162, 142);
            this.yMoveRev_btn.Name = "yMoveRev_btn";
            this.yMoveRev_btn.Size = new System.Drawing.Size(27, 23);
            this.yMoveRev_btn.TabIndex = 28;
            this.yMoveRev_btn.Text = "-";
            this.yMoveRev_btn.UseVisualStyleBackColor = true;
            this.yMoveRev_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.yMoveRev_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // yMovePlus_btn
            // 
            this.yMovePlus_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yMovePlus_btn.Location = new System.Drawing.Point(130, 142);
            this.yMovePlus_btn.Name = "yMovePlus_btn";
            this.yMovePlus_btn.Size = new System.Drawing.Size(27, 23);
            this.yMovePlus_btn.TabIndex = 27;
            this.yMovePlus_btn.Text = "+";
            this.yMovePlus_btn.UseVisualStyleBackColor = true;
            this.yMovePlus_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.yMovePlus_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // xMoveRev_btn
            // 
            this.xMoveRev_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xMoveRev_btn.Location = new System.Drawing.Point(97, 142);
            this.xMoveRev_btn.Name = "xMoveRev_btn";
            this.xMoveRev_btn.Size = new System.Drawing.Size(27, 23);
            this.xMoveRev_btn.TabIndex = 26;
            this.xMoveRev_btn.Text = "-";
            this.xMoveRev_btn.UseVisualStyleBackColor = true;
            this.xMoveRev_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.xMoveRev_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // xMovePlus_btn
            // 
            this.xMovePlus_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xMovePlus_btn.Location = new System.Drawing.Point(65, 142);
            this.xMovePlus_btn.Name = "xMovePlus_btn";
            this.xMovePlus_btn.Size = new System.Drawing.Size(27, 23);
            this.xMovePlus_btn.TabIndex = 25;
            this.xMovePlus_btn.Text = "+";
            this.xMovePlus_btn.UseVisualStyleBackColor = true;
            this.xMovePlus_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.xMovePlus_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // setCoor_btn
            // 
            this.setCoor_btn.Location = new System.Drawing.Point(325, 116);
            this.setCoor_btn.Name = "setCoor_btn";
            this.setCoor_btn.Size = new System.Drawing.Size(75, 23);
            this.setCoor_btn.TabIndex = 24;
            this.setCoor_btn.Text = "修改坐标";
            this.setCoor_btn.UseVisualStyleBackColor = true;
            this.setCoor_btn.Click += new System.EventHandler(this.MoveControl_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(325, 142);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 24;
            this.stop_btn.Text = "紧急停止";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.MoveControl_Click);
            // 
            // gotoCoor_btn
            // 
            this.gotoCoor_btn.Location = new System.Drawing.Point(325, 89);
            this.gotoCoor_btn.Name = "gotoCoor_btn";
            this.gotoCoor_btn.Size = new System.Drawing.Size(75, 23);
            this.gotoCoor_btn.TabIndex = 23;
            this.gotoCoor_btn.Text = "定位坐标";
            this.gotoCoor_btn.UseVisualStyleBackColor = true;
            this.gotoCoor_btn.Click += new System.EventHandler(this.MoveControl_Click);
            // 
            // uSetCoor_tbx
            // 
            this.uSetCoor_tbx.Location = new System.Drawing.Point(260, 117);
            this.uSetCoor_tbx.MaxLength = 10;
            this.uSetCoor_tbx.Name = "uSetCoor_tbx";
            this.uSetCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.uSetCoor_tbx.TabIndex = 22;
            // 
            // zSetCoor_tbx
            // 
            this.zSetCoor_tbx.Location = new System.Drawing.Point(195, 117);
            this.zSetCoor_tbx.MaxLength = 10;
            this.zSetCoor_tbx.Name = "zSetCoor_tbx";
            this.zSetCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.zSetCoor_tbx.TabIndex = 21;
            // 
            // ySetCoor_tbx
            // 
            this.ySetCoor_tbx.Location = new System.Drawing.Point(130, 117);
            this.ySetCoor_tbx.MaxLength = 10;
            this.ySetCoor_tbx.Name = "ySetCoor_tbx";
            this.ySetCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.ySetCoor_tbx.TabIndex = 20;
            // 
            // xSetCoor_tbx
            // 
            this.xSetCoor_tbx.Location = new System.Drawing.Point(65, 117);
            this.xSetCoor_tbx.MaxLength = 10;
            this.xSetCoor_tbx.Name = "xSetCoor_tbx";
            this.xSetCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.xSetCoor_tbx.TabIndex = 19;
            // 
            // uGotoCoor_tbx
            // 
            this.uGotoCoor_tbx.Location = new System.Drawing.Point(260, 90);
            this.uGotoCoor_tbx.MaxLength = 10;
            this.uGotoCoor_tbx.Name = "uGotoCoor_tbx";
            this.uGotoCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.uGotoCoor_tbx.TabIndex = 18;
            // 
            // zGotoCoor_tbx
            // 
            this.zGotoCoor_tbx.Location = new System.Drawing.Point(195, 90);
            this.zGotoCoor_tbx.MaxLength = 10;
            this.zGotoCoor_tbx.Name = "zGotoCoor_tbx";
            this.zGotoCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.zGotoCoor_tbx.TabIndex = 17;
            // 
            // yGotoCoor_tbx
            // 
            this.yGotoCoor_tbx.Location = new System.Drawing.Point(130, 90);
            this.yGotoCoor_tbx.MaxLength = 10;
            this.yGotoCoor_tbx.Name = "yGotoCoor_tbx";
            this.yGotoCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.yGotoCoor_tbx.TabIndex = 16;
            // 
            // xGotoCoor_tbx
            // 
            this.xGotoCoor_tbx.Location = new System.Drawing.Point(65, 90);
            this.xGotoCoor_tbx.MaxLength = 10;
            this.xGotoCoor_tbx.Name = "xGotoCoor_tbx";
            this.xGotoCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.xGotoCoor_tbx.TabIndex = 15;
            // 
            // uMachCoor_tbx
            // 
            this.uMachCoor_tbx.Location = new System.Drawing.Point(260, 63);
            this.uMachCoor_tbx.MaxLength = 10;
            this.uMachCoor_tbx.Name = "uMachCoor_tbx";
            this.uMachCoor_tbx.ReadOnly = true;
            this.uMachCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.uMachCoor_tbx.TabIndex = 14;
            // 
            // zMachCoor_tbx
            // 
            this.zMachCoor_tbx.Location = new System.Drawing.Point(195, 63);
            this.zMachCoor_tbx.MaxLength = 10;
            this.zMachCoor_tbx.Name = "zMachCoor_tbx";
            this.zMachCoor_tbx.ReadOnly = true;
            this.zMachCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.zMachCoor_tbx.TabIndex = 13;
            // 
            // yMachCoor_tbx
            // 
            this.yMachCoor_tbx.Location = new System.Drawing.Point(130, 63);
            this.yMachCoor_tbx.MaxLength = 10;
            this.yMachCoor_tbx.Name = "yMachCoor_tbx";
            this.yMachCoor_tbx.ReadOnly = true;
            this.yMachCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.yMachCoor_tbx.TabIndex = 12;
            // 
            // xMachCoor_tbx
            // 
            this.xMachCoor_tbx.Location = new System.Drawing.Point(65, 63);
            this.xMachCoor_tbx.MaxLength = 10;
            this.xMachCoor_tbx.Name = "xMachCoor_tbx";
            this.xMachCoor_tbx.ReadOnly = true;
            this.xMachCoor_tbx.Size = new System.Drawing.Size(59, 21);
            this.xMachCoor_tbx.TabIndex = 11;
            // 
            // uSpeed_tbx
            // 
            this.uSpeed_tbx.Location = new System.Drawing.Point(260, 36);
            this.uSpeed_tbx.MaxLength = 10;
            this.uSpeed_tbx.Name = "uSpeed_tbx";
            this.uSpeed_tbx.ReadOnly = true;
            this.uSpeed_tbx.Size = new System.Drawing.Size(59, 21);
            this.uSpeed_tbx.TabIndex = 10;
            // 
            // zSpeed_tbx
            // 
            this.zSpeed_tbx.Location = new System.Drawing.Point(195, 36);
            this.zSpeed_tbx.MaxLength = 10;
            this.zSpeed_tbx.Name = "zSpeed_tbx";
            this.zSpeed_tbx.ReadOnly = true;
            this.zSpeed_tbx.Size = new System.Drawing.Size(59, 21);
            this.zSpeed_tbx.TabIndex = 9;
            // 
            // ySpeed_tbx
            // 
            this.ySpeed_tbx.Location = new System.Drawing.Point(130, 36);
            this.ySpeed_tbx.MaxLength = 10;
            this.ySpeed_tbx.Name = "ySpeed_tbx";
            this.ySpeed_tbx.ReadOnly = true;
            this.ySpeed_tbx.Size = new System.Drawing.Size(59, 21);
            this.ySpeed_tbx.TabIndex = 8;
            // 
            // xSpeed_tbx
            // 
            this.xSpeed_tbx.Location = new System.Drawing.Point(65, 36);
            this.xSpeed_tbx.MaxLength = 10;
            this.xSpeed_tbx.Name = "xSpeed_tbx";
            this.xSpeed_tbx.ReadOnly = true;
            this.xSpeed_tbx.Size = new System.Drawing.Size(59, 21);
            this.xSpeed_tbx.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "U轴";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Z轴";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Y轴";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "X轴";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "修改坐标";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "定位坐标";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "机械坐标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "当前速度";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.terminate_btn);
            this.groupBox4.Controls.Add(this.run_btn);
            this.groupBox4.Controls.Add(this.download_btn);
            this.groupBox4.Controls.Add(this.lineNum_lab);
            this.groupBox4.Controls.Add(this.gcode_richtbx);
            this.groupBox4.Controls.Add(this.saveFile_btn);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.check_btn);
            this.groupBox4.Controls.Add(this.openFile_btn);
            this.groupBox4.Controls.Add(this.pause_btn);
            this.groupBox4.Controls.Add(this.upload_btn);
            this.groupBox4.Location = new System.Drawing.Point(429, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 533);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "G代码";
            // 
            // terminate_btn
            // 
            this.terminate_btn.Location = new System.Drawing.Point(168, 502);
            this.terminate_btn.Name = "terminate_btn";
            this.terminate_btn.Size = new System.Drawing.Size(75, 23);
            this.terminate_btn.TabIndex = 7;
            this.terminate_btn.Text = "停止";
            this.terminate_btn.UseVisualStyleBackColor = true;
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(6, 502);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 4;
            this.run_btn.Text = "运行";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(6, 476);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(75, 23);
            this.download_btn.TabIndex = 8;
            this.download_btn.Text = "下载";
            this.download_btn.UseVisualStyleBackColor = true;
            // 
            // lineNum_lab
            // 
            this.lineNum_lab.AutoSize = true;
            this.lineNum_lab.Location = new System.Drawing.Point(226, 481);
            this.lineNum_lab.Name = "lineNum_lab";
            this.lineNum_lab.Size = new System.Drawing.Size(11, 12);
            this.lineNum_lab.TabIndex = 11;
            this.lineNum_lab.Text = "0";
            // 
            // gcode_richtbx
            // 
            this.gcode_richtbx.Location = new System.Drawing.Point(6, 49);
            this.gcode_richtbx.Name = "gcode_richtbx";
            this.gcode_richtbx.Size = new System.Drawing.Size(269, 418);
            this.gcode_richtbx.TabIndex = 0;
            this.gcode_richtbx.Text = "";
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.Location = new System.Drawing.Point(87, 20);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(75, 23);
            this.saveFile_btn.TabIndex = 2;
            this.saveFile_btn.Text = "保存";
            this.saveFile_btn.UseVisualStyleBackColor = true;
            this.saveFile_btn.Click += new System.EventHandler(this.SaveFile_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "当前行：";
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(168, 20);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 3;
            this.check_btn.Text = "语法检查";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // openFile_btn
            // 
            this.openFile_btn.Location = new System.Drawing.Point(6, 20);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(75, 23);
            this.openFile_btn.TabIndex = 1;
            this.openFile_btn.Text = "打开";
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(87, 502);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 6;
            this.pause_btn.Text = "暂停";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(87, 476);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(75, 23);
            this.upload_btn.TabIndex = 9;
            this.upload_btn.Text = "上传";
            this.upload_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearGraph_btn);
            this.groupBox3.Controls.Add(this.zedGraph1);
            this.groupBox3.Location = new System.Drawing.Point(13, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 278);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动轨迹";
            // 
            // clearGraph_btn
            // 
            this.clearGraph_btn.Location = new System.Drawing.Point(323, 248);
            this.clearGraph_btn.Name = "clearGraph_btn";
            this.clearGraph_btn.Size = new System.Drawing.Size(75, 21);
            this.clearGraph_btn.TabIndex = 4;
            this.clearGraph_btn.Text = "清除轨迹";
            this.clearGraph_btn.UseVisualStyleBackColor = true;
            this.clearGraph_btn.Click += new System.EventHandler(this.ClearGraph_btn_Click);
            // 
            // zedGraph1
            // 
            this.zedGraph1.IsShowPointValues = true;
            this.zedGraph1.Location = new System.Drawing.Point(9, 19);
            this.zedGraph1.Name = "zedGraph1";
            this.zedGraph1.ScrollGrace = 0D;
            this.zedGraph1.ScrollMaxX = 0D;
            this.zedGraph1.ScrollMaxY = 0D;
            this.zedGraph1.ScrollMaxY2 = 0D;
            this.zedGraph1.ScrollMinX = 0D;
            this.zedGraph1.ScrollMinY = 0D;
            this.zedGraph1.ScrollMinY2 = 0D;
            this.zedGraph1.SelectButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraph1.Size = new System.Drawing.Size(390, 251);
            this.zedGraph1.TabIndex = 5;
            this.zedGraph1.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "手动速度设置：";
            // 
            // setSpeed_tbx
            // 
            this.setSpeed_tbx.Location = new System.Drawing.Point(274, 50);
            this.setSpeed_tbx.MaxLength = 5;
            this.setSpeed_tbx.Name = "setSpeed_tbx";
            this.setSpeed_tbx.Size = new System.Drawing.Size(56, 21);
            this.setSpeed_tbx.TabIndex = 13;
            this.setSpeed_tbx.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "Pulse/s";
            // 
            // setSpeed_btn
            // 
            this.setSpeed_btn.Location = new System.Drawing.Point(379, 48);
            this.setSpeed_btn.Name = "setSpeed_btn";
            this.setSpeed_btn.Size = new System.Drawing.Size(37, 23);
            this.setSpeed_btn.TabIndex = 15;
            this.setSpeed_btn.Text = "设置";
            this.setSpeed_btn.UseVisualStyleBackColor = true;
            this.setSpeed_btn.Click += new System.EventHandler(this.SetSpeed_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab_ErrMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLab_ErrMsg
            // 
            this.statusLab_ErrMsg.Name = "statusLab_ErrMsg";
            this.statusLab_ErrMsg.Size = new System.Drawing.Size(12, 17);
            this.statusLab_ErrMsg.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.setSpeed_btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.setSpeed_tbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SMC6940调试软件";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox ip_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label state_lab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xSpeed_tbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button uMoveRev_btn;
        private System.Windows.Forms.Button uMovePlus_btn;
        private System.Windows.Forms.Button zMoveRev_btn;
        private System.Windows.Forms.Button zMovePlus_btn;
        private System.Windows.Forms.Button yMoveRev_btn;
        private System.Windows.Forms.Button yMovePlus_btn;
        private System.Windows.Forms.Button xMoveRev_btn;
        private System.Windows.Forms.Button xMovePlus_btn;
        private System.Windows.Forms.Button setCoor_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button gotoCoor_btn;
        private System.Windows.Forms.TextBox uSetCoor_tbx;
        private System.Windows.Forms.TextBox zSetCoor_tbx;
        private System.Windows.Forms.TextBox ySetCoor_tbx;
        private System.Windows.Forms.TextBox xSetCoor_tbx;
        private System.Windows.Forms.TextBox uGotoCoor_tbx;
        private System.Windows.Forms.TextBox zGotoCoor_tbx;
        private System.Windows.Forms.TextBox yGotoCoor_tbx;
        private System.Windows.Forms.TextBox xGotoCoor_tbx;
        private System.Windows.Forms.TextBox uMachCoor_tbx;
        private System.Windows.Forms.TextBox zMachCoor_tbx;
        private System.Windows.Forms.TextBox yMachCoor_tbx;
        private System.Windows.Forms.TextBox xMachCoor_tbx;
        private System.Windows.Forms.TextBox uSpeed_tbx;
        private System.Windows.Forms.TextBox zSpeed_tbx;
        private System.Windows.Forms.TextBox ySpeed_tbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button backZero_btn;
        private System.Windows.Forms.Button setZero_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Button terminate_btn;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.RichTextBox gcode_richtbx;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lineNum_lab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox setSpeed_tbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button setSpeed_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLab_ErrMsg;
        private System.Windows.Forms.Button clearGraph_btn;
        private ZedGraph.ZedGraphControl zedGraph1;
    }
}

