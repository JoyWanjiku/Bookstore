
namespace DatabasteknikBookStore
{
    partial class Createaccount
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
            this.RepeatLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn2 = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RepeatLbl
            // 
            this.RepeatLbl.AutoSize = true;
            this.RepeatLbl.Location = new System.Drawing.Point(8, 209);
            this.RepeatLbl.Name = "RepeatLbl";
            this.RepeatLbl.Size = new System.Drawing.Size(123, 17);
            this.RepeatLbl.TabIndex = 24;
            this.RepeatLbl.Text = "Repeat Password:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 1;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(8, 150);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 17);
            this.PasswordLbl.TabIndex = 19;
            this.PasswordLbl.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Already have an existing account?";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(12, 90);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(83, 17);
            this.UserNameLbl.TabIndex = 16;
            this.UserNameLbl.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create an account down below";
            // 
            // LoginBtn2
            // 
            this.LoginBtn2.Location = new System.Drawing.Point(251, 474);
            this.LoginBtn2.Name = "LoginBtn2";
            this.LoginBtn2.Size = new System.Drawing.Size(75, 32);
            this.LoginBtn2.TabIndex = 14;
            this.LoginBtn2.Text = "Log In";
            this.LoginBtn2.UseVisualStyleBackColor = true;
            this.LoginBtn2.Click += new System.EventHandler(this.LoginBtn2_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(113, 267);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(140, 32);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create Account";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Already have an account? Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Createaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RepeatLbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn2);
            this.Controls.Add(this.CreateBtn);
            this.Name = "Createaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.Createaccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RepeatLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button button1;
    }
}

