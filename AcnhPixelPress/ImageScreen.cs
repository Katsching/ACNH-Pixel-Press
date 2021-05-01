using System.Drawing;
using System.Windows.Forms;

namespace AcnhPixelPress
{
    public partial class ImageScreen : Form
    {
        public ImageScreen()
        {
            InitializeComponent();
        }
        
        public void SetPreview(Image image)
        {
            PreviewImage.SizeMode = PictureBoxSizeMode.AutoSize;
            PreviewImage.Image = image;
        }
    }
}