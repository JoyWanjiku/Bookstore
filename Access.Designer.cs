
namespace DatabasteknikBookStore
{
    partial class Access
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn2 = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BtnGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(133, 136);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(245, 22);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(133, 84);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(245, 22);
            this.usernameTxt.TabIndex = 1;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(16, 136);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.PasswordLbl.TabIndex = 31;
            this.PasswordLbl.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Don\'t have an existing account?";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(16, 89);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(83, 17);
            this.UserNameLbl.TabIndex = 28;
            this.UserNameLbl.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login to account down below";
            // 
            // LoginBtn2
            // 
            this.LoginBtn2.Location = new System.Drawing.Point(291, 185);
            this.LoginBtn2.Name = "LoginBtn2";
            this.LoginBtn2.Size = new System.Drawing.Size(75, 32);
            this.LoginBtn2.TabIndex = 4;
            this.LoginBtn2.Text = "Log In";
            this.LoginBtn2.UseVisualStyleBackColor = true;
            this.LoginBtn2.Click += new System.EventHandler(this.LoginBtn2_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(244, 245);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(140, 32);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create Account";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BtnGuest
            // 
            this.BtnGuest.Location = new System.Drawing.Point(15, 185);
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Size = new System.Drawing.Size(140, 32);
            this.BtnGuest.TabIndex = 3;
            this.BtnGuest.Text = "Continue As Guest";
            this.BtnGuest.UseVisualStyleBackColor = true;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 286);
            this.Controls.Add(this.BtnGuest);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn2);
            this.Controls.Add(this.CreateBtn);
            this.Name = "Access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access";
            this.Load += new System.EventHandler(this.Access_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BtnGuest;
    }
}