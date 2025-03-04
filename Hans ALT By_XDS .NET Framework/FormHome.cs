using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDSMotion;

namespace Hans_ALT_By_XDS.NET_Framework
{
    public partial class FormHome : Form
    {
        #region 引用叶明林代码
        /// <summary>
        /// 窗体对象实例,窗口唯一
        /// </summary>
        private static FormHome _instance;
        private static object obj = new object();

        public FormHome()
        {
            InitializeComponent();
            timer1.Enabled = true;
            _instance = this;
            #region 临时测试，增加初始化界面           
            FormMessageShow.FormIntence().ShowMsg("正在初始化运动控制组件。。。");
            try
            {
                //InitIO();
                string str = "test";
                Thread.Sleep(5000);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMessageShow.FormIntence().CloseMsg();
            }
            #endregion          
        }
        public static FormHome Instance
        {
            get
            {
                lock (obj)
                {
                    if (_instance == null)
                        _instance = new FormHome();
                    return _instance;
                }
            }
        }
        private string _MachineName = "自动检测系统";
        [Category("设备信息"), Description("设备名称")]
        public string MachineName
        {
            get { return _MachineName; }
            set
            {
                _MachineName = value;
                //label1.Text = _MachineName;
                //label2.Location = new Point(label1.Location.X + label1.Size.Width, label1.Location.Y + label1.Height / 2);
                this.Text = _MachineName + _MachineVer;
            }
        }
        private string _MachineVer = "V1.0";
        [Category("设备信息"), Description("设备版本")]
        public string MachineVer
        {
            get { return _MachineVer; }
            set
            {
                _MachineVer = value;
                //label2.Text = _MachineVer;
                this.Text = _MachineName + _MachineVer;
            }
        }
        #endregion
        private void 运动控制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Class_from.CheckForm(typeof(FormMotion).Name))
            {
                Class_from.formMotion = new FormMotion();
                Class_from.formMotion.Show();
                Class_from.formMotion.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTimer.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
