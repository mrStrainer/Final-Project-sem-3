namespace ClientChooseEm
{
    partial class ManagePartiesForm
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
            this.FindPartiesButton = new System.Windows.Forms.Button();
            this.PartiesDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privacy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartyPlaylistButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartiesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindPartiesButton
            // 
            this.FindPartiesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FindPartiesButton.Location = new System.Drawing.Point(297, 173);
            this.FindPartiesButton.Name = "FindPartiesButton";
            this.FindPartiesButton.Size = new System.Drawing.Size(97, 44);
            this.FindPartiesButton.TabIndex = 1;
            this.FindPartiesButton.Text = "Find my parties";
            this.FindPartiesButton.UseVisualStyleBackColor = true;
            this.FindPartiesButton.Click += new System.EventHandler(this.FindPartiesButton_Click);
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
            this.PartiesDataGridView.Location = new System.Drawing.Point(6, 18);
            this.PartiesDataGridView.Name = "PartiesDataGridView";
            this.PartiesDataGridView.ReadOnly = true;
            this.PartiesDataGridView.Size = new System.Drawing.Size(1220, 150);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PartyPlaylistButton);
            this.groupBox1.Controls.Add(this.PartiesDataGridView);
            this.groupBox1.Controls.Add(this.FindPartiesButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Parties";
            // 
            // PartyPlaylistButton
            // 
            this.PartyPlaylistButton.Location = new System.Drawing.Point(414, 173);
            this.PartyPlaylistButton.Name = "PartyPlaylistButton";
            this.PartyPlaylistButton.Size = new System.Drawing.Size(105, 44);
            this.PartyPlaylistButton.TabIndex = 3;
            this.PartyPlaylistButton.Text = "Go to the party\'s playlist";
            this.PartyPlaylistButton.UseVisualStyleBackColor = true;
            this.PartyPlaylistButton.Click += new System.EventHandler(this.GoToPartyPlaylistButton_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 642);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ManagePartiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManagePartiesForm";
            this.Text = "Manage Parties";
            ((System.ComponentModel.ISupportInitialize)(this.PartiesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource partyTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button FindPartiesButton;
        private System.Windows.Forms.DataGridView PartiesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PartyPlaylistButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn privacy;
        private System.Windows.Forms.Button BackBtn;
    }
}