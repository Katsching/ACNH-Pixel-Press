using System.ComponentModel;

namespace AcnhPixelPress
{
    partial class ImageScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.PreviewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.PreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewImage
            // 
            this.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewImage.Location = new System.Drawing.Point(12, 12);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(760, 371);
            this.PreviewImage.TabIndex = 0;
            this.PreviewImage.TabStop = false;
            // 
            // ImageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 395);
            this.Controls.Add(this.PreviewImage);
            this.Name = "ImageScreen";
            this.Text = "ImageScreen";
            ((System.ComponentModel.ISupportInitialize) (this.PreviewImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox PreviewImage;

        #endregion
    }
}