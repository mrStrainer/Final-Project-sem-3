namespace ClientChooseEm
{
    partial class InviteForm
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
            this.NotInvitedGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBtn = new System.Windows.Forms.Button();
            this.InvitedGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InviteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotInvitedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvitedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NotInvitedGridView
            // 
            this.NotInvitedGridView.AllowDrop = true;
            this.NotInvitedGridView.AllowUserToAddRows = false;
            this.NotInvitedGridView.AllowUserToDeleteRows = false;
            this.NotInvitedGridView.AllowUserToResizeColumns = false;
            this.NotInvitedGridView.AllowUserToResizeRows = false;
            this.NotInvitedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotInvitedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.NotInvitedGridView.Location = new System.Drawing.Point(12, 12);
            this.NotInvitedGridView.MultiSelect = false;
            this.NotInvitedGridView.Name = "NotInvitedGridView";
            this.NotInvitedGridView.ReadOnly = true;
            this.NotInvitedGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NotInvitedGridView.Size = new System.Drawing.Size(387, 276);
            this.NotInvitedGridView.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(406, 13);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add >>";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // InvitedGridView
            // 
            this.InvitedGridView.AllowDrop = true;
            this.InvitedGridView.AllowUserToAddRows = false;
            this.InvitedGridView.AllowUserToDeleteRows = false;
            this.InvitedGridView.AllowUserToResizeColumns = false;
            this.InvitedGridView.AllowUserToResizeRows = false;
            this.InvitedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvitedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.InvitedGridView.Location = new System.Drawing.Point(487, 13);
            this.InvitedGridView.MultiSelect = false;
            this.InvitedGridView.Name = "InvitedGridView";
            this.InvitedGridView.ReadOnly = true;
            this.InvitedGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InvitedGridView.Size = new System.Drawing.Size(387, 276);
            this.InvitedGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // InviteBtn
            // 
            this.InviteBtn.Location = new System.Drawing.Point(799, 307);
            this.InviteBtn.Name = "InviteBtn";
            this.InviteBtn.Size = new System.Drawing.Size(75, 23);
            this.InviteBtn.TabIndex = 3;
            this.InviteBtn.Text = "Invite";
            this.InviteBtn.UseVisualStyleBackColor = true;
            this.InviteBtn.Click += new System.EventHandler(this.InviteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 646);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(406, 265);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // InviteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.InviteBtn);
            this.Controls.Add(this.InvitedGridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NotInvitedGridView);
            this.Name = "InviteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InviteForm";
            ((System.ComponentModel.ISupportInitialize)(this.NotInvitedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvitedGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NotInvitedGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView InvitedGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button InviteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RemoveBtn;
    }
}