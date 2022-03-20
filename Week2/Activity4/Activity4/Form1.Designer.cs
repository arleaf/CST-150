namespace Activity4
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.secondsNum = new System.Windows.Forms.Label();
            this.timeCalculator = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(423, 139);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(278, 31);
            this.inputTextBox.TabIndex = 0;
            // 
            // secondsNum
            // 
            this.secondsNum.AutoSize = true;
            this.secondsNum.Location = new System.Drawing.Point(180, 142);
            this.secondsNum.Name = "secondsNum";
            this.secondsNum.Size = new System.Drawing.Size(217, 25);
            this.secondsNum.TabIndex = 1;
            this.secondsNum.Text = "Enter number of Seconds:";
            // 
            // timeCalculator
            // 
            this.timeCalculator.AutoSize = true;
            this.timeCalculator.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeCalculator.Location = new System.Drawing.Point(315, 41);
            this.timeCalculator.Name = "timeCalculator";
            this.timeCalculator.Size = new System.Drawing.Size(254, 45);
            this.timeCalculator.TabIndex = 2;
            this.timeCalculator.Text = "Time Calculator";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(324, 303);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(73, 25);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output:";
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Location = new System.Drawing.Point(423, 303);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(278, 27);
            this.displayLabel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateButton.Location = new System.Drawing.Point(338, 218);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(231, 51);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Equivlent";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(382, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(909, 579);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.timeCalculator);
            this.Controls.Add(this.secondsNum);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private Label secondsNum;
        private Label timeCalculator;
        private Label Output;
        private Label displayLabel;
        private Button calculateButton;
        private Button exitButton;
    }
}