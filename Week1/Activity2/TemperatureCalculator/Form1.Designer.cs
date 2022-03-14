namespace TemperatureCalculator
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
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.farienheitLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.farenheitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(304, 131);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(150, 31);
            this.celsiusTextBox.TabIndex = 0;
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Location = new System.Drawing.Point(21, 131);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(183, 25);
            this.celsiusLabel.TabIndex = 1;
            this.celsiusLabel.Text = "Enter degrees Celsius:";
            // 
            // farienheitLabel
            // 
            this.farienheitLabel.AutoSize = true;
            this.farienheitLabel.Location = new System.Drawing.Point(21, 269);
            this.farienheitLabel.Name = "farienheitLabel";
            this.farienheitLabel.Size = new System.Drawing.Size(155, 25);
            this.farienheitLabel.TabIndex = 2;
            this.farienheitLabel.Text = "degrees Farenheit:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(222, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(329, 48);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Celsius to Farenheit";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(323, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 34);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // farenheitLabel
            // 
            this.farenheitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.farenheitLabel.Location = new System.Drawing.Point(304, 269);
            this.farenheitLabel.Name = "farenheitLabel";
            this.farenheitLabel.Size = new System.Drawing.Size(150, 38);
            this.farenheitLabel.TabIndex = 6;
            this.farenheitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.farenheitLabel.Click += new System.EventHandler(this.farenheitLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 465);
            this.Controls.Add(this.farenheitLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.farienheitLabel);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.celsiusTextBox);
            this.Name = "Form1";
            this.Text = "Celsius to Farenheit Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox celsiusTextBox;
        private Label celsiusLabel;
        private Label farienheitLabel;
        private Label titleLabel;
        private Button calculateButton;
        private Label farenheitLabel;
    }
}