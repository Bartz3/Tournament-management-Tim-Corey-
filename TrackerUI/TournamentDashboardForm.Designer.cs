﻿
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(89, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(410, 45);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(134, 153);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(321, 33);
            this.loadExistingTournamentDropDown.TabIndex = 23;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(133, 119);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(322, 31);
            this.loadExistingTournamentLabel.TabIndex = 22;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadTournamentButton.Location = new System.Drawing.Point(186, 192);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(216, 57);
            this.loadTournamentButton.TabIndex = 24;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(134, 271);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(321, 106);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 438);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}