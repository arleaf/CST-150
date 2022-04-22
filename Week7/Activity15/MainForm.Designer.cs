namespace LuckyNumber
{
    partial class MainForm
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
            this.favColorBox = new System.Windows.Forms.ComboBox();
            this.birthDayBox = new System.Windows.Forms.ComboBox();
            this.birthMonthBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.findLuckyNumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Your Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Enter Your Birth Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Enter Birth Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please Select Favorite Color:";
            // 
            // favColorBox
            // 
            this.favColorBox.FormattingEnabled = true;
            this.favColorBox.Items.AddRange(new object[] {
            "Pink",
            "Blue",
            "Green",
            "Red",
            "Purple"});
            this.favColorBox.Location = new System.Drawing.Point(207, 178);
            this.favColorBox.Name = "favColorBox";
            this.favColorBox.Size = new System.Drawing.Size(162, 23);
            this.favColorBox.TabIndex = 4;
            // 
            // birthDayBox
            // 
            this.birthDayBox.FormattingEnabled = true;
            this.birthDayBox.Location = new System.Drawing.Point(207, 133);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(162, 23);
            this.birthDayBox.TabIndex = 5;
            // 
            // birthMonthBox
            // 
            this.birthMonthBox.FormattingEnabled = true;
            this.birthMonthBox.Items.AddRange(new object[] {
            "Janurary",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthMonthBox.Location = new System.Drawing.Point(207, 86);
            this.birthMonthBox.Name = "birthMonthBox";
            this.birthMonthBox.Size = new System.Drawing.Size(162, 23);
            this.birthMonthBox.TabIndex = 6;
            this.birthMonthBox.SelectedIndexChanged += new System.EventHandler(this.birthMonthBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(207, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 23);
            this.nameTextBox.TabIndex = 7;
            // 
            // findLuckyNumButton
            // 
            this.findLuckyNumButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findLuckyNumButton.Location = new System.Drawing.Point(132, 230);
            this.findLuckyNumButton.Name = "findLuckyNumButton";
            this.findLuckyNumButton.Size = new System.Drawing.Size(131, 23);
            this.findLuckyNumButton.TabIndex = 8;
            this.findLuckyNumButton.Text = "Find Lucky Number!";
            this.findLuckyNumButton.UseVisualStyleBackColor = true;
            this.findLuckyNumButton.Click += new System.EventHandler(this.findLuckyNumButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 265);
            this.Controls.Add(this.findLuckyNumButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.birthMonthBox);
            this.Controls.Add(this.birthDayBox);
            this.Controls.Add(this.favColorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Lucky Number";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox birthDayBox;
        private ComboBox birthMonthBox;
        private Button findLuckyNumButton;
        public ComboBox favColorBox;
        public TextBox nameTextBox;
    }
}