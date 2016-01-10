namespace Library.WinForms
{
    partial class UpDateFrm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.datepublishingLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.datepublishingTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(155, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 32);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // datepublishingLbl
            // 
            this.datepublishingLbl.AutoSize = true;
            this.datepublishingLbl.Location = new System.Drawing.Point(33, 166);
            this.datepublishingLbl.Name = "datepublishingLbl";
            this.datepublishingLbl.Size = new System.Drawing.Size(93, 13);
            this.datepublishingLbl.TabIndex = 28;
            this.datepublishingLbl.Text = "Date of Publishing";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(39, 130);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(50, 13);
            this.publisherLbl.TabIndex = 27;
            this.publisherLbl.Text = "Publisher";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(39, 93);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(38, 13);
            this.authorLbl.TabIndex = 26;
            this.authorLbl.Text = "Author";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(39, 53);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 25;
            this.nameLbl.Text = "Name";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(34, 214);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 32);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // datepublishingTxtBox
            // 
            this.datepublishingTxtBox.Location = new System.Drawing.Point(132, 159);
            this.datepublishingTxtBox.Name = "datepublishingTxtBox";
            this.datepublishingTxtBox.Size = new System.Drawing.Size(100, 20);
            this.datepublishingTxtBox.TabIndex = 23;
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(132, 123);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTxtBox.TabIndex = 22;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(132, 86);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(100, 20);
            this.authorTxtBox.TabIndex = 21;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(132, 46);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 20;
            // 
            // UpDateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 292);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.datepublishingLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.datepublishingTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "UpDateFrm";
            this.Text = "UpDateFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label datepublishingLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button okButton;
        public System.Windows.Forms.TextBox datepublishingTxtBox;
        public System.Windows.Forms.TextBox publisherTxtBox;
        public System.Windows.Forms.TextBox authorTxtBox;
        public System.Windows.Forms.TextBox nameTxtBox;
    }
}