using System.Text;

namespace AcnhPixelPress
{
    public static class SwitchCommand
    {
        private static readonly Encoding Encoder = Encoding.UTF8;
        private static byte[] Encode(string command, bool addrn = true) => Encoder.GetBytes(addrn ? command + "\r\n" : command);
        public static byte[] TouchString(string data) => Encode($"touch {data}");
        public static byte[] Version() => Encode("getVersion");
        public static byte[] TouchHoldString(string data, int time) => Encode($"touchHold {data} {time}");
        public static byte[] SetPollingRate(int pollingRate) => Encode($"configure pollRate {pollingRate}");
    }
}