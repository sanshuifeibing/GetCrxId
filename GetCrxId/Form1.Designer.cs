namespace GetCrxId
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_privateKey = new System.Windows.Forms.TextBox();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.button_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "私钥:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "结果:";
            // 
            // textBox_privateKey
            // 
            this.textBox_privateKey.AllowDrop = true;
            this.textBox_privateKey.Location = new System.Drawing.Point(62, 23);
            this.textBox_privateKey.Multiline = true;
            this.textBox_privateKey.Name = "textBox_privateKey";
            this.textBox_privateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_privateKey.Size = new System.Drawing.Size(329, 218);
            this.textBox_privateKey.TabIndex = 4;
            this.textBox_privateKey.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_privateKey_DragDrop);
            this.textBox_privateKey.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_privateKey_DragEnter);
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(62, 259);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(329, 21);
            this.textBox_D.TabIndex = 8;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(165, 300);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(101, 44);
            this.button_get.TabIndex = 13;
            this.button_get.Text = "获取";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 356);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.textBox_privateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_privateKey;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Button button_get;
    }
}

