namespace MainFrom
{
    partial class MainFrom
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox_qrcode = new System.Windows.Forms.PictureBox();
            this.btn_verification = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.lab_code = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_qrcode
            // 
            this.picBox_qrcode.Location = new System.Drawing.Point(12, 12);
            this.picBox_qrcode.Name = "picBox_qrcode";
            this.picBox_qrcode.Size = new System.Drawing.Size(210, 202);
            this.picBox_qrcode.TabIndex = 0;
            this.picBox_qrcode.TabStop = false;
            // 
            // btn_verification
            // 
            this.btn_verification.Location = new System.Drawing.Point(11, 273);
            this.btn_verification.Name = "btn_verification";
            this.btn_verification.Size = new System.Drawing.Size(211, 24);
            this.btn_verification.TabIndex = 2;
            this.btn_verification.Text = "验证";
            this.btn_verification.UseVisualStyleBackColor = true;
            this.btn_verification.Click += new System.EventHandler(this.btn_verification_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(12, 236);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(209, 21);
            this.txtcode.TabIndex = 3;
            // 
            // lab_code
            // 
            this.lab_code.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_code.Location = new System.Drawing.Point(274, 126);
            this.lab_code.Name = "lab_code";
            this.lab_code.Size = new System.Drawing.Size(213, 40);
            this.lab_code.TabIndex = 1;
            this.lab_code.Text = "请验证动态码";
            this.lab_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_time
            // 
            this.lab_time.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_time.Location = new System.Drawing.Point(274, 71);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(213, 40);
            this.lab_time.TabIndex = 1;
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 313);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.btn_verification);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.lab_code);
            this.Controls.Add(this.picBox_qrcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "谷歌动态绑定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.Load += new System.EventHandler(this.MainFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_qrcode;
        private System.Windows.Forms.Button btn_verification;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label lab_code;
        private System.Windows.Forms.Label lab_time;
    }
}

