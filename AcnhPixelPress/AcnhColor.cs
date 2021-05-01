using ColorMine.ColorSpaces;

namespace AcnhPixelPress
{
    public class AcnhColor
    {
        public string Name { get; set; }

        public Rgb MatchingColor { get; set; }
        
        public Rgb OriginalColor { get; set; }

        public int ColorXPosition { get; set; }

        public int ColorYPosition { get; set; }

        public AcnhColor(string name, Rgb matchingColor, Rgb originalColor, int colorXPosition, int colorYPosition)
        {
            Name = name;
            MatchingColor = matchingColor;
            OriginalColor = originalColor;
            ColorXPosition = colorXPosition;
            ColorYPosition = colorYPosition;
        }

        public AcnhColor()
        {
        }
    }
}