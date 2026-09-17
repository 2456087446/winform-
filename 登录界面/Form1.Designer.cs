namespace 登录界面
{
    partial class FrmLogin
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(143, 132);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(273, 31);
            this.txtuser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "账户：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(123, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "登录界面";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(41, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(143, 194);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(273, 31);
            this.txtpwd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Name = "FrmLogin";
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button button1;
    }
}

