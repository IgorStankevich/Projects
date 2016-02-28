namespace Library
{
    partial class AddMagazineFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.periodicityTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.datepublishingTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Periodicity";
            // 
            // periodicityTxtBox
            // 
            this.periodicityTxtBox.Location = new System.Drawing.Point(120, 154);
            this.periodicityTxtBox.Name = "periodicityTxtBox";
            this.periodicityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.periodicityTxtBox.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date of Publishing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Publisher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(22, 284);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 32);
            this.okButton.TabIndex = 26;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // datepublishingTxtBox
            // 
            this.datepublishingTxtBox.Location = new System.Drawing.Point(120, 196);
            this.datepublishingTxtBox.Name = "datepublishingTxtBox";
            this.datepublishingTxtBox.Size = new System.Drawing.Size(100, 20);
            this.datepublishingTxtBox.TabIndex = 25;
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(120, 109);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTxtBox.TabIndex = 24;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(120, 72);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 23;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(120, 35);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(100, 20);
            this.authorTxtBox.TabIndex = 22;
            // 
            // AddMagazineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.periodicityTxtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.datepublishingTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.authorTxtBox);
            this.Name = "AddMagazineFrm";
            this.Text = "AddMagazineFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox periodicityTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox datepublishingTxtBox;
        private System.Windows.Forms.TextBox publisherTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
    }
}