namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardBack = new System.Windows.Forms.PictureBox();
            this.cardFront = new System.Windows.Forms.PictureBox();
            this.frontButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFront)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBack
            // 
            this.cardBack.Image = ((System.Drawing.Image)(resources.GetObject("cardBack.Image")));
            this.cardBack.Location = new System.Drawing.Point(54, 56);
            this.cardBack.Name = "cardBack";
            this.cardBack.Size = new System.Drawing.Size(224, 309);
            this.cardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBack.TabIndex = 0;
            this.cardBack.TabStop = false;
            this.cardBack.Click += new System.EventHandler(this.cardBack_Click);
            // 
            // cardFront
            // 
            this.cardFront.Image = ((System.Drawing.Image)(resources.GetObject("cardFront.Image")));
            this.cardFront.Location = new System.Drawing.Point(493, 56);
            this.cardFront.Name = "cardFront";
            this.cardFront.Size = new System.Drawing.Size(213, 309);
            this.cardFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFront.TabIndex = 1;
            this.cardFront.TabStop = false;
            this.cardFront.Visible = false;
            this.cardFront.Click += new System.EventHandler(this.cardFront_Click);
            // 
            // frontButton
            // 
            this.frontButton.Location = new System.Drawing.Point(111, 394);
            this.frontButton.Name = "frontButton";
            this.frontButton.Size = new System.Drawing.Size(112, 34);
            this.frontButton.TabIndex = 2;
            this.frontButton.Text = "Show Front";
            this.frontButton.UseVisualStyleBackColor = true;
            this.frontButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(542, 394);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 34);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Show Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 590);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.frontButton);
            this.Controls.Add(this.cardFront);
            this.Controls.Add(this.cardBack);
            this.Name = "Form1";
            this.Text = "Card Flip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox cardBack;
        private PictureBox cardFront;
        private Button frontButton;
        private Button backButton;
    }
}