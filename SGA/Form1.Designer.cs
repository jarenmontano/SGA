namespace SGA
{
    partial class SGA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RBxIntramural = new RadioButton();
            RBxFratSor = new RadioButton();
            RBxClub = new RadioButton();
            TBxName = new TextBox();
            TBxFundingAmt = new TextBox();
            lblName = new Label();
            lblFundingAmount = new Label();
            GRBxOrganizationType = new GroupBox();
            GRBxOrganizationType.SuspendLayout();
            SuspendLayout();
            // 
            // RBxIntramural
            // 
            RBxIntramural.AutoSize = true;
            RBxIntramural.ForeColor = Color.Yellow;
            RBxIntramural.Location = new Point(39, 34);
            RBxIntramural.Name = "RBxIntramural";
            RBxIntramural.Size = new Size(111, 19);
            RBxIntramural.TabIndex = 0;
            RBxIntramural.Text = "Intramural Team";
            RBxIntramural.UseVisualStyleBackColor = true;
            RBxIntramural.CheckedChanged += RBxIntramural_CheckedChanged;
            // 
            // RBxFratSor
            // 
            RBxFratSor.AutoSize = true;
            RBxFratSor.ForeColor = Color.Yellow;
            RBxFratSor.Location = new Point(39, 59);
            RBxFratSor.Name = "RBxFratSor";
            RBxFratSor.Size = new Size(121, 19);
            RBxFratSor.TabIndex = 1;
            RBxFratSor.Text = "Fraternity/Sorority";
            RBxFratSor.UseVisualStyleBackColor = true;
            RBxFratSor.CheckedChanged += RBxFratSor_CheckedChanged;
            // 
            // RBxClub
            // 
            RBxClub.AutoSize = true;
            RBxClub.ForeColor = Color.Yellow;
            RBxClub.Location = new Point(39, 84);
            RBxClub.Name = "RBxClub";
            RBxClub.Size = new Size(50, 19);
            RBxClub.TabIndex = 2;
            RBxClub.Text = "Club";
            RBxClub.UseVisualStyleBackColor = true;
            RBxClub.CheckedChanged += RBxClub_CheckedChanged;
            // 
            // TBxName
            // 
            TBxName.ForeColor = SystemColors.ActiveCaptionText;
            TBxName.Location = new Point(57, 249);
            TBxName.Name = "TBxName";
            TBxName.Size = new Size(191, 23);
            TBxName.TabIndex = 3;
            TBxName.Visible = false;
            // 
            // TBxFundingAmt
            // 
            TBxFundingAmt.ForeColor = SystemColors.ActiveCaptionText;
            TBxFundingAmt.Location = new Point(140, 290);
            TBxFundingAmt.Name = "TBxFundingAmt";
            TBxFundingAmt.Size = new Size(108, 23);
            TBxFundingAmt.TabIndex = 4;
            TBxFundingAmt.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(12, 257);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            lblName.Visible = false;
            // 
            // lblFundingAmount
            // 
            lblFundingAmount.AutoSize = true;
            lblFundingAmount.ForeColor = Color.Yellow;
            lblFundingAmount.Location = new Point(12, 298);
            lblFundingAmount.Name = "lblFundingAmount";
            lblFundingAmount.Size = new Size(98, 15);
            lblFundingAmount.TabIndex = 6;
            lblFundingAmount.Text = "Funding Amount";
            lblFundingAmount.Visible = false;
            // 
            // GRBxOrganizationType
            // 
            GRBxOrganizationType.Controls.Add(RBxClub);
            GRBxOrganizationType.Controls.Add(RBxFratSor);
            GRBxOrganizationType.Controls.Add(RBxIntramural);
            GRBxOrganizationType.ForeColor = Color.Yellow;
            GRBxOrganizationType.Location = new Point(57, 33);
            GRBxOrganizationType.Name = "GRBxOrganizationType";
            GRBxOrganizationType.Size = new Size(191, 140);
            GRBxOrganizationType.TabIndex = 7;
            GRBxOrganizationType.TabStop = false;
            GRBxOrganizationType.Text = "Select Organization Type";
            // 
            // SGA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(278, 354);
            Controls.Add(lblFundingAmount);
            Controls.Add(lblName);
            Controls.Add(TBxFundingAmt);
            Controls.Add(TBxName);
            Controls.Add(GRBxOrganizationType);
            Name = "SGA";
            Text = "Student Government Association";
            Load += SGA_Load;
            GRBxOrganizationType.ResumeLayout(false);
            GRBxOrganizationType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RBxIntramural;
        private RadioButton RBxFratSor;
        private RadioButton RBxClub;
        private TextBox TBxName;
        private TextBox TBxFundingAmt;
        private Label lblName;
        private Label lblFundingAmount;
        private GroupBox GRBxOrganizationType;
    }
}