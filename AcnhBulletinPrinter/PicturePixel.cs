using System.Configuration;
using ColorMine.ColorSpaces;

namespace AcnhBulletinPrinter
{
    public class PicturePixel
    {
        public AcnhColor AcnhColor { get; set; }
        public int xPixelCoordinate { get; set; }
        public int YPixelCoordinate { get; set; }

        public PicturePixel(AcnhColor acnhColor, int xPixelCoordinate, int yPixelCoordinate)
        {
            AcnhColor = acnhColor;
            this.xPixelCoordinate = xPixelCoordinate;
            YPixelCoordinate = yPixelCoordinate;
        }
    }
}