
namespace RugbyManager
{
    partial class MainForm
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPlayerFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTeamFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlayerToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTeamToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.showEnrolledPlayerBtn = new System.Windows.Forms.TabPage();
            this.clearTeamBtn = new System.Windows.Forms.Button();
            this.clearPlayerBtn = new System.Windows.Forms.Button();
            this.trigerSearchbtn = new System.Windows.Forms.Button();
            this.charts = new System.Windows.Forms.Button();
            this.trigerPlayersListBtn = new System.Windows.Forms.Button();
            this.playerSelectedEnrollmentTextBox1 = new System.Windows.Forms.TextBox();
            this.teamSelectedEnrollmentTextBox = new System.Windows.Forms.TextBox();
            this.playerSelectedEnrollmentTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teamSelectedEnrollmentLabel = new System.Windows.Forms.Label();
            this.playerSelectedEnrollmentLabel = new System.Windows.Forms.Label();
            this.enrollmentButton = new System.Windows.Forms.Button();
            this.previousTeamLogo = new System.Windows.Forms.PictureBox();
            this.newlyEnrolledTeamLogo = new System.Windows.Forms.PictureBox();
            this.trigerAddTeamButton = new System.Windows.Forms.Button();
            this.teamSpreadsheet = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGround = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFoundedYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerTeamRegionTextBox = new System.Windows.Forms.TextBox();
            this.playerTeamYearFoundedTextBox = new System.Windows.Forms.TextBox();
            this.playerTeamCoachTextBox = new System.Windows.Forms.TextBox();
            this.playerTeamGroundTextBox = new System.Windows.Forms.TextBox();
            this.playerTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.playerTeamRegionLabel = new System.Windows.Forms.Label();
            this.playerTeamYearFoundedLabel = new System.Windows.Forms.Label();
            this.playerTeamCoachLabel = new System.Windows.Forms.Label();
            this.playerTeamGroundLabel = new System.Windows.Forms.Label();
            this.playerTeamNameLabel = new System.Windows.Forms.Label();
            this.playerTeamDetailsLabel = new System.Windows.Forms.Label();
            this.trigerAddPlayerButton = new System.Windows.Forms.Button();
            this.playerSpreadsheet = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rugbyManagementTab = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.showEnrolledPlayerBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newlyEnrolledTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.rugbyManagementTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1462, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPlayerFromFileToolStripMenuItem,
            this.importTeamFromFileToolStripMenuItem});
            this.importToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importPlayerFromFileToolStripMenuItem
            // 
            this.importPlayerFromFileToolStripMenuItem.Name = "importPlayerFromFileToolStripMenuItem";
            this.importPlayerFromFileToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.importPlayerFromFileToolStripMenuItem.Text = "Import Player From File";
            this.importPlayerFromFileToolStripMenuItem.Click += new System.EventHandler(this.ImportPlayerFromFileToolStripMenuItem_Click);
            // 
            // importTeamFromFileToolStripMenuItem
            // 
            this.importTeamFromFileToolStripMenuItem.Name = "importTeamFromFileToolStripMenuItem";
            this.importTeamFromFileToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.importTeamFromFileToolStripMenuItem.Text = "Import Team From File";
            this.importTeamFromFileToolStripMenuItem.Click += new System.EventHandler(this.ImportTeamFromFileToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportPlayerToFileToolStripMenuItem,
            this.exportTeamToFileToolStripMenuItem});
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportPlayerToFileToolStripMenuItem
            // 
            this.exportPlayerToFileToolStripMenuItem.Name = "exportPlayerToFileToolStripMenuItem";
            this.exportPlayerToFileToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exportPlayerToFileToolStripMenuItem.Text = "Export Player To File";
            this.exportPlayerToFileToolStripMenuItem.Click += new System.EventHandler(this.ExportPlayerToFileToolStripMenuItem_Click);
            // 
            // exportTeamToFileToolStripMenuItem
            // 
            this.exportTeamToFileToolStripMenuItem.Name = "exportTeamToFileToolStripMenuItem";
            this.exportTeamToFileToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.exportTeamToFileToolStripMenuItem.Text = "Export Team To File";
            this.exportTeamToFileToolStripMenuItem.Click += new System.EventHandler(this.ExportTeamToFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.AutoToolTip = true;
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.ToolTipText = "Please find \'.docx\' file which named \'User Manual\' in root folder.";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.UserManualToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "National Rugby League";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1012, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Player/Team Management Software";
            // 
            // showEnrolledPlayerBtn
            // 
            this.showEnrolledPlayerBtn.BackColor = System.Drawing.Color.White;
            this.showEnrolledPlayerBtn.Controls.Add(this.clearTeamBtn);
            this.showEnrolledPlayerBtn.Controls.Add(this.clearPlayerBtn);
            this.showEnrolledPlayerBtn.Controls.Add(this.trigerSearchbtn);
            this.showEnrolledPlayerBtn.Controls.Add(this.charts);
            this.showEnrolledPlayerBtn.Controls.Add(this.trigerPlayersListBtn);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerSelectedEnrollmentTextBox1);
            this.showEnrolledPlayerBtn.Controls.Add(this.teamSelectedEnrollmentTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerSelectedEnrollmentTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.label8);
            this.showEnrolledPlayerBtn.Controls.Add(this.label7);
            this.showEnrolledPlayerBtn.Controls.Add(this.label6);
            this.showEnrolledPlayerBtn.Controls.Add(this.teamSelectedEnrollmentLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerSelectedEnrollmentLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.enrollmentButton);
            this.showEnrolledPlayerBtn.Controls.Add(this.previousTeamLogo);
            this.showEnrolledPlayerBtn.Controls.Add(this.newlyEnrolledTeamLogo);
            this.showEnrolledPlayerBtn.Controls.Add(this.trigerAddTeamButton);
            this.showEnrolledPlayerBtn.Controls.Add(this.teamSpreadsheet);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamRegionTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamYearFoundedTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamCoachTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamGroundTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamNameTextBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.logoBox);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamRegionLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamYearFoundedLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamCoachLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamGroundLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamNameLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerTeamDetailsLabel);
            this.showEnrolledPlayerBtn.Controls.Add(this.trigerAddPlayerButton);
            this.showEnrolledPlayerBtn.Controls.Add(this.playerSpreadsheet);
            this.showEnrolledPlayerBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showEnrolledPlayerBtn.Location = new System.Drawing.Point(4, 28);
            this.showEnrolledPlayerBtn.Name = "showEnrolledPlayerBtn";
            this.showEnrolledPlayerBtn.Padding = new System.Windows.Forms.Padding(3);
            this.showEnrolledPlayerBtn.Size = new System.Drawing.Size(1386, 615);
            this.showEnrolledPlayerBtn.TabIndex = 1;
            this.showEnrolledPlayerBtn.Text = "Information & Enrollment       ";
            // 
            // clearTeamBtn
            // 
            this.clearTeamBtn.BackgroundImage = global::RugbyManager.Properties.Resources.clearRed;
            this.clearTeamBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearTeamBtn.Location = new System.Drawing.Point(355, 357);
            this.clearTeamBtn.Name = "clearTeamBtn";
            this.clearTeamBtn.Size = new System.Drawing.Size(32, 32);
            this.clearTeamBtn.TabIndex = 33;
            this.clearTeamBtn.UseVisualStyleBackColor = false;
            this.clearTeamBtn.Click += new System.EventHandler(this.ClearTeamBtn_Click);
            // 
            // clearPlayerBtn
            // 
            this.clearPlayerBtn.BackgroundImage = global::RugbyManager.Properties.Resources.clearRed;
            this.clearPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearPlayerBtn.Location = new System.Drawing.Point(358, 110);
            this.clearPlayerBtn.Name = "clearPlayerBtn";
            this.clearPlayerBtn.Size = new System.Drawing.Size(32, 32);
            this.clearPlayerBtn.TabIndex = 32;
            this.clearPlayerBtn.UseVisualStyleBackColor = false;
            this.clearPlayerBtn.Click += new System.EventHandler(this.ClearPlayerBtn_Click);
            // 
            // trigerSearchbtn
            // 
            this.trigerSearchbtn.BackgroundImage = global::RugbyManager.Properties.Resources.search;
            this.trigerSearchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trigerSearchbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trigerSearchbtn.Location = new System.Drawing.Point(358, 72);
            this.trigerSearchbtn.Name = "trigerSearchbtn";
            this.trigerSearchbtn.Size = new System.Drawing.Size(32, 32);
            this.trigerSearchbtn.TabIndex = 31;
            this.trigerSearchbtn.UseVisualStyleBackColor = false;
            this.trigerSearchbtn.Click += new System.EventHandler(this.TrigerSearchbtn_Click);
            // 
            // charts
            // 
            this.charts.BackColor = System.Drawing.Color.White;
            this.charts.BackgroundImage = global::RugbyManager.Properties.Resources.chart;
            this.charts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.charts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.charts.Location = new System.Drawing.Point(323, 229);
            this.charts.Name = "charts";
            this.charts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.charts.Size = new System.Drawing.Size(64, 64);
            this.charts.TabIndex = 30;
            this.charts.UseVisualStyleBackColor = false;
            this.charts.Click += new System.EventHandler(this.Charts_Click);
            // 
            // trigerPlayersListBtn
            // 
            this.trigerPlayersListBtn.BackgroundImage = global::RugbyManager.Properties.Resources.plist;
            this.trigerPlayersListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trigerPlayersListBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.trigerPlayersListBtn.Location = new System.Drawing.Point(323, 512);
            this.trigerPlayersListBtn.Name = "trigerPlayersListBtn";
            this.trigerPlayersListBtn.Size = new System.Drawing.Size(64, 64);
            this.trigerPlayersListBtn.TabIndex = 29;
            this.trigerPlayersListBtn.UseVisualStyleBackColor = false;
            this.trigerPlayersListBtn.Click += new System.EventHandler(this.TrigerPlayersListBtn_Click);
            // 
            // playerSelectedEnrollmentTextBox1
            // 
            this.playerSelectedEnrollmentTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerSelectedEnrollmentTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSelectedEnrollmentTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.playerSelectedEnrollmentTextBox1.Location = new System.Drawing.Point(42, 36);
            this.playerSelectedEnrollmentTextBox1.Name = "playerSelectedEnrollmentTextBox1";
            this.playerSelectedEnrollmentTextBox1.Size = new System.Drawing.Size(218, 22);
            this.playerSelectedEnrollmentTextBox1.TabIndex = 28;
            this.playerSelectedEnrollmentTextBox1.Text = "Player\'s";
            // 
            // teamSelectedEnrollmentTextBox
            // 
            this.teamSelectedEnrollmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamSelectedEnrollmentTextBox.ForeColor = System.Drawing.Color.Green;
            this.teamSelectedEnrollmentTextBox.Location = new System.Drawing.Point(1153, 341);
            this.teamSelectedEnrollmentTextBox.Name = "teamSelectedEnrollmentTextBox";
            this.teamSelectedEnrollmentTextBox.Size = new System.Drawing.Size(193, 17);
            this.teamSelectedEnrollmentTextBox.TabIndex = 20;
            this.teamSelectedEnrollmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerSelectedEnrollmentTextBox
            // 
            this.playerSelectedEnrollmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerSelectedEnrollmentTextBox.ForeColor = System.Drawing.Color.Green;
            this.playerSelectedEnrollmentTextBox.Location = new System.Drawing.Point(1153, 110);
            this.playerSelectedEnrollmentTextBox.Name = "playerSelectedEnrollmentTextBox";
            this.playerSelectedEnrollmentTextBox.Size = new System.Drawing.Size(193, 17);
            this.playerSelectedEnrollmentTextBox.TabIndex = 19;
            this.playerSelectedEnrollmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(1153, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Enroll To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(1153, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Current Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(1149, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Enroll Player To Team";
            // 
            // teamSelectedEnrollmentLabel
            // 
            this.teamSelectedEnrollmentLabel.AutoSize = true;
            this.teamSelectedEnrollmentLabel.Location = new System.Drawing.Point(1153, 319);
            this.teamSelectedEnrollmentLabel.Name = "teamSelectedEnrollmentLabel";
            this.teamSelectedEnrollmentLabel.Size = new System.Drawing.Size(110, 19);
            this.teamSelectedEnrollmentLabel.TabIndex = 22;
            this.teamSelectedEnrollmentLabel.Text = "Team Selected";
            // 
            // playerSelectedEnrollmentLabel
            // 
            this.playerSelectedEnrollmentLabel.AutoSize = true;
            this.playerSelectedEnrollmentLabel.Location = new System.Drawing.Point(1153, 88);
            this.playerSelectedEnrollmentLabel.Name = "playerSelectedEnrollmentLabel";
            this.playerSelectedEnrollmentLabel.Size = new System.Drawing.Size(114, 19);
            this.playerSelectedEnrollmentLabel.TabIndex = 21;
            this.playerSelectedEnrollmentLabel.Text = "Player Selected";
            // 
            // enrollmentButton
            // 
            this.enrollmentButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.enrollmentButton.Location = new System.Drawing.Point(1153, 546);
            this.enrollmentButton.Name = "enrollmentButton";
            this.enrollmentButton.Size = new System.Drawing.Size(193, 30);
            this.enrollmentButton.TabIndex = 18;
            this.enrollmentButton.Text = "Enroll";
            this.enrollmentButton.UseVisualStyleBackColor = true;
            this.enrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click_1);
            // 
            // previousTeamLogo
            // 
            this.previousTeamLogo.Location = new System.Drawing.Point(1153, 188);
            this.previousTeamLogo.Name = "previousTeamLogo";
            this.previousTeamLogo.Size = new System.Drawing.Size(193, 91);
            this.previousTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousTeamLogo.TabIndex = 25;
            this.previousTeamLogo.TabStop = false;
            // 
            // newlyEnrolledTeamLogo
            // 
            this.newlyEnrolledTeamLogo.Location = new System.Drawing.Point(1153, 417);
            this.newlyEnrolledTeamLogo.Name = "newlyEnrolledTeamLogo";
            this.newlyEnrolledTeamLogo.Size = new System.Drawing.Size(193, 91);
            this.newlyEnrolledTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newlyEnrolledTeamLogo.TabIndex = 24;
            this.newlyEnrolledTeamLogo.TabStop = false;
            // 
            // trigerAddTeamButton
            // 
            this.trigerAddTeamButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.trigerAddTeamButton.Location = new System.Drawing.Point(323, 319);
            this.trigerAddTeamButton.Name = "trigerAddTeamButton";
            this.trigerAddTeamButton.Size = new System.Drawing.Size(64, 32);
            this.trigerAddTeamButton.TabIndex = 15;
            this.trigerAddTeamButton.Text = "Add";
            this.trigerAddTeamButton.UseVisualStyleBackColor = true;
            this.trigerAddTeamButton.Click += new System.EventHandler(this.TrigerAddTeamButton_Click_1);
            // 
            // teamSpreadsheet
            // 
            this.teamSpreadsheet.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.teamSpreadsheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnGround,
            this.columnCoach,
            this.columnFoundedYear,
            this.columnRegion});
            this.teamSpreadsheet.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teamSpreadsheet.FullRowSelect = true;
            this.teamSpreadsheet.GridLines = true;
            this.teamSpreadsheet.HideSelection = false;
            this.teamSpreadsheet.Location = new System.Drawing.Point(393, 319);
            this.teamSpreadsheet.Name = "teamSpreadsheet";
            this.teamSpreadsheet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.teamSpreadsheet.Size = new System.Drawing.Size(710, 257);
            this.teamSpreadsheet.TabIndex = 14;
            this.teamSpreadsheet.UseCompatibleStateImageBehavior = false;
            this.teamSpreadsheet.View = System.Windows.Forms.View.Details;
            this.teamSpreadsheet.SelectedIndexChanged += new System.EventHandler(this.TeamSpreadsheet_SelectedIndexChanged_1);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 185;
            // 
            // columnGround
            // 
            this.columnGround.Text = "Ground";
            this.columnGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnGround.Width = 170;
            // 
            // columnCoach
            // 
            this.columnCoach.Text = "Coach";
            this.columnCoach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCoach.Width = 86;
            // 
            // columnFoundedYear
            // 
            this.columnFoundedYear.Text = "Founded Year";
            this.columnFoundedYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFoundedYear.Width = 108;
            // 
            // columnRegion
            // 
            this.columnRegion.Text = "Region";
            this.columnRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRegion.Width = 86;
            // 
            // playerTeamRegionTextBox
            // 
            this.playerTeamRegionTextBox.BackColor = System.Drawing.Color.White;
            this.playerTeamRegionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTeamRegionTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamRegionTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerTeamRegionTextBox.Location = new System.Drawing.Point(147, 271);
            this.playerTeamRegionTextBox.Name = "playerTeamRegionTextBox";
            this.playerTeamRegionTextBox.ReadOnly = true;
            this.playerTeamRegionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerTeamRegionTextBox.Size = new System.Drawing.Size(163, 17);
            this.playerTeamRegionTextBox.TabIndex = 12;
            // 
            // playerTeamYearFoundedTextBox
            // 
            this.playerTeamYearFoundedTextBox.BackColor = System.Drawing.Color.White;
            this.playerTeamYearFoundedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTeamYearFoundedTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamYearFoundedTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerTeamYearFoundedTextBox.Location = new System.Drawing.Point(147, 238);
            this.playerTeamYearFoundedTextBox.Name = "playerTeamYearFoundedTextBox";
            this.playerTeamYearFoundedTextBox.ReadOnly = true;
            this.playerTeamYearFoundedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerTeamYearFoundedTextBox.Size = new System.Drawing.Size(163, 17);
            this.playerTeamYearFoundedTextBox.TabIndex = 11;
            // 
            // playerTeamCoachTextBox
            // 
            this.playerTeamCoachTextBox.BackColor = System.Drawing.Color.White;
            this.playerTeamCoachTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTeamCoachTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamCoachTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerTeamCoachTextBox.Location = new System.Drawing.Point(147, 205);
            this.playerTeamCoachTextBox.Name = "playerTeamCoachTextBox";
            this.playerTeamCoachTextBox.ReadOnly = true;
            this.playerTeamCoachTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerTeamCoachTextBox.Size = new System.Drawing.Size(163, 17);
            this.playerTeamCoachTextBox.TabIndex = 10;
            // 
            // playerTeamGroundTextBox
            // 
            this.playerTeamGroundTextBox.BackColor = System.Drawing.Color.White;
            this.playerTeamGroundTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTeamGroundTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamGroundTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerTeamGroundTextBox.Location = new System.Drawing.Point(147, 172);
            this.playerTeamGroundTextBox.Name = "playerTeamGroundTextBox";
            this.playerTeamGroundTextBox.ReadOnly = true;
            this.playerTeamGroundTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerTeamGroundTextBox.Size = new System.Drawing.Size(163, 17);
            this.playerTeamGroundTextBox.TabIndex = 9;
            // 
            // playerTeamNameTextBox
            // 
            this.playerTeamNameTextBox.BackColor = System.Drawing.Color.White;
            this.playerTeamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTeamNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.playerTeamNameTextBox.Location = new System.Drawing.Point(147, 139);
            this.playerTeamNameTextBox.Name = "playerTeamNameTextBox";
            this.playerTeamNameTextBox.ReadOnly = true;
            this.playerTeamNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerTeamNameTextBox.Size = new System.Drawing.Size(163, 17);
            this.playerTeamNameTextBox.TabIndex = 8;
            // 
            // logoBox
            // 
            this.logoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoBox.InitialImage")));
            this.logoBox.Location = new System.Drawing.Point(42, 380);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(159, 186);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 13;
            this.logoBox.TabStop = false;
            // 
            // playerTeamRegionLabel
            // 
            this.playerTeamRegionLabel.AutoSize = true;
            this.playerTeamRegionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamRegionLabel.Location = new System.Drawing.Point(38, 269);
            this.playerTeamRegionLabel.Name = "playerTeamRegionLabel";
            this.playerTeamRegionLabel.Size = new System.Drawing.Size(58, 19);
            this.playerTeamRegionLabel.TabIndex = 7;
            this.playerTeamRegionLabel.Text = "Region";
            // 
            // playerTeamYearFoundedLabel
            // 
            this.playerTeamYearFoundedLabel.AutoSize = true;
            this.playerTeamYearFoundedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamYearFoundedLabel.Location = new System.Drawing.Point(38, 236);
            this.playerTeamYearFoundedLabel.Name = "playerTeamYearFoundedLabel";
            this.playerTeamYearFoundedLabel.Size = new System.Drawing.Size(105, 19);
            this.playerTeamYearFoundedLabel.TabIndex = 6;
            this.playerTeamYearFoundedLabel.Text = "Year Founded";
            // 
            // playerTeamCoachLabel
            // 
            this.playerTeamCoachLabel.AutoSize = true;
            this.playerTeamCoachLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamCoachLabel.Location = new System.Drawing.Point(38, 203);
            this.playerTeamCoachLabel.Name = "playerTeamCoachLabel";
            this.playerTeamCoachLabel.Size = new System.Drawing.Size(51, 19);
            this.playerTeamCoachLabel.TabIndex = 5;
            this.playerTeamCoachLabel.Text = "Coach";
            // 
            // playerTeamGroundLabel
            // 
            this.playerTeamGroundLabel.AutoSize = true;
            this.playerTeamGroundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamGroundLabel.Location = new System.Drawing.Point(38, 170);
            this.playerTeamGroundLabel.Name = "playerTeamGroundLabel";
            this.playerTeamGroundLabel.Size = new System.Drawing.Size(62, 19);
            this.playerTeamGroundLabel.TabIndex = 4;
            this.playerTeamGroundLabel.Text = "Ground";
            // 
            // playerTeamNameLabel
            // 
            this.playerTeamNameLabel.AutoSize = true;
            this.playerTeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerTeamNameLabel.Location = new System.Drawing.Point(38, 137);
            this.playerTeamNameLabel.Name = "playerTeamNameLabel";
            this.playerTeamNameLabel.Size = new System.Drawing.Size(94, 19);
            this.playerTeamNameLabel.TabIndex = 3;
            this.playerTeamNameLabel.Text = "Team Name";
            // 
            // playerTeamDetailsLabel
            // 
            this.playerTeamDetailsLabel.AutoSize = true;
            this.playerTeamDetailsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamDetailsLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.playerTeamDetailsLabel.Location = new System.Drawing.Point(38, 66);
            this.playerTeamDetailsLabel.Name = "playerTeamDetailsLabel";
            this.playerTeamDetailsLabel.Size = new System.Drawing.Size(126, 24);
            this.playerTeamDetailsLabel.TabIndex = 2;
            this.playerTeamDetailsLabel.Text = "Team Details ";
            // 
            // trigerAddPlayerButton
            // 
            this.trigerAddPlayerButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.trigerAddPlayerButton.Location = new System.Drawing.Point(326, 36);
            this.trigerAddPlayerButton.Name = "trigerAddPlayerButton";
            this.trigerAddPlayerButton.Size = new System.Drawing.Size(64, 32);
            this.trigerAddPlayerButton.TabIndex = 1;
            this.trigerAddPlayerButton.Text = "Add";
            this.trigerAddPlayerButton.UseVisualStyleBackColor = true;
            this.trigerAddPlayerButton.Click += new System.EventHandler(this.TrigerAddPlayerButton_Click);
            // 
            // playerSpreadsheet
            // 
            this.playerSpreadsheet.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.playerSpreadsheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnPName,
            this.columnDOB,
            this.columnHeight,
            this.columnWeight,
            this.columnBirthPlace,
            this.columnTeam});
            this.playerSpreadsheet.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerSpreadsheet.FullRowSelect = true;
            this.playerSpreadsheet.GridLines = true;
            this.playerSpreadsheet.HideSelection = false;
            this.playerSpreadsheet.Location = new System.Drawing.Point(393, 36);
            this.playerSpreadsheet.Name = "playerSpreadsheet";
            this.playerSpreadsheet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerSpreadsheet.Size = new System.Drawing.Size(710, 257);
            this.playerSpreadsheet.TabIndex = 0;
            this.playerSpreadsheet.UseCompatibleStateImageBehavior = false;
            this.playerSpreadsheet.View = System.Windows.Forms.View.Details;
            this.playerSpreadsheet.SelectedIndexChanged += new System.EventHandler(this.PlayerSpreadsheet_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 31;
            // 
            // columnPName
            // 
            this.columnPName.Text = "Name";
            this.columnPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPName.Width = 167;
            // 
            // columnDOB
            // 
            this.columnDOB.Text = "Date Of Birth";
            this.columnDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDOB.Width = 120;
            // 
            // columnHeight
            // 
            this.columnHeight.Text = "Height";
            this.columnHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnWeight
            // 
            this.columnWeight.Text = "Weight";
            this.columnWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnBirthPlace
            // 
            this.columnBirthPlace.Text = "Place of Birth";
            this.columnBirthPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBirthPlace.Width = 132;
            // 
            // columnTeam
            // 
            this.columnTeam.Text = "Team";
            this.columnTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeam.Width = 147;
            // 
            // rugbyManagementTab
            // 
            this.rugbyManagementTab.Controls.Add(this.showEnrolledPlayerBtn);
            this.rugbyManagementTab.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyManagementTab.Location = new System.Drawing.Point(34, 104);
            this.rugbyManagementTab.Name = "rugbyManagementTab";
            this.rugbyManagementTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rugbyManagementTab.SelectedIndex = 0;
            this.rugbyManagementTab.Size = new System.Drawing.Size(1394, 647);
            this.rugbyManagementTab.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1335, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 784);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.rugbyManagementTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NRL Manager by Chao Yue 20008378";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.showEnrolledPlayerBtn.ResumeLayout(false);
            this.showEnrolledPlayerBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newlyEnrolledTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.rugbyManagementTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPlayerFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTeamFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPlayerToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTeamToFileToolStripMenuItem;
        private System.Windows.Forms.TabPage showEnrolledPlayerBtn;
        private System.Windows.Forms.Button trigerSearchbtn;
        private System.Windows.Forms.Button charts;
        private System.Windows.Forms.Button trigerPlayersListBtn;
        private System.Windows.Forms.TextBox playerSelectedEnrollmentTextBox1;
        private System.Windows.Forms.TextBox teamSelectedEnrollmentTextBox;
        private System.Windows.Forms.TextBox playerSelectedEnrollmentTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label teamSelectedEnrollmentLabel;
        private System.Windows.Forms.Label playerSelectedEnrollmentLabel;
        private System.Windows.Forms.Button enrollmentButton;
        private System.Windows.Forms.PictureBox previousTeamLogo;
        private System.Windows.Forms.PictureBox newlyEnrolledTeamLogo;
        private System.Windows.Forms.Button trigerAddTeamButton;
        private System.Windows.Forms.ListView teamSpreadsheet;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnGround;
        private System.Windows.Forms.ColumnHeader columnCoach;
        private System.Windows.Forms.ColumnHeader columnFoundedYear;
        private System.Windows.Forms.ColumnHeader columnRegion;
        private System.Windows.Forms.TextBox playerTeamRegionTextBox;
        private System.Windows.Forms.TextBox playerTeamYearFoundedTextBox;
        private System.Windows.Forms.TextBox playerTeamCoachTextBox;
        private System.Windows.Forms.TextBox playerTeamGroundTextBox;
        private System.Windows.Forms.TextBox playerTeamNameTextBox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label playerTeamRegionLabel;
        private System.Windows.Forms.Label playerTeamYearFoundedLabel;
        private System.Windows.Forms.Label playerTeamCoachLabel;
        private System.Windows.Forms.Label playerTeamGroundLabel;
        private System.Windows.Forms.Label playerTeamNameLabel;
        private System.Windows.Forms.Label playerTeamDetailsLabel;
        private System.Windows.Forms.Button trigerAddPlayerButton;
        private System.Windows.Forms.ListView playerSpreadsheet;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnPName;
        private System.Windows.Forms.ColumnHeader columnDOB;
        private System.Windows.Forms.ColumnHeader columnHeight;
        private System.Windows.Forms.ColumnHeader columnWeight;
        private System.Windows.Forms.ColumnHeader columnBirthPlace;
        private System.Windows.Forms.ColumnHeader columnTeam;
        private System.Windows.Forms.TabControl rugbyManagementTab;
        private System.Windows.Forms.Button clearTeamBtn;
        private System.Windows.Forms.Button clearPlayerBtn;
    }
}

