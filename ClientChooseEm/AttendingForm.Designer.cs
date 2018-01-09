namespace ClientChooseEm
{
    partial class AttendingForm
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
            this.DataGridGroupBox = new System.Windows.Forms.GroupBox();
            this.GetGuestsBtn = new System.Windows.Forms.Button();
            this.AttendingGridView = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsFriend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridGroupBox
            // 
            this.DataGridGroupBox.Controls.Add(this.GetGuestsBtn);
            this.DataGridGroupBox.Controls.Add(this.AttendingGridView);
            this.DataGridGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DataGridGroupBox.Name = "DataGridGroupBox";
            this.DataGridGroupBox.Size = new System.Drawing.Size(675, 385);
            this.DataGridGroupBox.TabIndex = 0;
            this.DataGridGroupBox.TabStop = false;
            // 
            // GetGuestsBtn
            // 
            this.GetGuestsBtn.Location = new System.Drawing.Point(7, 356);
            this.GetGuestsBtn.Name = "GetGuestsBtn";
            this.GetGuestsBtn.Size = new System.Drawing.Size(109, 23);
            this.GetGuestsBtn.TabIndex = 1;
            this.GetGuestsBtn.Text = "See who\'s coming";
            this.GetGuestsBtn.UseVisualStyleBackColor = true;
            this.GetGuestsBtn.Click += new System.EventHandler(this.GetGuestsBtn_Click);
            // 
            // AttendingGridView
            // 
            this.AttendingGridView.AllowUserToAddRows = false;
            this.AttendingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Status,
            this.IsAdmin,
            this.IsFriend});
            this.AttendingGridView.Location = new System.Drawing.Point(7, 20);
            this.AttendingGridView.Name = "AttendingGridView";
            this.AttendingGridView.Size = new System.Drawing.Size(662, 300);
            this.AttendingGridView.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackBtn.Location = new System.Drawing.Point(12, 646);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IsAdmin
            // 
            this.IsAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsAdmin.HeaderText = "Admin privileges";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IsFriend
            // 
            this.IsFriend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsFriend.HeaderText = "Your friend";
            this.IsFriend.Name = "IsFriend";
            this.IsFriend.ReadOnly = true;
            this.IsFriend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AttendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DataGridGroupBox);
            this.Name = "AttendingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attending At Party";
            this.DataGridGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataGridGroupBox;
        private System.Windows.Forms.DataGridView AttendingGridView;
        private System.Windows.Forms.Button GetGuestsBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFriend;
    }
}