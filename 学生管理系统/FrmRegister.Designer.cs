namespace 学生管理系统
{
    partial class FrmRegister
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
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnRegiater = new System.Windows.Forms.Button();
            this.txtIp_addr = new System.Windows.Forms.TextBox();
            this.lblIp_addr = new System.Windows.Forms.Label();
            this.txtMac_addr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(12, 482);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(73, 21);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "去注册";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 46);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(99, 69);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(210, 31);
            this.txtRegister.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 32);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 31);
            this.txtUser.TabIndex = 13;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(8, 79);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(73, 21);
            this.lblPwd.TabIndex = 12;
            this.lblPwd.Text = "密码：";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 21);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "用户名：";
            // 
            // btnRegiater
            // 
            this.btnRegiater.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegiater.Location = new System.Drawing.Point(12, 190);
            this.btnRegiater.Name = "btnRegiater";
            this.btnRegiater.Size = new System.Drawing.Size(162, 46);
            this.btnRegiater.TabIndex = 10;
            this.btnRegiater.Text = "注册";
            this.btnRegiater.UseVisualStyleBackColor = false;
            // 
            // txtIp_addr
            // 
            this.txtIp_addr.Location = new System.Drawing.Point(99, 106);
            this.txtIp_addr.Name = "txtIp_addr";
            this.txtIp_addr.Size = new System.Drawing.Size(210, 31);
            this.txtIp_addr.TabIndex = 18;
            // 
            // lblIp_addr
            // 
            this.lblIp_addr.AutoSize = true;
            this.lblIp_addr.Location = new System.Drawing.Point(8, 116);
            this.lblIp_addr.Name = "lblIp_addr";
            this.lblIp_addr.Size = new System.Drawing.Size(74, 21);
            this.lblIp_addr.TabIndex = 17;
            this.lblIp_addr.Text = "限制Ip";
            // 
            // txtMac_addr
            // 
            this.txtMac_addr.Location = new System.Drawing.Point(99, 143);
            this.txtMac_addr.Name = "txtMac_addr";
            this.txtMac_addr.Size = new System.Drawing.Size(210, 31);
            this.txtMac_addr.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "限制mac";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 706);
            this.Controls.Add(this.txtMac_addr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp_addr);
            this.Controls.Add(this.lblIp_addr);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnRegiater);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRegister;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnRegiater;
        private System.Windows.Forms.TextBox txtIp_addr;
        private System.Windows.Forms.Label lblIp_addr;
        private System.Windows.Forms.TextBox txtMac_addr;
        private System.Windows.Forms.Label label2;
    }
}