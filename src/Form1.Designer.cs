namespace SecureHotKey
{
    partial class frmMain
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
            this.txtF8 = new System.Windows.Forms.TextBox();
            this.txtF9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.chkVisiableF8 = new System.Windows.Forms.CheckBox();
            this.chkVisiableF9 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtF8
            // 
            this.txtF8.Location = new System.Drawing.Point(52, 12);
            this.txtF8.Name = "txtF8";
            this.txtF8.PasswordChar = '*';
            this.txtF8.Size = new System.Drawing.Size(203, 21);
            this.txtF8.TabIndex = 0;
            // 
            // txtF9
            // 
            this.txtF9.Location = new System.Drawing.Point(52, 39);
            this.txtF9.Name = "txtF9";
            this.txtF9.PasswordChar = '*';
            this.txtF9.Size = new System.Drawing.Size(203, 21);
            this.txtF9.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "F8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "F9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 71);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "按F8、F9，自动输入填写的密码。\r\n勾选自动回车，会在输入会自动按回车。";
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.Checked = true;
            this.chkReturn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReturn.Location = new System.Drawing.Point(52, 66);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(72, 16);
            this.chkReturn.TabIndex = 5;
            this.chkReturn.Text = "自动回车";
            this.chkReturn.UseVisualStyleBackColor = true;
            // 
            // chkVisiableF8
            // 
            this.chkVisiableF8.AutoSize = true;
            this.chkVisiableF8.Location = new System.Drawing.Point(261, 14);
            this.chkVisiableF8.Name = "chkVisiableF8";
            this.chkVisiableF8.Size = new System.Drawing.Size(48, 16);
            this.chkVisiableF8.TabIndex = 6;
            this.chkVisiableF8.Text = "显示";
            this.chkVisiableF8.UseVisualStyleBackColor = true;
            this.chkVisiableF8.CheckedChanged += new System.EventHandler(this.chkVisiableF8_CheckedChanged);
            // 
            // chkVisiableF9
            // 
            this.chkVisiableF9.AutoSize = true;
            this.chkVisiableF9.Location = new System.Drawing.Point(261, 44);
            this.chkVisiableF9.Name = "chkVisiableF9";
            this.chkVisiableF9.Size = new System.Drawing.Size(48, 16);
            this.chkVisiableF9.TabIndex = 7;
            this.chkVisiableF9.Text = "显示";
            this.chkVisiableF9.UseVisualStyleBackColor = true;
            this.chkVisiableF9.CheckedChanged += new System.EventHandler(this.chkVisiableF9_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 182);
            this.Controls.Add(this.chkVisiableF9);
            this.Controls.Add(this.chkVisiableF8);
            this.Controls.Add(this.chkReturn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtF9);
            this.Controls.Add(this.txtF8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "密码快捷输入器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtF8;
        private System.Windows.Forms.TextBox txtF9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkReturn;
        private System.Windows.Forms.CheckBox chkVisiableF8;
        private System.Windows.Forms.CheckBox chkVisiableF9;
    }
}

