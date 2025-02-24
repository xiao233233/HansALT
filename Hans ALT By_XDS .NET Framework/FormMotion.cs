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

    }
}
