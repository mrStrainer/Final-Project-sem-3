namespace ClientChooseEm
{
    partial class ManageSongsForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchResultLB = new System.Windows.Forms.ListBox();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.playSelectedBtn = new System.Windows.Forms.Button();
            this.trackInfoBox = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.advertLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.artistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.titleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.smallAlbumPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.getSongsBtn = new System.Windows.Forms.Button();
            this.getSongsResultLB = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.VoteGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckSongLbl = new System.Windows.Forms.Label();
            this.OverallRatingLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DownvoteBtn = new System.Windows.Forms.Button();
            this.UpvoteBtn = new System.Windows.Forms.Button();
            this.VoteSongNameLbl = new System.Windows.Forms.Label();
            this.trackInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallAlbumPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.VoteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.Location = new System.Drawing.Point(235, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.Location = new System.Drawing.Point(11, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(218, 23);
            this.searchBox.TabIndex = 7;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_Keypress);
            // 
            // searchResultLB
            // 
            this.searchResultLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchResultLB.FormattingEnabled = true;
            this.searchResultLB.ItemHeight = 16;
            this.searchResultLB.Location = new System.Drawing.Point(11, 109);
            this.searchResultLB.Name = "searchResultLB";
            this.searchResultLB.Size = new System.Drawing.Size(424, 500);
            this.searchResultLB.TabIndex = 8;
            this.searchResultLB.SelectedIndexChanged += new System.EventHandler(this.searchResultLB_SelectedIndexChanged);
            this.searchResultLB.DoubleClick += new System.EventHandler(this.searchResultLB_DoubleClick);
            this.searchResultLB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchResultLB_Keypress);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resumeBtn.Location = new System.Drawing.Point(207, 300);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(75, 32);
            this.resumeBtn.TabIndex = 11;
            this.resumeBtn.Text = "Resume";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // playSelectedBtn
            // 
            this.playSelectedBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playSelectedBtn.Location = new System.Drawing.Point(6, 299);
            this.playSelectedBtn.Name = "playSelectedBtn";
            this.playSelectedBtn.Size = new System.Drawing.Size(180, 35);
            this.playSelectedBtn.TabIndex = 13;
            this.playSelectedBtn.Text = "Play the selected song";
            this.playSelectedBtn.UseVisualStyleBackColor = true;
            this.playSelectedBtn.Click += new System.EventHandler(this.playSelectedBtn_Click);
            // 
            // trackInfoBox
            // 
            this.trackInfoBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackInfoBox.Controls.Add(this.addBtn);
            this.trackInfoBox.Controls.Add(this.advertLabel);
            this.trackInfoBox.Controls.Add(this.timeLabel);
            this.trackInfoBox.Controls.Add(this.resumeBtn);
            this.trackInfoBox.Controls.Add(this.timeProgressBar);
            this.trackInfoBox.Controls.Add(this.playSelectedBtn);
            this.trackInfoBox.Controls.Add(this.label5);
            this.trackInfoBox.Controls.Add(this.label4);
            this.trackInfoBox.Controls.Add(this.label3);
            this.trackInfoBox.Controls.Add(this.albumLinkLabel);
            this.trackInfoBox.Controls.Add(this.artistLinkLabel);
            this.trackInfoBox.Controls.Add(this.titleLinkLabel);
            this.trackInfoBox.Controls.Add(this.smallAlbumPicture);
            this.trackInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackInfoBox.Location = new System.Drawing.Point(479, 27);
            this.trackInfoBox.Name = "trackInfoBox";
            this.trackInfoBox.Size = new System.Drawing.Size(318, 423);
            this.trackInfoBox.TabIndex = 14;
            this.trackInfoBox.TabStop = false;
            this.trackInfoBox.Text = "Player";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(77, 356);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(164, 34);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add it!";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // advertLabel
            // 
            this.advertLabel.AutoSize = true;
            this.advertLabel.Location = new System.Drawing.Point(6, 67);
            this.advertLabel.Name = "advertLabel";
            this.advertLabel.Size = new System.Drawing.Size(0, 17);
            this.advertLabel.TabIndex = 31;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(6, 279);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 17);
            this.timeLabel.TabIndex = 29;
            this.timeLabel.Text = "-";
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Location = new System.Drawing.Point(6, 253);
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(306, 23);
            this.timeProgressBar.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Album:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Title:";
            // 
            // albumLinkLabel
            // 
            this.albumLinkLabel.AutoSize = true;
            this.albumLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLinkLabel.Location = new System.Drawing.Point(63, 227);
            this.albumLinkLabel.Name = "albumLinkLabel";
            this.albumLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.albumLinkLabel.TabIndex = 7;
            this.albumLinkLabel.TabStop = true;
            this.albumLinkLabel.Text = "-";
            this.albumLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistLinkLabel
            // 
            this.artistLinkLabel.AutoSize = true;
            this.artistLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLinkLabel.Location = new System.Drawing.Point(63, 204);
            this.artistLinkLabel.Name = "artistLinkLabel";
            this.artistLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.artistLinkLabel.TabIndex = 6;
            this.artistLinkLabel.TabStop = true;
            this.artistLinkLabel.Text = "-";
            this.artistLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLinkLabel
            // 
            this.titleLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLinkLabel.AutoSize = true;
            this.titleLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLinkLabel.Location = new System.Drawing.Point(63, 182);
            this.titleLinkLabel.Name = "titleLinkLabel";
            this.titleLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.titleLinkLabel.TabIndex = 5;
            this.titleLinkLabel.TabStop = true;
            this.titleLinkLabel.Text = "-";
            this.titleLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallAlbumPicture
            // 
            this.smallAlbumPicture.Location = new System.Drawing.Point(81, 19);
            this.smallAlbumPicture.Name = "smallAlbumPicture";
            this.smallAlbumPicture.Size = new System.Drawing.Size(160, 160);
            this.smallAlbumPicture.TabIndex = 5;
            this.smallAlbumPicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchResultLB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 617);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.getSongsBtn);
            this.groupBox2.Controls.Add(this.getSongsResultLB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(854, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 650);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Already added songs";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(34, 602);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(339, 37);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete the song";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // getSongsBtn
            // 
            this.getSongsBtn.Location = new System.Drawing.Point(6, 43);
            this.getSongsBtn.Name = "getSongsBtn";
            this.getSongsBtn.Size = new System.Drawing.Size(97, 28);
            this.getSongsBtn.TabIndex = 10;
            this.getSongsBtn.Text = "Get songs";
            this.getSongsBtn.UseVisualStyleBackColor = true;
            this.getSongsBtn.Click += new System.EventHandler(this.getSongsBtn_Click);
            // 
            // getSongsResultLB
            // 
            this.getSongsResultLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.getSongsResultLB.FormattingEnabled = true;
            this.getSongsResultLB.ItemHeight = 16;
            this.getSongsResultLB.Location = new System.Drawing.Point(6, 83);
            this.getSongsResultLB.Name = "getSongsResultLB";
            this.getSongsResultLB.Size = new System.Drawing.Size(382, 500);
            this.getSongsResultLB.TabIndex = 9;
            this.getSongsResultLB.SelectedIndexChanged += new System.EventHandler(this.getSongsResultLB_SelectedIndexChanged);
            this.getSongsResultLB.DoubleClick += new System.EventHandler(this.getSongsResultLB_DoubleClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(23, 642);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // VoteGroupBox
            // 
            this.VoteGroupBox.Controls.Add(this.CheckSongLbl);
            this.VoteGroupBox.Controls.Add(this.OverallRatingLbl);
            this.VoteGroupBox.Controls.Add(this.ResetBtn);
            this.VoteGroupBox.Controls.Add(this.DownvoteBtn);
            this.VoteGroupBox.Controls.Add(this.UpvoteBtn);
            this.VoteGroupBox.Controls.Add(this.VoteSongNameLbl);
            this.VoteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VoteGroupBox.Location = new System.Drawing.Point(479, 467);
            this.VoteGroupBox.Name = "VoteGroupBox";
            this.VoteGroupBox.Size = new System.Drawing.Size(318, 210);
            this.VoteGroupBox.TabIndex = 18;
            this.VoteGroupBox.TabStop = false;
            this.VoteGroupBox.Text = "Vote the song";
            // 
            // CheckSongLbl
            // 
            this.CheckSongLbl.AutoSize = true;
            this.CheckSongLbl.Location = new System.Drawing.Point(9, 60);
            this.CheckSongLbl.Name = "CheckSongLbl";
            this.CheckSongLbl.Size = new System.Drawing.Size(0, 17);
            this.CheckSongLbl.TabIndex = 5;
            // 
            // OverallRatingLbl
            // 
            this.OverallRatingLbl.AutoSize = true;
            this.OverallRatingLbl.Location = new System.Drawing.Point(18, 172);
            this.OverallRatingLbl.Name = "OverallRatingLbl";
            this.OverallRatingLbl.Size = new System.Drawing.Size(197, 17);
            this.OverallRatingLbl.TabIndex = 4;
            this.OverallRatingLbl.Text = "Overall Rating of this song is: ";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(114, 97);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(89, 34);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DownvoteBtn
            // 
            this.DownvoteBtn.Location = new System.Drawing.Point(223, 97);
            this.DownvoteBtn.Name = "DownvoteBtn";
            this.DownvoteBtn.Size = new System.Drawing.Size(89, 34);
            this.DownvoteBtn.TabIndex = 2;
            this.DownvoteBtn.Text = "Downvote";
            this.DownvoteBtn.UseVisualStyleBackColor = true;
            this.DownvoteBtn.Click += new System.EventHandler(this.DownvoteBtn_Click);
            // 
            // UpvoteBtn
            // 
            this.UpvoteBtn.Location = new System.Drawing.Point(6, 97);
            this.UpvoteBtn.Name = "UpvoteBtn";
            this.UpvoteBtn.Size = new System.Drawing.Size(84, 34);
            this.UpvoteBtn.TabIndex = 1;
            this.UpvoteBtn.Text = "Upvote";
            this.UpvoteBtn.UseVisualStyleBackColor = true;
            this.UpvoteBtn.Click += new System.EventHandler(this.UpvoteBtn_Click);
            // 
            // VoteSongNameLbl
            // 
            this.VoteSongNameLbl.AutoSize = true;
            this.VoteSongNameLbl.Location = new System.Drawing.Point(13, 26);
            this.VoteSongNameLbl.Name = "VoteSongNameLbl";
            this.VoteSongNameLbl.Size = new System.Drawing.Size(0, 17);
            this.VoteSongNameLbl.TabIndex = 0;
            // 
            // ManageSongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 678);
            this.Controls.Add(this.VoteGroupBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManageSongsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party\'s Playlist Menu";
            this.trackInfoBox.ResumeLayout(false);
            this.trackInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallAlbumPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.VoteGroupBox.ResumeLayout(false);
            this.VoteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox searchResultLB;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Button playSelectedBtn;
        private System.Windows.Forms.GroupBox trackInfoBox;
        private System.Windows.Forms.Label advertLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel albumLinkLabel;
        private System.Windows.Forms.LinkLabel artistLinkLabel;
        private System.Windows.Forms.LinkLabel titleLinkLabel;
        private System.Windows.Forms.PictureBox smallAlbumPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox getSongsResultLB;
        private System.Windows.Forms.Button getSongsBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.GroupBox VoteGroupBox;
        private System.Windows.Forms.Label VoteSongNameLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DownvoteBtn;
        private System.Windows.Forms.Button UpvoteBtn;
        private System.Windows.Forms.Label OverallRatingLbl;
        private System.Windows.Forms.Label CheckSongLbl;
    }
}
