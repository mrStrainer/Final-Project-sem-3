namespace ClientChooseEm
{
    partial class Parties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvailablePartiesBtn = new System.Windows.Forms.Button();
            this.MyPartiesBtn = new System.Windows.Forms.Button();
            this.PartiesGridView = new System.Windows.Forms.DataGridView();
            this.Party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToPartyBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SeePartyBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ZipLbl = new System.Windows.Forms.Label();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartiesGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailablePartiesBtn);
            this.groupBox1.Controls.Add(this.MyPartiesBtn);
            this.groupBox1.Controls.Add(this.PartiesGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parties";
            // 
            // AvailablePartiesBtn
            // 
            this.AvailablePartiesBtn.Location = new System.Drawing.Point(929, 48);
            this.AvailablePartiesBtn.Name = "AvailablePartiesBtn";
            this.AvailablePartiesBtn.Size = new System.Drawing.Size(98, 23);
            this.AvailablePartiesBtn.TabIndex = 2;
            this.AvailablePartiesBtn.Text = "Available Parties";
            this.AvailablePartiesBtn.UseVisualStyleBackColor = true;
            this.AvailablePartiesBtn.Click += new System.EventHandler(this.AvailablePartiesBtn_Click);
            // 
            // MyPartiesBtn
            // 
            this.MyPartiesBtn.Location = new System.Drawing.Point(929, 19);
            this.MyPartiesBtn.Name = "MyPartiesBtn";
            this.MyPartiesBtn.Size = new System.Drawing.Size(98, 23);
            this.MyPartiesBtn.TabIndex = 1;
            this.MyPartiesBtn.Text = "My Parties";
            this.MyPartiesBtn.UseVisualStyleBackColor = true;
            this.MyPartiesBtn.Click += new System.EventHandler(this.MyPartiesBtn_Click);
            // 
            // PartiesGridView
            // 
            this.PartiesGridView.AllowUserToAddRows = false;
            this.PartiesGridView.AllowUserToDeleteRows = false;
            this.PartiesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PartiesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PartiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Party,
            this.Places,
            this.HostName,
            this.StartDate,
            this.EndDate,
            this.PartyId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PartiesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PartiesGridView.Location = new System.Drawing.Point(0, 19);
            this.PartiesGridView.MultiSelect = false;
            this.PartiesGridView.Name = "PartiesGridView";
            this.PartiesGridView.ReadOnly = true;
            this.PartiesGridView.Size = new System.Drawing.Size(916, 150);
            this.PartiesGridView.TabIndex = 0;
            // 
            // Party
            // 
            this.Party.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Party.HeaderText = "Party";
            this.Party.Name = "Party";
            this.Party.ReadOnly = true;
            // 
            // Places
            // 
            this.Places.HeaderText = "Places";
            this.Places.Name = "Places";
            this.Places.ReadOnly = true;
            // 
            // HostName
            // 
            this.HostName.HeaderText = "Hosted by";
            this.HostName.Name = "HostName";
            this.HostName.ReadOnly = true;
            this.HostName.Width = 150;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 140;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 140;
            // 
            // PartyId
            // 
            this.PartyId.HeaderText = "Id";
            this.PartyId.Name = "PartyId";
            this.PartyId.ReadOnly = true;
            // 
            // ToPartyBtn
            // 
            this.ToPartyBtn.Location = new System.Drawing.Point(18, 301);
            this.ToPartyBtn.Name = "ToPartyBtn";
            this.ToPartyBtn.Size = new System.Drawing.Size(75, 23);
            this.ToPartyBtn.TabIndex = 1;
            this.ToPartyBtn.Text = "Join";
            this.ToPartyBtn.UseVisualStyleBackColor = true;
            this.ToPartyBtn.Click += new System.EventHandler(this.ToPartyBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 646);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SeePartyBtn
            // 
            this.SeePartyBtn.Location = new System.Drawing.Point(109, 301);
            this.SeePartyBtn.Name = "SeePartyBtn";
            this.SeePartyBtn.Size = new System.Drawing.Size(75, 23);
            this.SeePartyBtn.TabIndex = 3;
            this.SeePartyBtn.Text = "See";
            this.SeePartyBtn.UseVisualStyleBackColor = true;
            this.SeePartyBtn.Click += new System.EventHandler(this.SeePartyBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(197, 300);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update ";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.IdLbl);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.FirstNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.LastNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.ZipLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1240, 40);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(30, 0);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(0, 13);
            this.IdLbl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(102, 0);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(0, 13);
            this.FirstNameLbl.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(175, 0);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(0, 13);
            this.LastNameLbl.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip:";
            // 
            // ZipLbl
            // 
            this.ZipLbl.AutoSize = true;
            this.ZipLbl.Location = new System.Drawing.Point(212, 0);
            this.ZipLbl.Name = "ZipLbl";
            this.ZipLbl.Size = new System.Drawing.Size(0, 13);
            this.ZipLbl.TabIndex = 7;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(290, 300);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(75, 23);
            this.LeaveBtn.TabIndex = 6;
            this.LeaveBtn.Text = "Leave";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // Parties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SeePartyBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ToPartyBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Parties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parties";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartiesGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PartiesGridView;
        private System.Windows.Forms.Button AvailablePartiesBtn;
        private System.Windows.Forms.Button MyPartiesBtn;
        private System.Windows.Forms.Button ToPartyBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SeePartyBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Party;
        private System.Windows.Forms.DataGridViewTextBoxColumn Places;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ZipLbl;
        private System.Windows.Forms.Button LeaveBtn;
    }
}