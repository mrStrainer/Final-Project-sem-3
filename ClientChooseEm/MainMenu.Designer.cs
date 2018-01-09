namespace ClientChooseEm
{
    partial class MainMenu
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
            this.CreatePartyBtn = new System.Windows.Forms.Button();
            this.PartiesBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.FriendsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePartyBtn
            // 
            this.CreatePartyBtn.Location = new System.Drawing.Point(588, 84);
            this.CreatePartyBtn.Name = "CreatePartyBtn";
            this.CreatePartyBtn.Size = new System.Drawing.Size(89, 23);
            this.CreatePartyBtn.TabIndex = 0;
            this.CreatePartyBtn.Text = "Create Party";
            this.CreatePartyBtn.UseVisualStyleBackColor = true;
            this.CreatePartyBtn.Click += new System.EventHandler(this.CreatePartyBtn_Click);
            // 
            // PartiesBtn
            // 
            this.PartiesBtn.Location = new System.Drawing.Point(588, 55);
            this.PartiesBtn.Name = "PartiesBtn";
            this.PartiesBtn.Size = new System.Drawing.Size(89, 23);
            this.PartiesBtn.TabIndex = 1;
            this.PartiesBtn.Text = "Parties";
            this.PartiesBtn.UseVisualStyleBackColor = true;
            this.PartiesBtn.Click += new System.EventHandler(this.PartiesBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(12, 646);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(89, 23);
            this.LogOutBtn.TabIndex = 2;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // FriendsBtn
            // 
            this.FriendsBtn.Location = new System.Drawing.Point(588, 113);
            this.FriendsBtn.Name = "FriendsBtn";
            this.FriendsBtn.Size = new System.Drawing.Size(89, 23);
            this.FriendsBtn.TabIndex = 4;
            this.FriendsBtn.Text = "Friends";
            this.FriendsBtn.UseVisualStyleBackColor = true;
            this.FriendsBtn.Click += new System.EventHandler(this.FriendsBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.FriendsBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.PartiesBtn);
            this.Controls.Add(this.CreatePartyBtn);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePartyBtn;
        private System.Windows.Forms.Button PartiesBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button FriendsBtn;
    }
}