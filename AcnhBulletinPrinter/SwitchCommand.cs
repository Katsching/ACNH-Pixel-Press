using System.Text;

namespace AcnhBulletinPrinter
{
    public static class SwitchCommand
    {
        private static readonly Encoding Encoder = Encoding.UTF8;
        private static byte[] Encode(string command, bool addrn = true) => Encoder.GetBytes(addrn ? command + "\r\n" : command);
        public static byte[] touchString(string data) => Encode($"touch {data}");
        
        public static byte[] touchHoldString(string data, int time) => Encode($"touchHold {data} {time}");
        public static byte[] SetPollingRate(int pollingRate) => Encode($"configure pollRate {pollingRate}");
        
    }
}