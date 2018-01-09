namespace ClientChooseEm
{
    partial class CreateParty
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
            this.CreatePartyGB = new System.Windows.Forms.GroupBox();
            this.SongsForPlaylistBtn = new System.Windows.Forms.Button();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.YesCheckBox = new System.Windows.Forms.CheckBox();
            this.LocationTxt = new System.Windows.Forms.TextBox();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.PrivacyLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.LimitBox = new System.Windows.Forms.TextBox();
            this.CreatePartyGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePartyGB
            // 
            this.CreatePartyGB.Controls.Add(this.LimitLabel);
            this.CreatePartyGB.Controls.Add(this.SongsForPlaylistBtn);
            this.CreatePartyGB.Controls.Add(this.LimitBox);
            this.CreatePartyGB.Controls.Add(this.EndTimePicker);
            this.CreatePartyGB.Controls.Add(this.StartTimePicker);
            this.CreatePartyGB.Controls.Add(this.CreateBtn);
            this.CreatePartyGB.Controls.Add(this.YesCheckBox);
            this.CreatePartyGB.Controls.Add(this.LocationTxt);
            this.CreatePartyGB.Controls.Add(this.EndDateTimePicker);
            this.CreatePartyGB.Controls.Add(this.StartDateTimePicker);
            this.CreatePartyGB.Controls.Add(this.NameTxt);
            this.CreatePartyGB.Controls.Add(this.StartDateLbl);
            this.CreatePartyGB.Controls.Add(this.EndDateLbl);
            this.CreatePartyGB.Controls.Add(this.LocationLbl);
            this.CreatePartyGB.Controls.Add(this.PrivacyLbl);
            this.CreatePartyGB.Controls.Add(this.NameLbl);
            this.CreatePartyGB.Location = new System.Drawing.Point(429, 14);
            this.CreatePartyGB.Name = "CreatePartyGB";
            this.CreatePartyGB.Size = new System.Drawing.Size(406, 351);
            this.CreatePartyGB.TabIndex = 0;
            this.CreatePartyGB.TabStop = false;
            this.CreatePartyGB.Text = "Party Details";
            // 
            // SongsForPlaylistBtn
            // 
            this.SongsForPlaylistBtn.Location = new System.Drawing.Point(295, 322);
            this.SongsForPlaylistBtn.Name = "SongsForPlaylistBtn";
            this.SongsForPlaylistBtn.Size = new System.Drawing.Size(105, 23);
            this.SongsForPlaylistBtn.TabIndex = 16;
            this.SongsForPlaylistBtn.Text = "Go to the playlist";
            this.SongsForPlaylistBtn.UseVisualStyleBackColor = true;
            this.SongsForPlaylistBtn.Click += new System.EventHandler(this.SongsForPlaylistBtn_Click);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(234, 96);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(90, 20);
            this.EndTimePicker.TabIndex = 15;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(234, 58);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(90, 20);
            this.StartTimePicker.TabIndex = 14;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 646);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(10, 322);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 12;
            this.CreateBtn.Text = "Create party";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // YesCheckBox
            // 
            this.YesCheckBox.AutoSize = true;
            this.YesCheckBox.Location = new System.Drawing.Point(127, 209);
            this.YesCheckBox.Name = "YesCheckBox";
            this.YesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.YesCheckBox.TabIndex = 10;
            this.YesCheckBox.Text = "Yes";
            this.YesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LocationTxt
            // 
            this.LocationTxt.Location = new System.Drawing.Point(127, 135);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(100, 20);
            this.LocationTxt.TabIndex = 9;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(127, 96);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.EndDateTimePicker.TabIndex = 8;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker.Location = new System.Drawing.Point(127, 58);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(127, 30);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(197, 20);
            this.NameTxt.TabIndex = 6;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(27, 58);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(58, 13);
            this.StartDateLbl.TabIndex = 5;
            this.StartDateLbl.Text = "Start Date ";
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Location = new System.Drawing.Point(27, 96);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.EndDateLbl.TabIndex = 4;
            this.EndDateLbl.Text = "End Date";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(27, 135);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(48, 13);
            this.LocationLbl.TabIndex = 3;
            this.LocationLbl.Text = "Location";
            // 
            // PrivacyLbl
            // 
            this.PrivacyLbl.AutoSize = true;
            this.PrivacyLbl.Location = new System.Drawing.Point(27, 209);
            this.PrivacyLbl.Name = "PrivacyLbl";
            this.PrivacyLbl.Size = new System.Drawing.Size(42, 13);
            this.PrivacyLbl.TabIndex = 2;
            this.PrivacyLbl.Text = "Privacy";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(27, 30);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.Location = new System.Drawing.Point(27, 177);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(28, 13);
            this.LimitLabel.TabIndex = 30;
            this.LimitLabel.Text = "Limit";
            // 
            // LimitBox
            // 
            this.LimitBox.Location = new System.Drawing.Point(127, 174);
            this.LimitBox.Name = "LimitBox";
            this.LimitBox.Size = new System.Drawing.Size(100, 20);
            this.LimitBox.TabIndex = 29;
            // 
            // CreateParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CreatePartyGB);
            this.Controls.Add(this.BackBtn);
            this.Name = "CreateParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Party";
            this.CreatePartyGB.ResumeLayout(false);
            this.CreatePartyGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CreatePartyGB;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.CheckBox YesCheckBox;
        private System.Windows.Forms.TextBox LocationTxt;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label PrivacyLbl;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Button SongsForPlaylistBtn;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.TextBox LimitBox;
    }
}