namespace AcnhPixelPress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.densityCombobox = new System.Windows.Forms.ComboBox();
            this.resizeCombobox = new System.Windows.Forms.ComboBox();
            this.resizeLabel = new System.Windows.Forms.Label();
            this.startXLabel = new System.Windows.Forms.Label();
            this.startXTextbox = new System.Windows.Forms.TextBox();
            this.startYLabel = new System.Windows.Forms.Label();
            this.startYTextbox = new System.Windows.Forms.TextBox();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.blackWhiteCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.previewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(211, 89);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(123, 26);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(29, 121);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(453, 204);
            this.logTextbox.TabIndex = 1;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(340, 89);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(68, 26);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(211, 61);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(123, 22);
            this.ipTextbox.TabIndex = 3;
            // 
            // densityLabel
            // 
            this.densityLabel.Location = new System.Drawing.Point(29, 334);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(66, 23);
            this.densityLabel.TabIndex = 5;
            this.densityLabel.Text = "Density";
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(29, 61);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(80, 54);
            this.imageButton.TabIndex = 7;
            this.imageButton.Text = "Image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Go to the bulletin board, create a post and select the brush size. Then load your" + " image, connect to your ip address and press draw.\r\n";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(414, 89);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(68, 26);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // densityCombobox
            // 
            this.densityCombobox.FormattingEnabled = true;
            this.densityCombobox.Location = new System.Drawing.Point(101, 331);
            this.densityCombobox.Name = "densityCombobox";
            this.densityCombobox.Size = new System.Drawing.Size(48, 24);
            this.densityCombobox.TabIndex = 10;
            this.densityCombobox.SelectedIndexChanged += new System.EventHandler(this.densityCombobox_SelectedIndexChanged);
            // 
            // resizeCombobox
            // 
            this.resizeCombobox.FormattingEnabled = true;
            this.resizeCombobox.Location = new System.Drawing.Point(217, 331);
            this.resizeCombobox.Name = "resizeCombobox";
            this.resizeCombobox.Size = new System.Drawing.Size(60, 24);
            this.resizeCombobox.TabIndex = 11;
            this.resizeCombobox.SelectedIndexChanged += new System.EventHandler(this.resizeCombobox_SelectedIndexChanged);
            // 
            // resizeLabel
            // 
            this.resizeLabel.Location = new System.Drawing.Point(155, 334);
            this.resizeLabel.Name = "resizeLabel";
            this.resizeLabel.Size = new System.Drawing.Size(57, 23);
            this.resizeLabel.TabIndex = 12;
            this.resizeLabel.Text = "Resize";
            // 
            // startXLabel
            // 
            this.startXLabel.Location = new System.Drawing.Point(283, 334);
            this.startXLabel.Name = "startXLabel";
            this.startXLabel.Size = new System.Drawing.Size(51, 23);
            this.startXLabel.TabIndex = 13;
            this.startXLabel.Text = "StartX";
            // 
            // startXTextbox
            // 
            this.startXTextbox.Location = new System.Drawing.Point(340, 331);
            this.startXTextbox.Multiline = true;
            this.startXTextbox.Name = "startXTextbox";
            this.startXTextbox.Size = new System.Drawing.Size(40, 24);
            this.startXTextbox.TabIndex = 14;
            // 
            // startYLabel
            // 
            this.startYLabel.Location = new System.Drawing.Point(386, 334);
            this.startYLabel.Name = "startYLabel";
            this.startYLabel.Size = new System.Drawing.Size(50, 23);
            this.startYLabel.TabIndex = 15;
            this.startYLabel.Text = "StartY";
            // 
            // startYTextbox
            // 
            this.startYTextbox.Location = new System.Drawing.Point(442, 331);
            this.startYTextbox.Multiline = true;
            this.startYTextbox.Name = "startYTextbox";
            this.startYTextbox.Size = new System.Drawing.Size(40, 24);
            this.startYTextbox.TabIndex = 16;
            // 
            // previewImage
            // 
            this.previewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImage.Location = new System.Drawing.Point(115, 61);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(90, 54);
            this.previewImage.TabIndex = 17;
            this.previewImage.TabStop = false;
            // 
            // blackWhiteCheckbox
            // 
            this.blackWhiteCheckbox.Location = new System.Drawing.Point(340, 59);
            this.blackWhiteCheckbox.Name = "blackWhiteCheckbox";
            this.blackWhiteCheckbox.Size = new System.Drawing.Size(131, 24);
            this.blackWhiteCheckbox.TabIndex = 18;
            this.blackWhiteCheckbox.Text = "Black && White";
            this.blackWhiteCheckbox.UseVisualStyleBackColor = true;
            this.blackWhiteCheckbox.CheckedChanged += new System.EventHandler(this.blackWhiteCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 373);
            this.Controls.Add(this.blackWhiteCheckbox);
            this.Controls.Add(this.previewImage);
            this.Controls.Add(this.startYTextbox);
            this.Controls.Add(this.startYLabel);
            this.Controls.Add(this.startXTextbox);
            this.Controls.Add(this.startXLabel);
            this.Controls.Add(this.resizeLabel);
            this.Controls.Add(this.resizeCombobox);
            this.Controls.Add(this.densityCombobox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ACNH Bulletin Printer";
            ((System.ComponentModel.ISupportInitialize) (this.previewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox blackWhiteCheckbox;

        private System.Windows.Forms.PictureBox previewImage;

        private System.Windows.Forms.TextBox startXTextbox;
        private System.Windows.Forms.Label startYLabel;
        private System.Windows.Forms.TextBox startYTextbox;

        private System.Windows.Forms.Label startXLabel;

        private System.Windows.Forms.ComboBox resizeCombobox;
        private System.Windows.Forms.Label resizeLabel;

        private System.Windows.Forms.ComboBox densityCombobox;

        private System.Windows.Forms.Button stopButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button imageButton;

        private System.Windows.Forms.Label densityLabel;

        private System.Windows.Forms.TextBox ipTextbox;

        private System.Windows.Forms.Button drawButton;

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox logTextbox;

        #endregion
    }
}