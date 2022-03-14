namespace Activity1
{
    partial class Introduction
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
            this.introLabel = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.infoDisplay = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Stencil", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.introLabel.Location = new System.Drawing.Point(268, 102);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(339, 43);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = "Introducing Me!";
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(138, 437);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(170, 34);
            this.nameButton.TabIndex = 2;
            this.nameButton.Text = "See name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(605, 437);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(175, 34);
            this.locationButton.TabIndex = 3;
            this.locationButton.Text = "See location";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(387, 220);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 25);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(147, 220);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(587, 121);
            this.descriptionBox.TabIndex = 5;
            this.descriptionBox.Text = "Below buttons will display information about me, the programmer.\r\nClick location " +
    "to see where I live.\r\nClick name to see my name.";
            this.descriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoDisplay
            // 
            this.infoDisplay.AutoSize = true;
            this.infoDisplay.Location = new System.Drawing.Point(402, 381);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(0, 25);
            this.infoDisplay.TabIndex = 6;
            this.infoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(387, 381);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 25);
            this.info.TabIndex = 7;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 583);
            this.Controls.Add(this.info);
            this.Controls.Add(this.infoDisplay);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.introLabel);
            this.Name = "Introduction";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label introLabel;
        private Button nameButton;
        private Button locationButton;
        private Label descriptionLabel;
        private TextBox descriptionBox;
        private Label infoDisplay;
        private Label info;
    }
}