using System.Net.Sockets;

namespace AcnhPixelPress
{
    public class Sysbot
    {
        private string IP = "";
        private int Port = 6000;
        private Socket Connection = new Socket(SocketType.Stream, ProtocolType.Tcp);
        private bool Connected { get; set; }
        public int MaximumTransferSize { get { return 8192; } }
        private int defaultSleepTime = 100;

        private readonly object _sync = new object();

        public void Connect(string ip, int port)
        {
            IP = ip;
            Port = port;
            lock (_sync)
            {
                Connection = new Socket(SocketType.Stream, ProtocolType.Tcp);
                Connection.Connect(IP, Port);
                Connected = true;
            }
        }

        public void Disconnect()
        {
            lock (_sync)
            {
                Connection.Disconnect(false);
                Connected = false;
            }
        }
        
        private int ReadInternal(byte[] buffer)
        {
            int br = Connection.Receive(buffer, 0, 1, SocketFlags.None);
            while (buffer[br - 1] != (byte)'\n')
                br += Connection.Receive(buffer, br, 1, SocketFlags.None);
            return br;
        }

        private int SendInternal(byte[] buffer) => Connection.Send(buffer);

        public int Read(byte[] buffer)
        {
            lock (_sync)
                return ReadInternal(buffer);
        }
        
        public void sendPollRate(int pollingRate)
        {
            SendInternal(SwitchCommand.SetPollingRate(pollingRate));
        }
        
        public void touch(string data)
        {
            SendInternal(SwitchCommand.touchString(data));
        }
        
        public void touchHold(string data, int time)
        {
            SendInternal(SwitchCommand.touchHoldString(data, time));
        }
    }
}