namespace ClientChooseEm
{
    partial class RegisterForm
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
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.SecondNameLbl = new System.Windows.Forms.Label();
            this.ZipLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.ZipTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(522, 47);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name";
            // 
            // SecondNameLbl
            // 
            this.SecondNameLbl.AutoSize = true;
            this.SecondNameLbl.Location = new System.Drawing.Point(519, 95);
            this.SecondNameLbl.Name = "SecondNameLbl";
            this.SecondNameLbl.Size = new System.Drawing.Size(75, 13);
            this.SecondNameLbl.TabIndex = 1;
            this.SecondNameLbl.Text = "Second Name";
            // 
            // ZipLbl
            // 
            this.ZipLbl.AutoSize = true;
            this.ZipLbl.Location = new System.Drawing.Point(522, 134);
            this.ZipLbl.Name = "ZipLbl";
            this.ZipLbl.Size = new System.Drawing.Size(22, 13);
            this.ZipLbl.TabIndex = 2;
            this.ZipLbl.Text = "Zip";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(522, 176);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 3;
            this.EmailLbl.Text = "Email";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(522, 218);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password";
            // 
            // FnameTxt
            // 
            this.FnameTxt.Location = new System.Drawing.Point(642, 44);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(100, 20);
            this.FnameTxt.TabIndex = 5;
            // 
            // LnameTxt
            // 
            this.LnameTxt.Location = new System.Drawing.Point(642, 92);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(100, 20);
            this.LnameTxt.TabIndex = 6;
            // 
            // ZipTxt
            // 
            this.ZipTxt.Location = new System.Drawing.Point(642, 131);
            this.ZipTxt.Name = "ZipTxt";
            this.ZipTxt.Size = new System.Drawing.Size(100, 20);
            this.ZipTxt.TabIndex = 7;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(642, 173);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(100, 20);
            this.EmailTxt.TabIndex = 8;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(642, 211);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxt.TabIndex = 9;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(667, 260);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 10;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(522, 260);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.ZipTxt);
            this.Controls.Add(this.LnameTxt);
            this.Controls.Add(this.FnameTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.ZipLbl);
            this.Controls.Add(this.SecondNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label SecondNameLbl;
        private System.Windows.Forms.Label ZipLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.TextBox LnameTxt;
        private System.Windows.Forms.TextBox ZipTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}