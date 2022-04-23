namespace Milestone4
{
    partial class AddForm
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
            this.addRemoveLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNametextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.storagecomboBox = new System.Windows.Forms.ComboBox();
            this.brandcomboBox = new System.Windows.Forms.ComboBox();
            this.carriercomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRemoveLabel
            // 
            this.addRemoveLabel.AutoSize = true;
            this.addRemoveLabel.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRemoveLabel.Location = new System.Drawing.Point(196, 43);
            this.addRemoveLabel.Name = "addRemoveLabel";
            this.addRemoveLabel.Size = new System.Drawing.Size(115, 25);
            this.addRemoveLabel.TabIndex = 0;
            this.addRemoveLabel.Text = "Add Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(120, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Storage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(120, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(120, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Brand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(120, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Carrier:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 6;
            // 
            // phoneNametextBox
            // 
            this.phoneNametextBox.Location = new System.Drawing.Point(255, 97);
            this.phoneNametextBox.Name = "phoneNametextBox";
            this.phoneNametextBox.Size = new System.Drawing.Size(163, 23);
            this.phoneNametextBox.TabIndex = 7;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(255, 147);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(163, 23);
            this.colorTextBox.TabIndex = 8;
            // 
            // storagecomboBox
            // 
            this.storagecomboBox.FormattingEnabled = true;
            this.storagecomboBox.Items.AddRange(new object[] {
            "64GB",
            "128GB",
            "256GB"});
            this.storagecomboBox.Location = new System.Drawing.Point(255, 201);
            this.storagecomboBox.Name = "storagecomboBox";
            this.storagecomboBox.Size = new System.Drawing.Size(163, 23);
            this.storagecomboBox.TabIndex = 9;
            // 
            // brandcomboBox
            // 
            this.brandcomboBox.FormattingEnabled = true;
            this.brandcomboBox.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "LG",
            "Motorola"});
            this.brandcomboBox.Location = new System.Drawing.Point(255, 250);
            this.brandcomboBox.Name = "brandcomboBox";
            this.brandcomboBox.Size = new System.Drawing.Size(163, 23);
            this.brandcomboBox.TabIndex = 10;
            // 
            // carriercomboBox
            // 
            this.carriercomboBox.FormattingEnabled = true;
            this.carriercomboBox.Items.AddRange(new object[] {
            "AT&T",
            "Tmoblie",
            "MetroPCS",
            "Verizon"});
            this.carriercomboBox.Location = new System.Drawing.Point(255, 300);
            this.carriercomboBox.Name = "carriercomboBox";
            this.carriercomboBox.Size = new System.Drawing.Size(163, 23);
            this.carriercomboBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(264, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carriercomboBox);
            this.Controls.Add(this.brandcomboBox);
            this.Controls.Add(this.storagecomboBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.phoneNametextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addRemoveLabel);
            this.Name = "AddForm";
            this.Text = "Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public Label addRemoveLabel;
        private Button button1;
        private Button exitButton;
        public TextBox phoneNametextBox;
        public TextBox colorTextBox;
        public ComboBox storagecomboBox;
        public ComboBox brandcomboBox;
        public ComboBox carriercomboBox;
    }
}