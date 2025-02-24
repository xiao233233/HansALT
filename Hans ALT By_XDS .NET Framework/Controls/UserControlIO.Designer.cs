namespace Hans_ALT_By_XDS.NET_Framework.Controls
{
    partial class IOControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SensorsName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SensorsName
            // 
            this.SensorsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SensorsName.Location = new System.Drawing.Point(30, 0);
            this.SensorsName.Name = "SensorsName";
            this.SensorsName.Size = new System.Drawing.Size(120, 30);
            this.SensorsName.TabIndex = 1;
            this.SensorsName.Text = "[-1]IO名称";
            this.SensorsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Hans_ALT_By_XDS.NET_Framework.Properties.Resources.指示灯_灰色;
            this.pictureBox1.InitialImage = global::Hans_ALT_By_XDS.NET_Framework.Properties.Resources.指示灯_灰色;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IOControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SensorsName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IOControl";
            this.Size = new System.Drawing.Size(150, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SensorsName;
    }
}
