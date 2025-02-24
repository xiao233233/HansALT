using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hans_ALT_By_XDS.NET_Framework
{
    internal static class Program
    {
        public static System.Threading.Mutex RUN;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool noRun = false;
            RUN = new System.Threading.Mutex(true, "SmsProgram", out noRun);
            if (noRun)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormHome.Instance.MachineName = "Hans ALT By_XDS";//设置项目名称
                FormHome.Instance.MachineVer = "V1.0";//设置版本号
                                                      //NBCommon.MainForm.Instance.MachineLogo=//设置LOGO图片
                Application.Run(FormHome.Instance);
            }
            else
            {
                MessageBox.Show("程序已运行!", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
