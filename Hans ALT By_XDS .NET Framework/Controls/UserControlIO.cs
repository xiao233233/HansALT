using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hans_ALT_By_XDS.NET_Framework.Controls
{
    public partial class IOControl : UserControl
    {
        public IOControl()
        {
            InitializeComponent();
        }
        //public IOControl(IOEntity nIOEntity)
        //{
        //    InitializeComponent();
        //    PortName = nIOEntity.PortName;
        //    PortNum = nIOEntity.PortNum;
        //    PortType = nIOEntity.PortType;
        //    PortTag = nIOEntity.PortTag;
        //}
        public IOControl(string nPortName, int nPortNum, IOType nPortType = IOType.InPut, string nPortTag = "")
        {
            InitializeComponent();
            PortName = nPortName;
            PortNum = nPortNum;
            PortType = nPortType;
            PortTag = nPortTag;
        }
        public IOControl(IOControl IOCtrl)
        {
            InitializeComponent();
            PortName = IOCtrl.PortName;
            PortNum = IOCtrl.PortNum;
            PortType = IOCtrl.PortType;
            DisplayName = IOCtrl.DisplayName;
            PortTag = IOCtrl.PortTag;
        }
        #region 属性
        private string _PortTag = "M";
        [Category("输入输出"), Description("标签")]
        public string PortTag
        {
            get { return _PortTag; }
            set { _PortTag = value; }
        }
        private IOType _PortType = IOType.InPut;
        [Category("输入输出"), Description("输出端口类别")]
        public IOType PortType
        {
            get { return _PortType; }
            set
            {
                _PortType = value;
                if (_PortType == IOType.OutPut)
                {
                    pictureBox1.Cursor = Cursors.Hand;
                }
                else
                {
                    pictureBox1.Cursor = Cursors.Default;
                }
            }
        }
        private bool _DisplayName = true;
        [Category("输入输出"), Description("是否显示名称")]
        public bool DisplayName
        {
            get { return _DisplayName; }
            set
            {
                _DisplayName = value;
                if (_DisplayName)
                {
                    SensorsName.Visible = true;
                }
                else
                {
                    SensorsName.Visible = false;
                }
            }
        }
        private int _PortNum = 0;
        [Category("输入输出"), Description("输出端口号")]
        public int PortNum
        {
            get { return _PortNum; }
            set { _PortNum = value; }
        }
        private string _PortName = "未命名";
        [Category("输入输出"), Description("输出端口名称")]
        public string PortName
        {
            get { return _PortName; }
            set
            {
                _PortName = value;
                SensorsName.Text = _PortName;
            }
        }
        private IOValue _PortValue = IOValue.Disable;
        [Category("输入输出"), Description("输出端口值"), XmlIgnore]
        public IOValue PortValue
        {
            get { return _PortValue; }
            set
            {
                if (value == IOValue.ON && _PortValue != IOValue.ON)
                {
                    //上升沿
                    OnIOValueRising(this, new IOEventArgs(PortNum, value, IOEdge.RisingEdge));
                    OnChangeIOValue(this, new IOEventArgs(PortNum, value));
                }
                else if (value == IOValue.OFF && _PortValue == IOValue.ON)
                {
                    OnIOValueFalling(this, new IOEventArgs(PortNum, value, IOEdge.FallingEdge));
                    OnChangeIOValue(this, new IOEventArgs(PortNum, value));
                }
                _PortValue = value;
                try
                {
                    if (_PortValue == IOValue.OFF)
                        pictureBox1.Image = global::Hans_ALT_By_XDS.NET_Framework.Properties.Resources.指示灯_红色;
                    else if (_PortValue == IOValue.ON)
                        pictureBox1.Image = global::Hans_ALT_By_XDS.NET_Framework.Properties.Resources.指示灯_绿色;
                    else
                        pictureBox1.Image = global::Hans_ALT_By_XDS.NET_Framework.Properties.Resources.指示灯_灰色;
                }
                catch (Exception e)
                { }
            }
        }
        #endregion
        #region 自定义事件
        public delegate void EditIOValue(object sender, IOEventArgs e);
        [Category("IO事件"), Description("动作按钮")]
        public event EditIOValue ChangeIOValue;
        [Category("IO事件"), Description("上升沿触发")]
        public event EditIOValue IOValueRising;
        [Category("IO事件"), Description("下降沿触发")]
        public event EditIOValue IOValueFalling;

        private void OnChangeIOValue(object sender, IOEventArgs e)
        {
            if (this.ChangeIOValue != null)
            {
                this.ChangeIOValue(this, e);
            }
        }
        private void OnIOValueRising(object sender, IOEventArgs e)
        {
            if (this.IOValueRising != null)
            {
                this.IOValueRising(this, e);
            }
        }
        private void OnIOValueFalling(object sender, IOEventArgs e)
        {
            if (this.IOValueFalling != null)
            {
                this.IOValueFalling(this, e);
            }
        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_PortType == IOType.OutPut)
            {
                IOValue changeValue;
                if (PortValue == IOValue.OFF)
                {
                    changeValue = IOValue.ON;
                }
                else if (PortValue == IOValue.ON)
                {
                    changeValue = IOValue.OFF;
                }
                else
                {
                    changeValue = IOValue.Disable;
                    return;
                }
                PortValue = changeValue;
            }
        }
        private void IOControl_Load(object sender, EventArgs e)
        {
            PortType = _PortType;
        }
    };
    public class IOEventArgs : EventArgs
    {
        public int PortNum;
        public IOValue PortValue;
        public IOEdge PortEdge;
        public IOEventArgs(int nPortNum, IOValue nPortValue, IOEdge nPortEdge = IOEdge.None)
        {
            PortNum = nPortNum;
            PortValue = nPortValue;
            PortEdge = nPortEdge;
        }
    };
    /// <summary>
    /// 输入输出值
    /// </summary>
    public enum IOValue
    {
        /// <summary>
        /// 关,OFF 0
        /// </summary>
        OFF = 0,
        /// <summary>
        /// 开,ON 1
        /// </summary>
        ON = 1,

        Disable = -1,
    };
    public enum IOType
    {
        /// <summary>
        /// 输入
        /// </summary>
        InPut = 0,
        /// <summary>
        /// 输出
        /// </summary>
        OutPut,
    }
    public enum IOEdge
    {
        /// <summary>
        /// 无跳变
        /// </summary>
        None = -1,
        /// <summary>
        /// 上升沿
        /// </summary>
        RisingEdge = 1,
        /// <summary>
        /// 下降沿
        /// </summary>
        FallingEdge = 0,
    }
}
