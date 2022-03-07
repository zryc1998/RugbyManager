
namespace Search
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ageBtn = new System.Windows.Forms.RadioButton();
            this.placeBtn = new System.Windows.Forms.RadioButton();
            this.searchPlayerSpreadsheet = new System.Windows.Forms.ListView();
            this.columnIDSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDOBSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeightSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWeightSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthPlaceSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeamSearch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchByLabel.Location = new System.Drawing.Point(40, 27);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(94, 24);
            this.searchByLabel.TabIndex = 11;
            this.searchByLabel.Text = "Search By";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchButton.Location = new System.Drawing.Point(719, 63);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 30);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(244, 67);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(452, 22);
            this.searchTextBox.TabIndex = 9;
            // 
            // ageBtn
            // 
            this.ageBtn.AutoSize = true;
            this.ageBtn.Checked = true;
            this.ageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ageBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBtn.ForeColor = System.Drawing.Color.Green;
            this.ageBtn.Location = new System.Drawing.Point(44, 67);
            this.ageBtn.Name = "ageBtn";
            this.ageBtn.Size = new System.Drawing.Size(57, 23);
            this.ageBtn.TabIndex = 8;
            this.ageBtn.TabStop = true;
            this.ageBtn.Text = "Age";
            this.ageBtn.UseVisualStyleBackColor = true;
            // 
            // placeBtn
            // 
            this.placeBtn.AutoSize = true;
            this.placeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBtn.ForeColor = System.Drawing.Color.Green;
            this.placeBtn.Location = new System.Drawing.Point(104, 67);
            this.placeBtn.Name = "placeBtn";
            this.placeBtn.Size = new System.Drawing.Size(123, 23);
            this.placeBtn.TabIndex = 7;
            this.placeBtn.Text = "Place of Birth";
            this.placeBtn.UseVisualStyleBackColor = true;
            // 
            // searchPlayerSpreadsheet
            // 
            this.searchPlayerSpreadsheet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchPlayerSpreadsheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDSearch,
            this.columnNameSearch,
            this.columnDOBSearch,
            this.columnHeightSearch,
            this.columnWeightSearch,
            this.columnBirthPlaceSearch,
            this.columnTeamSearch});
            this.searchPlayerSpreadsheet.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPlayerSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchPlayerSpreadsheet.FullRowSelect = true;
            this.searchPlayerSpreadsheet.GridLines = true;
            this.searchPlayerSpreadsheet.HideSelection = false;
            this.searchPlayerSpreadsheet.Location = new System.Drawing.Point(44, 113);
            this.searchPlayerSpreadsheet.Name = "searchPlayerSpreadsheet";
            this.searchPlayerSpreadsheet.Size = new System.Drawing.Size(791, 348);
            this.searchPlayerSpreadsheet.TabIndex = 6;
            this.searchPlayerSpreadsheet.UseCompatibleStateImageBehavior = false;
            this.searchPlayerSpreadsheet.View = System.Windows.Forms.View.Details;
            // 
            // columnIDSearch
            // 
            this.columnIDSearch.Text = "ID";
            this.columnIDSearch.Width = 37;
            // 
            // columnNameSearch
            // 
            this.columnNameSearch.Text = "Name";
            this.columnNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNameSearch.Width = 140;
            // 
            // columnDOBSearch
            // 
            this.columnDOBSearch.Text = "Date Of Birth";
            this.columnDOBSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDOBSearch.Width = 97;
            // 
            // columnHeightSearch
            // 
            this.columnHeightSearch.Text = "Height";
            this.columnHeightSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeightSearch.Width = 85;
            // 
            // columnWeightSearch
            // 
            this.columnWeightSearch.Text = "Weight";
            this.columnWeightSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnWeightSearch.Width = 81;
            // 
            // columnBirthPlaceSearch
            // 
            this.columnBirthPlaceSearch.Text = "Place of Birth";
            this.columnBirthPlaceSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBirthPlaceSearch.Width = 168;
            // 
            // columnTeamSearch
            // 
            this.columnTeamSearch.Text = "Team";
            this.columnTeamSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTeamSearch.Width = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "*When search by birth place, please only input city/region, or country name. If b" +
    "oth, need to be seperated by \", \"";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ageBtn);
            this.Controls.Add(this.placeBtn);
            this.Controls.Add(this.searchPlayerSpreadsheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search Player By Age / Birth Place";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton ageBtn;
        private System.Windows.Forms.RadioButton placeBtn;
        private System.Windows.Forms.ListView searchPlayerSpreadsheet;
        private System.Windows.Forms.ColumnHeader columnIDSearch;
        private System.Windows.Forms.ColumnHeader columnNameSearch;
        private System.Windows.Forms.ColumnHeader columnDOBSearch;
        private System.Windows.Forms.ColumnHeader columnHeightSearch;
        private System.Windows.Forms.ColumnHeader columnWeightSearch;
        private System.Windows.Forms.ColumnHeader columnBirthPlaceSearch;
        private System.Windows.Forms.ColumnHeader columnTeamSearch;
        private System.Windows.Forms.Label label1;
    }
}