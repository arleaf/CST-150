namespace Activity7
{
    partial class Form1
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
            this.numOfTermsLabel = new System.Windows.Forms.Label();
            this.approxTextLabel = new System.Windows.Forms.Label();
            this.approxCalLabel = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.piCalculation = new System.Windows.Forms.Label();
            this.termTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOfTermsLabel
            // 
            this.numOfTermsLabel.AutoSize = true;
            this.numOfTermsLabel.Location = new System.Drawing.Point(32, 53);
            this.numOfTermsLabel.Name = "numOfTermsLabel";
            this.numOfTermsLabel.Size = new System.Drawing.Size(144, 25);
            this.numOfTermsLabel.TabIndex = 0;
            this.numOfTermsLabel.Text = "Enter # of terms:";
            // 
            // approxTextLabel
            // 
            this.approxTextLabel.AutoSize = true;
            this.approxTextLabel.Location = new System.Drawing.Point(104, 282);
            this.approxTextLabel.Name = "approxTextLabel";
            this.approxTextLabel.Size = new System.Drawing.Size(0, 25);
            this.approxTextLabel.TabIndex = 1;
            // 
            // approxCalLabel
            // 
            this.approxCalLabel.AutoSize = true;
            this.approxCalLabel.Location = new System.Drawing.Point(154, 378);
            this.approxCalLabel.Name = "approxCalLabel";
            this.approxCalLabel.Size = new System.Drawing.Size(0, 25);
            this.approxCalLabel.TabIndex = 2;
            // 
            // calButton
            // 
            this.calButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calButton.Location = new System.Drawing.Point(139, 120);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(175, 66);
            this.calButton.TabIndex = 3;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(201, 50);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(158, 31);
            this.termsTextBox.TabIndex = 4;
            // 
            // piCalculation
            // 
            this.piCalculation.AutoSize = true;
            this.piCalculation.Location = new System.Drawing.Point(139, 255);
            this.piCalculation.Name = "piCalculation";
            this.piCalculation.Size = new System.Drawing.Size(0, 25);
            this.piCalculation.TabIndex = 5;
            // 
            // termTextLabel
            // 
            this.termTextLabel.AutoSize = true;
            this.termTextLabel.Location = new System.Drawing.Point(63, 203);
            this.termTextLabel.Name = "termTextLabel";
            this.termTextLabel.Size = new System.Drawing.Size(0, 25);
            this.termTextLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(470, 316);
            this.Controls.Add(this.termTextLabel);
            this.Controls.Add(this.piCalculation);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.approxCalLabel);
            this.Controls.Add(this.approxTextLabel);
            this.Controls.Add(this.numOfTermsLabel);
            this.Name = "Form1";
            this.Text = "Approximate Pi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numOfTermsLabel;
        private Label approxTextLabel;
        private Label approxCalLabel;
        private Button calButton;
        private TextBox termsTextBox;
        private Label piCalculation;
        private Label termTextLabel;
    }
}