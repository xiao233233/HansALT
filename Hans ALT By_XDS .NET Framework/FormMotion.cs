using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UserControl_XDS;

namespace Hans_ALT_By_XDS.NET_Framework
{
    public partial class FormMotion : Form
    {
        public FormMotion()
        {
            InitializeComponent();
        }

        private void FormMotion_Load(object sender, EventArgs e)
        {

            //给panel添加自动滚动条
            flowLayoutPanelIntput.AutoScroll = true;
            flowLayoutPanelOutput.AutoScroll = true;
            //实例化一个xml操作对象
            XmlDocument ioConfig = new XmlDocument();
            ioConfig.Load(@"..\parameter\ioConfig.xml");
            //ioConfig.Load("ioConfig.xml");
            //获取in节点下面的节点集合
            XmlNodeList nodelistInput = ioConfig.GetElementsByTagName("in");
            //获取out节点下面的节点集合
            XmlNodeList nodelistOutput = ioConfig.GetElementsByTagName("out");
            //遍历in子节点
            foreach (XmlNode xn in nodelistInput)
            {
                XmlElement xmle = (XmlElement)xn;
                IOControl control = new IOControl();
                control.PortName = "[" + xmle.GetAttribute("nDeviceID") + "]" + xmle.GetAttribute("name");
                flowLayoutPanelIntput.Controls.Add(control);

            }
            //遍历out子节点
            foreach (XmlNode xn in nodelistInput)
            {
                XmlElement xmle = (XmlElement)xn;
                IOControl control = new IOControl();
                control.PortName = "[" + xmle.GetAttribute("nDeviceID") + "]" + xmle.GetAttribute("name");
                flowLayoutPanelOutput.Controls.Add(control);

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //一种是用switch case   case 1:  break; case 2: break; case 3: break; default: break;
            //一种是使用if --else if --else if --else
            #region switch case 来选择页面显示内容
            //switch (tabControl1.SelectedIndex)
            //{
            //    case 1:
            //        LoadtabPage1();
            //        break;
            //    case 2:
            //        LoadtabPage2();
            //        break;
            //    default:
            //        // 默认情况下的处理
            //        break;
            //}
            #endregion 
            if (tabControl1.SelectedTab == tabPage1)
            {

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {

            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                flowLayoutPanelIntput.Controls.Clear();
                flowLayoutPanelOutput.Controls.Clear();
                //给panel添加自动滚动条
                flowLayoutPanelIntput.AutoScroll = true;
                flowLayoutPanelOutput.AutoScroll = true;
                //实例化一个xml操作对象
                XmlDocument ioConfig = new XmlDocument();
                ioConfig.Load(@"..\parameter\ioConfig.xml");
                //ioConfig.Load("ioConfig.xml");
                //获取in节点下面的节点集合
                XmlNodeList nodelistInput = ioConfig.GetElementsByTagName("in");
                //获取out节点下面的节点集合
                XmlNodeList nodelistOutput = ioConfig.GetElementsByTagName("out");
                //遍历in子节点
                foreach (XmlNode xn in nodelistInput)
                {
                    XmlElement xmle = (XmlElement)xn;
                    IOControl control = new IOControl();
                    control.PortName = "[" + xmle.GetAttribute("nDeviceID") + "]" + xmle.GetAttribute("name");
                    flowLayoutPanelIntput.Controls.Add(control);

                }
                //遍历out子节点
                foreach (XmlNode xn in nodelistInput)
                {
                    XmlElement xmle = (XmlElement)xn;
                    IOControl control = new IOControl();
                    control.PortName = "[" + xmle.GetAttribute("nDeviceID") + "]" + xmle.GetAttribute("name");
                    flowLayoutPanelOutput.Controls.Add(control);

                }
            }
        }
    }
}
