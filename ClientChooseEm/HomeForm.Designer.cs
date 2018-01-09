namespace ClientChooseEm
{
    partial class HomeForm
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
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.btnMyParties = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.joinedPartiesBtn = new System.Windows.Forms.Button();
            this.notJoinedPartiesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(331, 61);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(93, 23);
            this.btnCreateParty.TabIndex = 1;
            this.btnCreateParty.Text = "Create Party";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // btnMyParties
            // 
            this.btnMyParties.Location = new System.Drawing.Point(331, 90);
            this.btnMyParties.Name = "btnMyParties";
            this.btnMyParties.Size = new System.Drawing.Size(93, 22);
            this.btnMyParties.TabIndex = 2;
            this.btnMyParties.Text = "My Parties";
            this.btnMyParties.UseVisualStyleBackColor = true;
            this.btnMyParties.Click += new System.EventHandler(this.btnMyParties_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 318);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // joinedPartiesBtn
            // 
            this.joinedPartiesBtn.Location = new System.Drawing.Point(331, 118);
            this.joinedPartiesBtn.Name = "joinedPartiesBtn";
            this.joinedPartiesBtn.Size = new System.Drawing.Size(93, 23);
            this.joinedPartiesBtn.TabIndex = 4;
            this.joinedPartiesBtn.Text = "Joined Parties";
            this.joinedPartiesBtn.UseVisualStyleBackColor = true;
            this.joinedPartiesBtn.Click += new System.EventHandler(this.joinedPartiesBtn_Click);
            // 
            // notJoinedPartiesBtn
            // 
            this.notJoinedPartiesBtn.Location = new System.Drawing.Point(331, 147);
            this.notJoinedPartiesBtn.Name = "notJoinedPartiesBtn";
            this.notJoinedPartiesBtn.Size = new System.Drawing.Size(93, 23);
            this.notJoinedPartiesBtn.TabIndex = 5;
            this.notJoinedPartiesBtn.Text = "Not Joined";
            this.notJoinedPartiesBtn.UseVisualStyleBackColor = true;
            this.notJoinedPartiesBtn.Click += new System.EventHandler(this.notJoinedPartiesBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 353);
            this.Controls.Add(this.notJoinedPartiesBtn);
            this.Controls.Add(this.joinedPartiesBtn);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMyParties);
            this.Controls.Add(this.btnCreateParty);
            this.Name = "HomeForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button btnMyParties;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button joinedPartiesBtn;
        private System.Windows.Forms.Button notJoinedPartiesBtn;
    }
}

