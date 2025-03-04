namespace Hans_ALT_By_XDS.NET_Framework
{
    partial class FormMotion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDEC = new System.Windows.Forms.TextBox();
            this.textBoxACC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSTOP = new System.Windows.Forms.Button();
            this.buttonBackToZero = new System.Windows.Forms.Button();
            this.buttonClearErrors = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonDisEnable = new System.Windows.Forms.Button();
            this.buttonPositive = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSteppingMotorHome = new System.Windows.Forms.Button();
            this.buttonSteppingMotorMove = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAxisPoint = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAxis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewAxisState = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxIntput = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelIntput = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisPoint)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisState)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxIntput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 502);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "参数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDEC);
            this.groupBox2.Controls.Add(this.textBoxACC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDistance);
            this.groupBox2.Controls.Add(this.textBoxSpeed);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSTOP);
            this.groupBox2.Controls.Add(this.buttonBackToZero);
            this.groupBox2.Controls.Add(this.buttonClearErrors);
            this.groupBox2.Controls.Add(this.buttonNegative);
            this.groupBox2.Controls.Add(this.buttonDisEnable);
            this.groupBox2.Controls.Add(this.buttonPositive);
            this.groupBox2.Controls.Add(this.buttonEnable);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动测试";
            // 
            // textBoxDEC
            // 
            this.textBoxDEC.Location = new System.Drawing.Point(178, 91);
            this.textBoxDEC.Name = "textBoxDEC";
            this.textBoxDEC.Size = new System.Drawing.Size(68, 21);
            this.textBoxDEC.TabIndex = 14;
            // 
            // textBoxACC
            // 
            this.textBoxACC.Location = new System.Drawing.Point(178, 33);
            this.textBoxACC.Name = "textBoxACC";
            this.textBoxACC.Size = new System.Drawing.Size(66, 21);
            this.textBoxACC.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "减速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "加速度";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(52, 91);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(68, 21);
            this.textBoxDistance.TabIndex = 10;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(52, 33);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(66, 21);
            this.textBoxSpeed.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "步长";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "速度";
            // 
            // buttonSTOP
            // 
            this.buttonSTOP.Location = new System.Drawing.Point(511, 23);
            this.buttonSTOP.Name = "buttonSTOP";
            this.buttonSTOP.Size = new System.Drawing.Size(75, 100);
            this.buttonSTOP.TabIndex = 6;
            this.buttonSTOP.Text = "停止";
            this.buttonSTOP.UseVisualStyleBackColor = true;
            // 
            // buttonBackToZero
            // 
            this.buttonBackToZero.Location = new System.Drawing.Point(430, 79);
            this.buttonBackToZero.Name = "buttonBackToZero";
            this.buttonBackToZero.Size = new System.Drawing.Size(75, 44);
            this.buttonBackToZero.TabIndex = 5;
            this.buttonBackToZero.Text = "回零";
            this.buttonBackToZero.UseVisualStyleBackColor = true;
            // 
            // buttonClearErrors
            // 
            this.buttonClearErrors.Location = new System.Drawing.Point(430, 21);
            this.buttonClearErrors.Name = "buttonClearErrors";
            this.buttonClearErrors.Size = new System.Drawing.Size(75, 44);
            this.buttonClearErrors.TabIndex = 4;
            this.buttonClearErrors.Text = "清错";
            this.buttonClearErrors.UseVisualStyleBackColor = true;
            // 
            // buttonNegative
            // 
            this.buttonNegative.Location = new System.Drawing.Point(349, 80);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(75, 44);
            this.buttonNegative.TabIndex = 3;
            this.buttonNegative.Text = "反向运动";
            this.buttonNegative.UseVisualStyleBackColor = true;
            // 
            // buttonDisEnable
            // 
            this.buttonDisEnable.Location = new System.Drawing.Point(349, 22);
            this.buttonDisEnable.Name = "buttonDisEnable";
            this.buttonDisEnable.Size = new System.Drawing.Size(75, 44);
            this.buttonDisEnable.TabIndex = 2;
            this.buttonDisEnable.Text = "去使能";
            this.buttonDisEnable.UseVisualStyleBackColor = true;
            // 
            // buttonPositive
            // 
            this.buttonPositive.Location = new System.Drawing.Point(268, 79);
            this.buttonPositive.Name = "buttonPositive";
            this.buttonPositive.Size = new System.Drawing.Size(75, 44);
            this.buttonPositive.TabIndex = 1;
            this.buttonPositive.Text = "正向运动";
            this.buttonPositive.UseVisualStyleBackColor = true;
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(268, 21);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(75, 44);
            this.buttonEnable.TabIndex = 0;
            this.buttonEnable.Text = "使能";
            this.buttonEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSteppingMotorHome);
            this.groupBox3.Controls.Add(this.buttonSteppingMotorMove);
            this.groupBox3.Location = new System.Drawing.Point(593, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "步进联动";
            // 
            // buttonSteppingMotorHome
            // 
            this.buttonSteppingMotorHome.Location = new System.Drawing.Point(106, 31);
            this.buttonSteppingMotorHome.Name = "buttonSteppingMotorHome";
            this.buttonSteppingMotorHome.Size = new System.Drawing.Size(75, 44);
            this.buttonSteppingMotorHome.TabIndex = 16;
            this.buttonSteppingMotorHome.Text = "步进回零";
            this.buttonSteppingMotorHome.UseVisualStyleBackColor = true;
            // 
            // buttonSteppingMotorMove
            // 
            this.buttonSteppingMotorMove.Location = new System.Drawing.Point(6, 31);
            this.buttonSteppingMotorMove.Name = "buttonSteppingMotorMove";
            this.buttonSteppingMotorMove.Size = new System.Drawing.Size(75, 44);
            this.buttonSteppingMotorMove.TabIndex = 15;
            this.buttonSteppingMotorMove.Text = "步进压合";
            this.buttonSteppingMotorMove.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewAxisPoint);
            this.panel2.Location = new System.Drawing.Point(9, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 113);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewAxisPoint
            // 
            this.dataGridViewAxisPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAxisPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAxisPoint.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAxisPoint.Name = "dataGridViewAxisPoint";
            this.dataGridViewAxisPoint.RowTemplate.Height = 23;
            this.dataGridViewAxisPoint.Size = new System.Drawing.Size(775, 113);
            this.dataGridViewAxisPoint.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAxis);
            this.panel1.Location = new System.Drawing.Point(9, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 150);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewAxis
            // 
            this.dataGridViewAxis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAxis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAxis.Name = "dataGridViewAxis";
            this.dataGridViewAxis.RowTemplate.Height = 23;
            this.dataGridViewAxis.Size = new System.Drawing.Size(775, 150);
            this.dataGridViewAxis.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工站编号";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(511, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(53, 16);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "工位6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(410, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "工位5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(309, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "工位4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(208, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "工位3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "工位2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "工位1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAxisState);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "轴状态";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAxisState
            // 
            this.dataGridViewAxisState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAxisState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAxisState.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAxisState.Name = "dataGridViewAxisState";
            this.dataGridViewAxisState.RowTemplate.Height = 23;
            this.dataGridViewAxisState.Size = new System.Drawing.Size(786, 470);
            this.dataGridViewAxisState.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxOutput);
            this.tabPage3.Controls.Add(this.groupBoxIntput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.flowLayoutPanelOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 209);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(786, 264);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "输出信号";
            // 
            // flowLayoutPanelOutput
            // 
            this.flowLayoutPanelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOutput.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanelOutput.Name = "flowLayoutPanelOutput";
            this.flowLayoutPanelOutput.Size = new System.Drawing.Size(780, 244);
            this.flowLayoutPanelOutput.TabIndex = 0;
            // 
            // groupBoxIntput
            // 
            this.groupBoxIntput.Controls.Add(this.flowLayoutPanelIntput);
            this.groupBoxIntput.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxIntput.Location = new System.Drawing.Point(3, 3);
            this.groupBoxIntput.Name = "groupBoxIntput";
            this.groupBoxIntput.Size = new System.Drawing.Size(786, 200);
            this.groupBoxIntput.TabIndex = 0;
            this.groupBoxIntput.TabStop = false;
            this.groupBoxIntput.Text = "输入信号";
            // 
            // flowLayoutPanelIntput
            // 
            this.flowLayoutPanelIntput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelIntput.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanelIntput.Name = "flowLayoutPanelIntput";
            this.flowLayoutPanelIntput.Size = new System.Drawing.Size(780, 180);
            this.flowLayoutPanelIntput.TabIndex = 0;
            // 
            // FormMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMotion";
            this.Text = "运动控制";
            this.Load += new System.EventHandler(this.FormMotion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAxisState)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxIntput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAxis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSTOP;
        private System.Windows.Forms.Button buttonBackToZero;
        private System.Windows.Forms.Button buttonClearErrors;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonDisEnable;
        private System.Windows.Forms.Button buttonPositive;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.DataGridView dataGridViewAxisPoint;
        private System.Windows.Forms.TextBox textBoxDEC;
        private System.Windows.Forms.TextBox textBoxACC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSteppingMotorHome;
        private System.Windows.Forms.Button buttonSteppingMotorMove;
        private System.Windows.Forms.DataGridView dataGridViewAxisState;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxIntput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOutput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIntput;
    }
}