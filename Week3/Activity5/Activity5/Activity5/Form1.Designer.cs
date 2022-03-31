namespace Activity5
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
            this.heading = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.longWordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.voweltextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.LastWordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(157, 66);
            this.heading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(358, 32);
            this.heading.TabIndex = 0;
            this.heading.Text = "Please Select File for Processing:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectButton.Location = new System.Drawing.Point(220, 147);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(174, 49);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Words to lowercase:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTextBox.Location = new System.Drawing.Point(222, 258);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.PlaceholderText = "Lowercase words will appear here.";
            this.outputTextBox.Size = new System.Drawing.Size(310, 128);
            this.outputTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Longest Word: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // longWordTextBox
            // 
            this.longWordTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.longWordTextBox.Location = new System.Drawing.Point(220, 407);
            this.longWordTextBox.Name = "longWordTextBox";
            this.longWordTextBox.Size = new System.Drawing.Size(310, 34);
            this.longWordTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Most vowels:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "First word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Word:";
            // 
            // voweltextBox
            // 
            this.voweltextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voweltextBox.Location = new System.Drawing.Point(218, 472);
            this.voweltextBox.Name = "voweltextBox";
            this.voweltextBox.Size = new System.Drawing.Size(312, 34);
            this.voweltextBox.TabIndex = 12;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstTextBox.Location = new System.Drawing.Point(218, 546);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(320, 34);
            this.firstTextBox.TabIndex = 13;
            this.firstTextBox.TextChanged += new System.EventHandler(this.firstWordTextBox_TextChanged);
            // 
            // LastWordTextBox
            // 
            this.LastWordTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastWordTextBox.Location = new System.Drawing.Point(212, 604);
            this.LastWordTextBox.Name = "LastWordTextBox";
            this.LastWordTextBox.Size = new System.Drawing.Size(320, 34);
            this.LastWordTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 675);
            this.Controls.Add(this.LastWordTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.voweltextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.longWordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.heading);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "File Dialog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label heading;
        private OpenFileDialog openFileDialog1;
        private Button selectButton;
        private Label label1;
        private TextBox outputTextBox;
        private Label label2;
        private TextBox longWordTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox voweltextBox;
        private TextBox firstTextBox;
        private TextBox LastWordTextBox;
    }
}