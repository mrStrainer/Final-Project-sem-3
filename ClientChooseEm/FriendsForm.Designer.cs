namespace ClientChooseEm
{
    partial class FriendsForm
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
            this.FriendsGridView = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeeFriends = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendsGridView
            // 
            this.FriendsGridView.AllowUserToAddRows = false;
            this.FriendsGridView.AllowUserToDeleteRows = false;
            this.FriendsGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FriendsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.ID,
            this.isFriend});
            this.FriendsGridView.Location = new System.Drawing.Point(235, 40);
            this.FriendsGridView.Name = "FriendsGridView";
            this.FriendsGridView.Size = new System.Drawing.Size(345, 195);
            this.FriendsGridView.TabIndex = 0;
            this.FriendsGridView.SelectionChanged += new System.EventHandler(this.FriendsGridView_SelectionChanged);
            this.FriendsGridView.TabIndexChanged += new System.EventHandler(this.FriendsGridView_TabIndexChanged);
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // isFriend
            // 
            this.isFriend.HeaderText = "Friend?";
            this.isFriend.Name = "isFriend";
            // 
            // btnSeeFriends
            // 
            this.btnSeeFriends.Location = new System.Drawing.Point(235, 257);
            this.btnSeeFriends.Name = "btnSeeFriends";
            this.btnSeeFriends.Size = new System.Drawing.Size(75, 23);
            this.btnSeeFriends.TabIndex = 1;
            this.btnSeeFriends.Text = "See friends";
            this.btnSeeFriends.UseVisualStyleBackColor = true;
            this.btnSeeFriends.Click += new System.EventHandler(this.btnSeeFriends_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 646);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(339, 257);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(75, 23);
            this.btnAddFriend.TabIndex = 3;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(440, 257);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(101, 23);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove Friend";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSeeFriends);
            this.Controls.Add(this.FriendsGridView);
            this.Name = "FriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friends Form";
            ((System.ComponentModel.ISupportInitialize)(this.FriendsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FriendsGridView;
        private System.Windows.Forms.Button btnSeeFriends;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFriend;
        private System.Windows.Forms.Button RemoveBtn;
    }
}