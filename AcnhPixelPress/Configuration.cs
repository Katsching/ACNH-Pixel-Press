using ColorMine.ColorSpaces;

namespace AcnhPixelPress
{
    public class Configuration
    {
        public string IP { get; set; }
        public Rgb Red { get; set; }
        public Rgb Blue { get; set; }
        public Rgb Yellow { get; set; }
        
        public Rgb Black { get; set; }
        
        public Rgb White { get; set; }
        
        public int PollingRate { get; set; }
    }
}