using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hans_ALT_By_XDS.NET_Framework
{
    public partial class FormMessageShow : Form
    {
        public FormMessageShow()
        {
            InitializeComponent();
        }

        //窗口单例模式
        private static FormMessageShow _formMessageShow;
        public static FormMessageShow FormIntence()
        {
            if (_formMessageShow == null)
                _formMessageShow = new FormMessageShow();
            return _formMessageShow;
        }
        //初始化各模块，并显示初始化状态
        private delegate void displayMessage(string msg);
        private void DispMsg(string str)
        {
            if (!labelMessage.InvokeRequired)
            {
                labelMessage.Text = str;
            }
            else
            {
                displayMessage dst = DispMsg;
                this.Invoke(dst, str);
            }
        }
        public void ShowMsg(string str)
        {
            _formMessageShow.DispMsg(str);
            _formMessageShow.Show();
            _formMessageShow.Refresh();
        }
        public void CloseMsg()
        {
            _formMessageShow.Hide();
        }
    }
}
