namespace CheckCodeWindowsForms
{
    partial class Form1
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
            this.CheckCodePictureBox = new System.Windows.Forms.PictureBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.CheckCodeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckCodePictureBox
            // 
            this.CheckCodePictureBox.Location = new System.Drawing.Point(58, 53);
            this.CheckCodePictureBox.Name = "CheckCodePictureBox";
            this.CheckCodePictureBox.Size = new System.Drawing.Size(113, 36);
            this.CheckCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckCodePictureBox.TabIndex = 0;
            this.CheckCodePictureBox.TabStop = false;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(251, 181);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "验证";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(58, 181);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "更换";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // CheckCodeTextBox
            // 
            this.CheckCodeTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckCodeTextBox.Location = new System.Drawing.Point(251, 53);
            this.CheckCodeTextBox.Multiline = true;
            this.CheckCodeTextBox.Name = "CheckCodeTextBox";
            this.CheckCodeTextBox.Size = new System.Drawing.Size(118, 36);
            this.CheckCodeTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 284);
            this.Controls.Add(this.CheckCodeTextBox);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CheckCodePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckCodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CheckCodePictureBox;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.TextBox CheckCodeTextBox;
    }
}

