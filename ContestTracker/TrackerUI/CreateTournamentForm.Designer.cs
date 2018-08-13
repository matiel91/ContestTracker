namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValueTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.torunamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPLayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(24, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(338, 49);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameTextBox.Location = new System.Drawing.Point(33, 125);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(253, 31);
            this.tournamentNameTextBox.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(27, 86);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(237, 36);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Torunament Name";
            // 
            // entryFeeValueTextBox
            // 
            this.entryFeeValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeValueTextBox.Location = new System.Drawing.Point(162, 176);
            this.entryFeeValueTextBox.Name = "entryFeeValueTextBox";
            this.entryFeeValueTextBox.Size = new System.Drawing.Size(102, 31);
            this.entryFeeValueTextBox.TabIndex = 12;
            this.entryFeeValueTextBox.Text = "0";
            this.entryFeeValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(27, 171);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(129, 36);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(33, 281);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(253, 33);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(27, 242);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(157, 36);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(206, 255);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(87, 20);
            this.createNewTeamLinkLabel.TabIndex = 15;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(84, 320);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(166, 48);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(84, 390);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(166, 48);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // torunamentPlayersListBox
            // 
            this.torunamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.torunamentPlayersListBox.FormattingEnabled = true;
            this.torunamentPlayersListBox.Location = new System.Drawing.Point(383, 125);
            this.torunamentPlayersListBox.Name = "torunamentPlayersListBox";
            this.torunamentPlayersListBox.Size = new System.Drawing.Size(252, 93);
            this.torunamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(377, 86);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(199, 36);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPLayersButton
            // 
            this.deleteSelectedPLayersButton.BackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPLayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPLayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteSelectedPLayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteSelectedPLayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSelectedPLayersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPLayersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPLayersButton.Location = new System.Drawing.Point(641, 145);
            this.deleteSelectedPLayersButton.Name = "deleteSelectedPLayersButton";
            this.deleteSelectedPLayersButton.Size = new System.Drawing.Size(112, 62);
            this.deleteSelectedPLayersButton.TabIndex = 20;
            this.deleteSelectedPLayersButton.Text = "Delete Selected";
            this.deleteSelectedPLayersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteSelectedPLayersButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(641, 303);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(112, 65);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizeLabel.Location = new System.Drawing.Point(377, 244);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(83, 36);
            this.prizeLabel.TabIndex = 22;
            this.prizeLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.Location = new System.Drawing.Point(383, 281);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(252, 93);
            this.prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.Location = new System.Drawing.Point(228, 475);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(232, 48);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPLayersButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.torunamentPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValueTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValueTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox torunamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPLayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}