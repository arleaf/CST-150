namespace RollingDice
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
            this.RollButton = new System.Windows.Forms.Button();
            this.dice1Label = new System.Windows.Forms.Label();
            this.dice2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RollButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollButton.Location = new System.Drawing.Point(150, 180);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(110, 28);
            this.RollButton.TabIndex = 0;
            this.RollButton.Text = "Roll Dice!";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // dice1Label
            // 
            this.dice1Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dice1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice1Label.Location = new System.Drawing.Point(45, 35);
            this.dice1Label.Name = "dice1Label";
            this.dice1Label.Size = new System.Drawing.Size(120, 120);
            this.dice1Label.TabIndex = 1;
            this.dice1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice2Label
            // 
            this.dice2Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dice2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice2Label.Location = new System.Drawing.Point(254, 35);
            this.dice2Label.Name = "dice2Label";
            this.dice2Label.Size = new System.Drawing.Size(120, 120);
            this.dice2Label.TabIndex = 2;
            this.dice2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(404, 220);
            this.Controls.Add(this.dice2Label);
            this.Controls.Add(this.dice1Label);
            this.Controls.Add(this.RollButton);
            this.Name = "Form1";
            this.Text = "Dice Roll";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RollButton;
        private Label dice1Label;
        private Label dice2Label;
    }
}