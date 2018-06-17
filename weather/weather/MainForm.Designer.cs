namespace weather
{
    partial class FormMain
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
            this.cbxPro = new System.Windows.Forms.ComboBox();
            this.labPro = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.btnReq = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPro
            // 
            this.cbxPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPro.FormattingEnabled = true;
            this.cbxPro.Location = new System.Drawing.Point(36, 29);
            this.cbxPro.Name = "cbxPro";
            this.cbxPro.Size = new System.Drawing.Size(121, 20);
            this.cbxPro.TabIndex = 0;
            this.cbxPro.SelectedIndexChanged += new System.EventHandler(this.cbxPro_SelectedIndexChanged);
            // 
            // labPro
            // 
            this.labPro.AutoSize = true;
            this.labPro.Location = new System.Drawing.Point(13, 32);
            this.labPro.Name = "labPro";
            this.labPro.Size = new System.Drawing.Size(17, 12);
            this.labPro.TabIndex = 1;
            this.labPro.Text = "省";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Location = new System.Drawing.Point(181, 32);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(17, 12);
            this.labCity.TabIndex = 2;
            this.labCity.Text = "市";
            // 
            // cbxCity
            // 
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(214, 29);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 20);
            this.cbxCity.TabIndex = 3;
            // 
            // btnReq
            // 
            this.btnReq.Location = new System.Drawing.Point(356, 27);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(75, 23);
            this.btnReq.TabIndex = 4;
            this.btnReq.Text = "查询";
            this.btnReq.UseVisualStyleBackColor = true;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.pic2);
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Controls.Add(this.labInfo);
            this.groupBox1.Location = new System.Drawing.Point(4, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "天气信息";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInfo.Location = new System.Drawing.Point(20, 21);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(96, 28);
            this.labInfo.TabIndex = 0;
            this.labInfo.Text = "详细信息";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(430, 36);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(128, 110);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(430, 165);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(128, 110);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.labPro);
            this.Controls.Add(this.cbxPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "天气预报";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPro;
        private System.Windows.Forms.Label labPro;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
    }
}

