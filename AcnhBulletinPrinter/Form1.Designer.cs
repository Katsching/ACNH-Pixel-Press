namespace AcnhBulletinPrinter
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scaleCombobox = new System.Windows.Forms.ComboBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(187, 105);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(81, 26);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(62, 137);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(296, 188);
            this.logTextbox.TabIndex = 1;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(274, 105);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(84, 26);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(187, 77);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(121, 22);
            this.ipTextbox.TabIndex = 3;
            // 
            // scaleLabel
            // 
            this.scaleLabel.Location = new System.Drawing.Point(62, 331);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(48, 23);
            this.scaleLabel.TabIndex = 5;
            this.scaleLabel.Text = "scale";
            // 
            // scaleCombobox
            // 
            this.scaleCombobox.FormattingEnabled = true;
            this.scaleCombobox.Location = new System.Drawing.Point(112, 331);
            this.scaleCombobox.Name = "scaleCombobox";
            this.scaleCombobox.Size = new System.Drawing.Size(50, 24);
            this.scaleCombobox.TabIndex = 6;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(62, 77);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(119, 54);
            this.imageButton.TabIndex = 7;
            this.imageButton.Text = "Image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 53);
            this.label1.TabIndex = 8;
            this.label1.Text = "Go to the bulletin board, create a post and select the brush size. Then load your" + " image, connect to your ip address and press draw.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.scaleCombobox);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "ACNH Bulletin Printer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button imageButton;

        private System.Windows.Forms.ComboBox scaleCombobox;

        private System.Windows.Forms.Label scaleLabel;

        private System.Windows.Forms.TextBox ipTextbox;

        private System.Windows.Forms.Button drawButton;

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox logTextbox;

        #endregion
    }
}