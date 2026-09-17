namespace 学生管理系统
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(54, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 46);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(50, 74);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 21);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "用户名：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(50, 120);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(73, 21);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 31);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 31);
            this.textBox2.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(50, 275);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(73, 21);
            this.lblRegister.TabIndex = 9;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "去注册";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblRegister;
    }
}