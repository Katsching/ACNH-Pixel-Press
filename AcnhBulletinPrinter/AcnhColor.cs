using ColorMine.ColorSpaces;

namespace AcnhBulletinPrinter
{
    public class AcnhColor
    {
        public string Name { get; set; }

        public Rgb RgbColor { get; set; }

        public int ColorXPosition { get; set; }

        public int ColorYPosition { get; set; }

        public AcnhColor(string name, Rgb rgbColor, int colorXPosition, int colorYPosition)
        {
            Name = name;
            RgbColor = rgbColor;
            ColorXPosition = colorXPosition;
            ColorYPosition = colorYPosition;
        }

        public AcnhColor()
        {
        }
    }
}