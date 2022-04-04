namespace CalculateCalories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateFromFatButton = new System.Windows.Forms.Button();
            this.calculateFromCarbButton = new System.Windows.Forms.Button();
            this.carbGramsTextBox = new System.Windows.Forms.TextBox();
            this.fatGramsTextBox = new System.Windows.Forms.TextBox();
            this.fatCaloriesLabel = new System.Windows.Forms.Label();
            this.carbCaloriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Fat grams:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Carb grams: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories from Fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calories from Carbs:";
            // 
            // calculateFromFatButton
            // 
            this.calculateFromFatButton.Location = new System.Drawing.Point(90, 137);
            this.calculateFromFatButton.Name = "calculateFromFatButton";
            this.calculateFromFatButton.Size = new System.Drawing.Size(125, 23);
            this.calculateFromFatButton.TabIndex = 5;
            this.calculateFromFatButton.Text = "Calculate Calories";
            this.calculateFromFatButton.UseVisualStyleBackColor = true;
            this.calculateFromFatButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculateFromCarbButton
            // 
            this.calculateFromCarbButton.Location = new System.Drawing.Point(90, 299);
            this.calculateFromCarbButton.Name = "calculateFromCarbButton";
            this.calculateFromCarbButton.Size = new System.Drawing.Size(125, 23);
            this.calculateFromCarbButton.TabIndex = 6;
            this.calculateFromCarbButton.Text = "Calculate Calories";
            this.calculateFromCarbButton.UseVisualStyleBackColor = true;
            this.calculateFromCarbButton.Click += new System.EventHandler(this.calculateFromCarbButton_Click);
            // 
            // carbGramsTextBox
            // 
            this.carbGramsTextBox.Location = new System.Drawing.Point(155, 251);
            this.carbGramsTextBox.Name = "carbGramsTextBox";
            this.carbGramsTextBox.Size = new System.Drawing.Size(100, 23);
            this.carbGramsTextBox.TabIndex = 7;
            // 
            // fatGramsTextBox
            // 
            this.fatGramsTextBox.Location = new System.Drawing.Point(155, 90);
            this.fatGramsTextBox.Name = "fatGramsTextBox";
            this.fatGramsTextBox.Size = new System.Drawing.Size(100, 23);
            this.fatGramsTextBox.TabIndex = 8;
            // 
            // fatCaloriesLabel
            // 
            this.fatCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatCaloriesLabel.Location = new System.Drawing.Point(203, 180);
            this.fatCaloriesLabel.Name = "fatCaloriesLabel";
            this.fatCaloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.fatCaloriesLabel.TabIndex = 9;
            // 
            // carbCaloriesLabel
            // 
            this.carbCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbCaloriesLabel.Location = new System.Drawing.Point(203, 337);
            this.carbCaloriesLabel.Name = "carbCaloriesLabel";
            this.carbCaloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.carbCaloriesLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 395);
            this.Controls.Add(this.carbCaloriesLabel);
            this.Controls.Add(this.fatCaloriesLabel);
            this.Controls.Add(this.fatGramsTextBox);
            this.Controls.Add(this.carbGramsTextBox);
            this.Controls.Add(this.calculateFromCarbButton);
            this.Controls.Add(this.calculateFromFatButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculate Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button calculateFromFatButton;
        private Button calculateFromCarbButton;
        private TextBox carbGramsTextBox;
        private TextBox fatGramsTextBox;
        private Label fatCaloriesLabel;
        private Label carbCaloriesLabel;
    }
}