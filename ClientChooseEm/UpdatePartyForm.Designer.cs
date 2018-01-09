namespace ClientChooseEm
{
    partial class UpdatePartyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SongsForPlaylistBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.YesCheckBox = new System.Windows.Forms.CheckBox();
            this.PrivacyLbl = new System.Windows.Forms.Label();
            this.LocationTxt = new System.Windows.Forms.TextBox();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LimitBox = new System.Windows.Forms.TextBox();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.LimitLabel);
            this.groupBox1.Controls.Add(this.LimitBox);
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Controls.Add(this.SongsForPlaylistBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.YesCheckBox);
            this.groupBox1.Controls.Add(this.PrivacyLbl);
            this.groupBox1.Controls.Add(this.LocationTxt);
            this.groupBox1.Controls.Add(this.LocationLbl);
            this.groupBox1.Controls.Add(this.EndDateTimePicker);
            this.groupBox1.Controls.Add(this.EndDateLbl);
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.StartDateTimePicker);
            this.groupBox1.Controls.Add(this.StartDateLbl);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Location = new System.Drawing.Point(399, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Details";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(257, 124);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(90, 20);
            this.EndTimePicker.TabIndex = 26;
            // 
            // SongsForPlaylistBtn
            // 
            this.SongsForPlaylistBtn.Location = new System.Drawing.Point(325, 425);
            this.SongsForPlaylistBtn.Name = "SongsForPlaylistBtn";
            this.SongsForPlaylistBtn.Size = new System.Drawing.Size(105, 23);
            this.SongsForPlaylistBtn.TabIndex = 25;
            this.SongsForPlaylistBtn.Text = "Go to the playlist";
            this.SongsForPlaylistBtn.UseVisualStyleBackColor = true;
            this.SongsForPlaylistBtn.Click += new System.EventHandler(this.SongsForPlaylistBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(6, 425);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(122, 23);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update party";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // YesCheckBox
            // 
            this.YesCheckBox.AutoSize = true;
            this.YesCheckBox.Location = new System.Drawing.Point(151, 251);
            this.YesCheckBox.Name = "YesCheckBox";
            this.YesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.YesCheckBox.TabIndex = 22;
            this.YesCheckBox.Text = "Yes";
            this.YesCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrivacyLbl
            // 
            this.PrivacyLbl.AutoSize = true;
            this.PrivacyLbl.Location = new System.Drawing.Point(70, 251);
            this.PrivacyLbl.Name = "PrivacyLbl";
            this.PrivacyLbl.Size = new System.Drawing.Size(42, 13);
            this.PrivacyLbl.TabIndex = 21;
            this.PrivacyLbl.Text = "Privacy";
            // 
            // LocationTxt
            // 
            this.LocationTxt.Location = new System.Drawing.Point(151, 169);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(100, 20);
            this.LocationTxt.TabIndex = 20;
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(70, 172);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(48, 13);
            this.LocationLbl.TabIndex = 19;
            this.LocationLbl.Text = "Location";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(151, 124);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.EndDateTimePicker.TabIndex = 17;
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Location = new System.Drawing.Point(70, 131);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.EndDateLbl.TabIndex = 16;
            this.EndDateLbl.Text = "End Date";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(257, 82);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(90, 20);
            this.StartTimePicker.TabIndex = 15;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker.Location = new System.Drawing.Point(151, 82);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.StartDateTimePicker.TabIndex = 9;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(70, 88);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(58, 13);
            this.StartDateLbl.TabIndex = 8;
            this.StartDateLbl.Text = "Start Date ";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(151, 48);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(196, 20);
            this.NameTxt.TabIndex = 7;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(70, 51);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 489);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(73, 23);
            this.BackBtn.TabIndex = 24;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LimitBox
            // 
            this.LimitBox.Location = new System.Drawing.Point(151, 211);
            this.LimitBox.Name = "LimitBox";
            this.LimitBox.Size = new System.Drawing.Size(100, 20);
            this.LimitBox.TabIndex = 27;
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.Location = new System.Drawing.Point(70, 214);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(28, 13);
            this.LimitLabel.TabIndex = 28;
            this.LimitLabel.Text = "Limit";
            // 
            // UpdatePartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackBtn);
            this.Name = "UpdatePartyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePartyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.TextBox LocationTxt;
        private System.Windows.Forms.Label PrivacyLbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.CheckBox YesCheckBox;
        private System.Windows.Forms.Button SongsForPlaylistBtn;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.TextBox LimitBox;
    }
}