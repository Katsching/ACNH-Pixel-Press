namespace AcnhPixelPress
{
    public class Controller
    {
        public readonly Sysbot Bot = new Sysbot();

        public Controller()
        {
        }

        public bool Connect(string ip, string port)
        {
            if (!int.TryParse(port, out var p))
                p = 6000;
            Bot.Connect(ip, p);
            return true;
        }
    }
}