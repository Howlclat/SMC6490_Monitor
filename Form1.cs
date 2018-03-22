using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using csSMC6X;
using ZedGraph;

namespace SMC6490_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init_zedGraph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_handle = (IntPtr)(0);          
        }

        IntPtr m_handle;    //连接标识
        bool isruning = true;
        double[] cur_pos = new double[4] { 0, 0, 0, 0 };
        double[] cur_speed = new double[4] { 0, 0, 0, 0 };
        PointPairList trailList = new PointPairList();
        PointPairList pointList = new PointPairList();

        /// <summary>
        /// zedgraph控件初始化，标题、坐标轴设置
        /// </summary>
        private void Init_zedGraph()
        {
            GraphPane myPane = zedGraph1.GraphPane;
            
            myPane.CurveList.Clear();                   //清空绘制区
            myPane.GraphObjList.Clear();

            myPane.Title.IsVisible = false;             //不显示标题
            myPane.XAxis.Title.Text = "X";
            myPane.YAxis.Title.Text = "Y";
            myPane.YAxis.MajorGrid.IsVisible = true;    //设置虚线
            myPane.XAxis.MajorGrid.IsVisible = true;    //设置虚线

            LineItem trailCurve = myPane.AddCurve("轨迹", trailList, Color.Blue, SymbolType.None);
            trailCurve.Label.IsVisible = false;         //不显示线标

            LineItem pointCurve = myPane.AddCurve("当前坐标点", pointList, Color.Red, SymbolType.XCross);
            pointCurve.Line.IsVisible = false;
            pointCurve.Label.IsVisible = false;

            myPane.AxisChange();                        //在数据变化时绘制图形
        }
        /// <summary>
        /// 连接或断开控制器
        /// </summary>
        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                int iret = -1;
                string ipStr = ip_tbx.Text;
                if (!IsIP(ipStr))
                {
                    state_lab.Text = "IP地址无效";
                    return;
                }
                state_lab.Text = "正在连接";
                iret = SMC6X.SMCOpenEth(ipStr, ref m_handle); //连接网络  
                if (0 != iret)
                {
                    state_lab.Text = "连接失败";
                    MessageBox.Show("连接失败");
                    return;
                }
                state_lab.Text = "已连接";
                timer1.Start();
                connect_btn.Text = "断开连接";
            }
            else
            {
                SMC6X.SMCClose(m_handle);
                m_handle = (IntPtr)(0);
                connect_btn.Text = "连接设备";
                state_lab.Text = "未连接";
                timer1.Stop();
            }
        }
        /// <summary>
        /// timer定时器响应函数
        /// </summary>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            double last_x = cur_pos[0], last_y = cur_pos[1];

            for (Byte axis = 0; axis < 4; axis++)
                SMC6X.SMCGetPosition(m_handle, axis, ref cur_pos[axis]);
            xMachCoor_tbx.Text = cur_pos[0].ToString("F2");
            yMachCoor_tbx.Text = cur_pos[1].ToString("F2");
            zMachCoor_tbx.Text = cur_pos[2].ToString("F2");
            uMachCoor_tbx.Text = cur_pos[3].ToString("F2");

            for (Byte axis = 0; axis < 4; axis++)
                SMC6X.SMCGetCurSpeed(m_handle, axis, ref cur_speed[axis]);
            xSpeed_tbx.Text = Convert.ToString(cur_speed[0]);
            ySpeed_tbx.Text = Convert.ToString(cur_speed[1]);
            zSpeed_tbx.Text = Convert.ToString(cur_speed[2]);
            uSpeed_tbx.Text = Convert.ToString(cur_speed[3]);

            if (isruning)
            {
                int num = 0;
                SMC6X.SMCGetCurRunningLine(m_handle, ref num);
                lineNum_lab.Text = num.ToString();
            }

            if (cur_pos[0] != last_x || cur_pos[1] != last_y)
            {
                pointList.Clear();
                trailList.Add(cur_pos[0], cur_pos[1]);
                pointList.Add(cur_pos[0], cur_pos[1]);
                zedGraph1.GraphPane.AxisChange();  // 在数据变化时绘制图形
                zedGraph1.Invalidate();//刷新
            }
        }
        /// <summary>
        /// 判断是否为ip，利用正则表达式
        /// </summary>
        /// <param name="ip">待检查的字符串类型ip地址</param>
        /// <returns>是否为ip</returns>
        public static bool IsIP(string ip)
        {
            string pattern = @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$";
            return Regex.IsMatch(ip, pattern);
        }
        /// <summary>
        /// 判断是否为数字，利用正则表达式
        /// </summary>
        /// <param name="num">输入字符串类型数字</param>
        /// <returns>是否为数字</returns>
        public static bool IsNum(string num)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(num, pattern);
        }
        /// <summary>
        /// 打开G代码文件
        /// </summary>
        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "刀路文件(*.nc)|*.nc|文本文件(*.txt)|*.txt|所有文件|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SReader = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                gcode_richtbx.Text = SReader.ReadToEnd();
                SReader.Close();
            }  
        }
        /// <summary>
        /// 保存G代码文件
        /// </summary>
        private void SaveFile_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "刀路文件(*.nc)|*.nc|文本文件(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SWriter = new StreamWriter(saveFileDialog1.FileName, true);
                SWriter.Write(gcode_richtbx.Text);
                SWriter.Close();
            }
        }
        /// <summary>
        /// 点动按钮按下（未抬起）时触发，控制某轴点动，定速运动
        /// </summary>
        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "xMovePlus_btn":
                    SMC6X.SMCVMove(m_handle, 0, 1); break;
                case "xMoveRev_btn":
                    SMC6X.SMCVMove(m_handle, 0, 0); break;
                case "yMovePlus_btn":
                    SMC6X.SMCVMove(m_handle, 1, 1); break;
                case "yMoveRev_btn":
                    SMC6X.SMCVMove(m_handle, 1, 0); break;
                case "zMovePlus_btn":
                    SMC6X.SMCVMove(m_handle, 2, 1); break;
                case "zMoveRev_btn":
                    SMC6X.SMCVMove(m_handle, 2, 0); break;
                case "uMovePlus_btn":
                    SMC6X.SMCVMove(m_handle, 3, 1); break;
                case "uMoveRev_btn":
                    SMC6X.SMCVMove(m_handle, 3, 0); break;
                default: break;
            }
        }
        /// <summary>
        /// 抬起（松开）点动按钮时触发，停止定速运动
        /// </summary>
        private void Move_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }
            Button btn = (Button)sender;
            if (btn.Name == ("xMovePlus_btn") || btn.Name == ("xMoveRev_btn"))
            {
                SMC6X.SMCDecelStop(m_handle, 0);
            }
            else if(btn.Name == ("yMovePlus_btn") || btn.Name == ("yMoveRev_btn"))
            {
                SMC6X.SMCDecelStop(m_handle, 1);
            }
            else if (btn.Name == ("zMovePlus_btn") || btn.Name == ("zMoveRev_btn"))
            {
                SMC6X.SMCDecelStop(m_handle, 2);
            }
            else if (btn.Name == ("uMovePlus_btn") || btn.Name == ("uMoveRev_btn"))
            {
                SMC6X.SMCDecelStop(m_handle, 3);
            }
        }
        /// <summary>
        /// 设置手动操作速度按钮，设置手动速度
        /// </summary>
        private void SetSpeed_btn_Click(object sender, EventArgs e)
        {
            Int32 speed = 0;
            try
            {
                speed = Convert.ToInt32(setSpeed_tbx.Text);
            }
            catch
            {
                MessageBox.Show("不是有效的数字","设置信息");
                return;
            }
            SMC6X.SMCSetLocateSpeed(m_handle, 0, speed); //设置运动速度，1000 Pulse/s;
            //SMC6X.SMCSetLocateAcceleration(m_handle, 0, 20); //设置运动加速度，2000 Pulse/s2;
            MessageBox.Show("设置成功");
        }
        /// <summary>
        /// 运动控制相关按钮，分别实现回零、设零点、定位、修改坐标、停止运动功能
        /// </summary>
        private void MoveControl_Click(object sender, EventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "backZero_btn":
                    SMC6X.SMCHomeMove(m_handle, 2);
                    SMC6X.SMCHomeMove(m_handle, 0);
                    SMC6X.SMCHomeMove(m_handle, 1);
                    break;
                case "setZero_btn":
                    for(byte i = 0; i < 3; i++)
                    {
                        SMC6X.SMCSetPosition(m_handle, i, 0.0);
                    }
                    break;
                case "gotoCoor_btn":
                    double[] gotocoor = new double[4];
                    try
                    {
                        gotocoor[0] = Convert.ToDouble(xGotoCoor_tbx.Text);
                        gotocoor[1] = Convert.ToDouble(yGotoCoor_tbx.Text);
                        gotocoor[2] = Convert.ToDouble(zGotoCoor_tbx.Text);
                        gotocoor[3] = Convert.ToDouble(uGotoCoor_tbx.Text);
                    }
                    catch
                    {
                        MessageBox.Show("无效数字");
                        return;
                    }
                    for(byte i = 0; i < 3; i++)
                    {
                        SMC6X.SMCPMove(m_handle, i, gotocoor[i], 1);
                    }
                    break;
                case "setCoor_btn":
                    double[] setcoor = new double[4];
                    try
                    {
                        setcoor[0] = Convert.ToDouble(xSetCoor_tbx.Text);
                        setcoor[1] = Convert.ToDouble(ySetCoor_tbx.Text);
                        setcoor[2] = Convert.ToDouble(zSetCoor_tbx.Text);
                        setcoor[3] = Convert.ToDouble(uSetCoor_tbx.Text);
                    }
                    catch
                    {
                        MessageBox.Show("无效数字");
                        return;
                    }                      
                    for(byte i = 0; i < 3; i++)
                    {
                        SMC6X.SMCSetPosition(m_handle, i, setcoor[i]);
                    }
                    break;
                case "stop_btn":
                    SMC6X.SMCEmgStop(m_handle);
                    isruning = false;
                    //SMCDecelStop 减速停止
                    //SMCImdStop 立即停止
                    //SMCEmgStop 紧急停止
                    break;
                default: break;
            }

        }
        /// <summary>
        /// 点击按钮触发清除轨迹
        /// </summary>
        private void ClearGraph_btn_Click(object sender, EventArgs e)
        {
            trailList.Clear();
            zedGraph1.Invalidate();//刷新
        }
        /// <summary>
        /// 点击按钮触发，进行语法检查
        /// </summary>
        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }
            Byte errorMassage = 0;
            int iresult = -1;

            iresult = SMC6X.SMCCheckProgramSyntax(gcode_richtbx.Text, ref errorMassage);
            if(iresult == 0)
            {
                MessageBox.Show("语法正确", "检查信息");
            }
            else
            {
                MessageBox.Show("存在语法错误", "检查信息");
                return;
            }
            
        }
        /// <summary>
        /// 点击运行按钮触发，将程序下载到RAM并运行
        /// </summary>

        private void Run_btn_Click(object sender, EventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }
            Byte errorMassage = 0;
            int iresult = 1;

            iresult = SMC6X.SMCCheckProgramSyntax(gcode_richtbx.Text, ref errorMassage);
            if (iresult != 0)
            {
                MessageBox.Show("存在语法错误", "检查信息");
                return;
            }

            iresult = SMC6X.SMCDownMemProgramToRamAndRun(m_handle, gcode_richtbx.Text, gcode_richtbx.TextLength);
            if (iresult != 0)
            {
                MessageBox.Show("下载运行失败", "运行信息");
            }
            isruning = true;
        }
        /// <summary>
        /// 点击暂停按钮触发，暂停运行当前程序，再次点击继续运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause_btn_Click(object sender, EventArgs e)
        {
            if (m_handle == (IntPtr)(0))
            {
                MessageBox.Show("未连接控制器！");
                return;
            }
            if (isruning)
            {
                SMC6X.SMCPause(m_handle);
                pause_btn.Text = "继续";
                isruning = false;
            }
            else
            {
                SMC6X.SMCContinueRun(m_handle);
                pause_btn.Text = "暂停";
                isruning = true;
            }
        }
        /// <summary>
        /// 点击停止按钮触发，停止运行当前程序
        /// </summary>
        private void Terminate_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
