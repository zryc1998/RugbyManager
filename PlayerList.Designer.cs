
namespace PlayersList
{
    partial class PlayerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerList));
            this.teamPlayersSpreadsheet = new System.Windows.Forms.ListView();
            this.columnTeamPlayerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamPlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamPlayerDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamPlayerHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamPlayerWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamPlayerBirthPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playersListLogo = new System.Windows.Forms.PictureBox();
            this.playersListTeamName = new System.Windows.Forms.Label();
            this.labelEnrolledNumber = new System.Windows.Forms.Label();
            this.numberOfPlayers = new System.Windows.Forms.Label();
            this.playersListRegionTextBox = new System.Windows.Forms.TextBox();
            this.playersListYearFoundedTextBox = new System.Windows.Forms.TextBox();
            this.playersListCoachTextBox = new System.Windows.Forms.TextBox();
            this.playersListGroundTextBox = new System.Windows.Forms.TextBox();
            this.playerTeamRegionLabel = new System.Windows.Forms.Label();
            this.playerTeamYearFoundedLabel = new System.Windows.Forms.Label();
            this.playerTeamCoachLabel = new System.Windows.Forms.Label();
            this.playerTeamGroundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playersListLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // teamPlayersSpreadsheet
            // 
            this.teamPlayersSpreadsheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamPlayersSpreadsheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTeamPlayerID,
            this.columnTeamPlayerName,
            this.columnTeamPlayerDOB,
            this.columnTeamPlayerHeight,
            this.columnTeamPlayerWeight,
            this.columnTeamPlayerBirthPlace});
            this.teamPlayersSpreadsheet.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayersSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teamPlayersSpreadsheet.FullRowSelect = true;
            this.teamPlayersSpreadsheet.HideSelection = false;
            this.teamPlayersSpreadsheet.Location = new System.Drawing.Point(230, 44);
            this.teamPlayersSpreadsheet.MultiSelect = false;
            this.teamPlayersSpreadsheet.Name = "teamPlayersSpreadsheet";
            this.teamPlayersSpreadsheet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.teamPlayersSpreadsheet.Size = new System.Drawing.Size(614, 436);
            this.teamPlayersSpreadsheet.TabIndex = 3;
            this.teamPlayersSpreadsheet.UseCompatibleStateImageBehavior = false;
            this.teamPlayersSpreadsheet.View = System.Windows.Forms.View.Details;
            // 
            // columnTeamPlayerID
            // 
            this.columnTeamPlayerID.Text = "ID";
            this.columnTeamPlayerID.Width = 40;
            // 
            // columnTeamPlayerName
            // 
            this.columnTeamPlayerName.Text = "Name";
            this.columnTeamPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamPlayerName.Width = 122;
            // 
            // columnTeamPlayerDOB
            // 
            this.columnTeamPlayerDOB.Text = "Date Of Birth";
            this.columnTeamPlayerDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamPlayerDOB.Width = 110;
            // 
            // columnTeamPlayerHeight
            // 
            this.columnTeamPlayerHeight.Text = "Height";
            this.columnTeamPlayerHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamPlayerHeight.Width = 78;
            // 
            // columnTeamPlayerWeight
            // 
            this.columnTeamPlayerWeight.Text = "Weight";
            this.columnTeamPlayerWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamPlayerWeight.Width = 67;
            // 
            // columnTeamPlayerBirthPlace
            // 
            this.columnTeamPlayerBirthPlace.Text = "Birth Place";
            this.columnTeamPlayerBirthPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamPlayerBirthPlace.Width = 196;
            // 
            // playersListLogo
            // 
            this.playersListLogo.Location = new System.Drawing.Point(25, 44);
            this.playersListLogo.Name = "playersListLogo";
            this.playersListLogo.Size = new System.Drawing.Size(149, 132);
            this.playersListLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playersListLogo.TabIndex = 4;
            this.playersListLogo.TabStop = false;
            // 
            // playersListTeamName
            // 
            this.playersListTeamName.AutoSize = true;
            this.playersListTeamName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListTeamName.ForeColor = System.Drawing.Color.DarkGreen;
            this.playersListTeamName.Location = new System.Drawing.Point(34, 194);
            this.playersListTeamName.Name = "playersListTeamName";
            this.playersListTeamName.Size = new System.Drawing.Size(0, 24);
            this.playersListTeamName.TabIndex = 5;
            // 
            // labelEnrolledNumber
            // 
            this.labelEnrolledNumber.AutoSize = true;
            this.labelEnrolledNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnrolledNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEnrolledNumber.Location = new System.Drawing.Point(38, 463);
            this.labelEnrolledNumber.Name = "labelEnrolledNumber";
            this.labelEnrolledNumber.Size = new System.Drawing.Size(122, 17);
            this.labelEnrolledNumber.TabIndex = 6;
            this.labelEnrolledNumber.Text = "Number Of Players:";
            // 
            // numberOfPlayers
            // 
            this.numberOfPlayers.AutoSize = true;
            this.numberOfPlayers.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPlayers.Location = new System.Drawing.Point(165, 461);
            this.numberOfPlayers.Name = "numberOfPlayers";
            this.numberOfPlayers.Size = new System.Drawing.Size(0, 19);
            this.numberOfPlayers.TabIndex = 7;
            // 
            // playersListRegionTextBox
            // 
            this.playersListRegionTextBox.BackColor = System.Drawing.Color.White;
            this.playersListRegionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListRegionTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListRegionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.playersListRegionTextBox.Location = new System.Drawing.Point(38, 424);
            this.playersListRegionTextBox.Name = "playersListRegionTextBox";
            this.playersListRegionTextBox.ReadOnly = true;
            this.playersListRegionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playersListRegionTextBox.Size = new System.Drawing.Size(162, 17);
            this.playersListRegionTextBox.TabIndex = 20;
            // 
            // playersListYearFoundedTextBox
            // 
            this.playersListYearFoundedTextBox.BackColor = System.Drawing.Color.White;
            this.playersListYearFoundedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListYearFoundedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListYearFoundedTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.playersListYearFoundedTextBox.Location = new System.Drawing.Point(38, 370);
            this.playersListYearFoundedTextBox.Name = "playersListYearFoundedTextBox";
            this.playersListYearFoundedTextBox.ReadOnly = true;
            this.playersListYearFoundedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playersListYearFoundedTextBox.Size = new System.Drawing.Size(162, 17);
            this.playersListYearFoundedTextBox.TabIndex = 19;
            // 
            // playersListCoachTextBox
            // 
            this.playersListCoachTextBox.BackColor = System.Drawing.Color.White;
            this.playersListCoachTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListCoachTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListCoachTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.playersListCoachTextBox.Location = new System.Drawing.Point(38, 316);
            this.playersListCoachTextBox.Name = "playersListCoachTextBox";
            this.playersListCoachTextBox.ReadOnly = true;
            this.playersListCoachTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playersListCoachTextBox.Size = new System.Drawing.Size(162, 17);
            this.playersListCoachTextBox.TabIndex = 18;
            // 
            // playersListGroundTextBox
            // 
            this.playersListGroundTextBox.BackColor = System.Drawing.Color.White;
            this.playersListGroundTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListGroundTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListGroundTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.playersListGroundTextBox.Location = new System.Drawing.Point(38, 260);
            this.playersListGroundTextBox.Name = "playersListGroundTextBox";
            this.playersListGroundTextBox.ReadOnly = true;
            this.playersListGroundTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playersListGroundTextBox.Size = new System.Drawing.Size(162, 17);
            this.playersListGroundTextBox.TabIndex = 17;
            // 
            // playerTeamRegionLabel
            // 
            this.playerTeamRegionLabel.AutoSize = true;
            this.playerTeamRegionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamRegionLabel.Location = new System.Drawing.Point(38, 404);
            this.playerTeamRegionLabel.Name = "playerTeamRegionLabel";
            this.playerTeamRegionLabel.Size = new System.Drawing.Size(53, 17);
            this.playerTeamRegionLabel.TabIndex = 16;
            this.playerTeamRegionLabel.Text = "Region";
            // 
            // playerTeamYearFoundedLabel
            // 
            this.playerTeamYearFoundedLabel.AutoSize = true;
            this.playerTeamYearFoundedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamYearFoundedLabel.Location = new System.Drawing.Point(38, 350);
            this.playerTeamYearFoundedLabel.Name = "playerTeamYearFoundedLabel";
            this.playerTeamYearFoundedLabel.Size = new System.Drawing.Size(98, 17);
            this.playerTeamYearFoundedLabel.TabIndex = 15;
            this.playerTeamYearFoundedLabel.Text = "Year Founded";
            // 
            // playerTeamCoachLabel
            // 
            this.playerTeamCoachLabel.AutoSize = true;
            this.playerTeamCoachLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamCoachLabel.Location = new System.Drawing.Point(38, 296);
            this.playerTeamCoachLabel.Name = "playerTeamCoachLabel";
            this.playerTeamCoachLabel.Size = new System.Drawing.Size(48, 17);
            this.playerTeamCoachLabel.TabIndex = 14;
            this.playerTeamCoachLabel.Text = "Coach";
            // 
            // playerTeamGroundLabel
            // 
            this.playerTeamGroundLabel.AutoSize = true;
            this.playerTeamGroundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamGroundLabel.Location = new System.Drawing.Point(38, 240);
            this.playerTeamGroundLabel.Name = "playerTeamGroundLabel";
            this.playerTeamGroundLabel.Size = new System.Drawing.Size(56, 17);
            this.playerTeamGroundLabel.TabIndex = 13;
            this.playerTeamGroundLabel.Text = "Ground";
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.playersListRegionTextBox);
            this.Controls.Add(this.playersListYearFoundedTextBox);
            this.Controls.Add(this.playersListCoachTextBox);
            this.Controls.Add(this.playersListGroundTextBox);
            this.Controls.Add(this.playerTeamRegionLabel);
            this.Controls.Add(this.playerTeamYearFoundedLabel);
            this.Controls.Add(this.playerTeamCoachLabel);
            this.Controls.Add(this.playerTeamGroundLabel);
            this.Controls.Add(this.numberOfPlayers);
            this.Controls.Add(this.labelEnrolledNumber);
            this.Controls.Add(this.playersListTeamName);
            this.Controls.Add(this.playersListLogo);
            this.Controls.Add(this.teamPlayersSpreadsheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerList";
            ((System.ComponentModel.ISupportInitialize)(this.playersListLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView teamPlayersSpreadsheet;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerID;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerName;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerDOB;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerHeight;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerWeight;
        private System.Windows.Forms.ColumnHeader columnTeamPlayerBirthPlace;
        private System.Windows.Forms.PictureBox playersListLogo;
        private System.Windows.Forms.Label playersListTeamName;
        private System.Windows.Forms.Label labelEnrolledNumber;
        private System.Windows.Forms.Label numberOfPlayers;
        private System.Windows.Forms.TextBox playersListRegionTextBox;
        private System.Windows.Forms.TextBox playersListYearFoundedTextBox;
        private System.Windows.Forms.TextBox playersListCoachTextBox;
        private System.Windows.Forms.TextBox playersListGroundTextBox;
        private System.Windows.Forms.Label playerTeamRegionLabel;
        private System.Windows.Forms.Label playerTeamYearFoundedLabel;
        private System.Windows.Forms.Label playerTeamCoachLabel;
        private System.Windows.Forms.Label playerTeamGroundLabel;
    }
}