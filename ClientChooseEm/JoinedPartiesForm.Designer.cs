namespace ClientChooseEm
{
    partial class JoinedPartiesForm
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
            this.FindPartiesBtn = new System.Windows.Forms.Button();
            this.PartyPlaylistButton = new System.Windows.Forms.Button();
            this.PartiesDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privacy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindPartiesBtn);
            this.groupBox1.Controls.Add(this.PartyPlaylistButton);
            this.groupBox1.Controls.Add(this.PartiesDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(-142, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Parties";
            // 
            // FindPartiesBtn
            // 
            this.FindPartiesBtn.Location = new System.Drawing.Point(317, 173);
            this.FindPartiesBtn.Name = "FindPartiesBtn";
            this.FindPartiesBtn.Size = new System.Drawing.Size(91, 44);
            this.FindPartiesBtn.TabIndex = 4;
            this.FindPartiesBtn.Text = "Find Parties";
            this.FindPartiesBtn.UseVisualStyleBackColor = true;
            this.FindPartiesBtn.Click += new System.EventHandler(this.FindPartiesBtn_Click);
            // 
            // PartyPlaylistButton
            // 
            this.PartyPlaylistButton.Location = new System.Drawing.Point(414, 173);
            this.PartyPlaylistButton.Name = "PartyPlaylistButton";
            this.PartyPlaylistButton.Size = new System.Drawing.Size(105, 44);
            this.PartyPlaylistButton.TabIndex = 3;
            this.PartyPlaylistButton.Text = "Go to the party\'s playlist";
            this.PartyPlaylistButton.UseVisualStyleBackColor = true;
            this.PartyPlaylistButton.Click += new System.EventHandler(this.PartyPlaylistButton_Click);
            // 
            // PartiesDataGridView
            // 
            this.PartiesDataGridView.AllowUserToAddRows = false;
            this.PartiesDataGridView.AllowUserToDeleteRows = false;
            this.PartiesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PartiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ownerID,
            this.startDate,
            this.endDate,
            this.locationLatitude,
            this.locationLongitude,
            this.PartyName,
            this.privacy});
            this.PartiesDataGridView.Location = new System.Drawing.Point(144, 17);
            this.PartiesDataGridView.Name = "PartiesDataGridView";
            this.PartiesDataGridView.ReadOnly = true;
            this.PartiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartiesDataGridView.Size = new System.Drawing.Size(1090, 150);
            this.PartiesDataGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ownerID
            // 
            this.ownerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ownerID.HeaderText = "ownerID";
            this.ownerID.Name = "ownerID";
            this.ownerID.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDate.HeaderText = "startDate";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDate.HeaderText = "endDate";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // locationLatitude
            // 
            this.locationLatitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationLatitude.HeaderText = "locationLatitude";
            this.locationLatitude.Name = "locationLatitude";
            this.locationLatitude.ReadOnly = true;
            // 
            // locationLongitude
            // 
            this.locationLongitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationLongitude.HeaderText = "locationLongitude";
            this.locationLongitude.Name = "locationLongitude";
            this.locationLongitude.ReadOnly = true;
            // 
            // PartyName
            // 
            this.PartyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartyName.HeaderText = "Name";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            // 
            // privacy
            // 
            this.privacy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.privacy.HeaderText = "privacy";
            this.privacy.Name = "privacy";
            this.privacy.ReadOnly = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 488);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // JoinedPartiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 553);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "JoinedPartiesForm";
            this.Text = "Joined Parties list";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PartyPlaylistButton;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button FindPartiesBtn;
        private System.Windows.Forms.DataGridView PartiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn privacy;
    }
}