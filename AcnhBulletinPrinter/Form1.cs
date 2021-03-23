using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorMine.ColorSpaces;
using Newtonsoft.Json;

namespace AcnhBulletinPrinter
{
    public partial class Form1 : Form
    {
        private string _imagePath = "";
        private Rgb _red;
        private Rgb _blue;
        private Rgb _yellow;
        private Rgb _black;
        private Rgb _white;
        private int _pollingRate;
        private CancellationTokenSource source;
        
        public Form1()
        {
            InitializeComponent();
            CheckConfig();
        }
        
        private void CheckConfig()
        {
            var configPath = @AppDomain.CurrentDomain.BaseDirectory + "\\config";
            Directory.CreateDirectory(configPath);
            var folderPath = configPath + "\\config.json";
        
            var scales = new[] {2, 4, 5};
            foreach(var scale in scales )
            {
                scaleCombobox.Items.Add(scale);
            }
            scaleCombobox.SelectedIndex= 1;
            
            if (File.Exists(folderPath))
            {
                var config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(folderPath));
                if (config == null) return;
                ipTextbox.Text = config.IP;
                _red = config.Red;
                _blue = config.Blue;
                _yellow = config.Yellow;
                _black = config.Black;
                _white = config.White;
                _pollingRate = config.PollingRate;
            }
            else
            {
                _red = new() {R = 240, G = 128, B = 128};
                _blue = new() {R = 135, G = 206, B = 250};
                _yellow = new() {R = 255, G = 255, B = 0};
                _black = new() {R = 0, G = 0, B = 0};
                _white = new() {R = 255, G = 255, B = 255};
                var config = new Configuration
                {
                    IP = "192.168.0.1", 
                    Red = _red, Blue = _blue, Yellow = _yellow, Black = _black, White = _white,
                    PollingRate = 31
                };
                ipTextbox.Text = config.IP;
                _pollingRate = config.PollingRate;
                var json = JsonConvert.SerializeObject(config);
                File.WriteAllText(folderPath, json);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = BulletinDrawing.ConnectSysbot(ipTextbox.Text, _pollingRate);
                AddLogText(connectionString);
            }
            catch (SocketException exception)
            {
                AddLogText(exception.GetType().ToString());
            }
          

        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            BulletinDrawing bulletinDrawing = new BulletinDrawing();
            bulletinDrawing.SetColors(_red, _blue, _yellow, _black, _white);

            source = new CancellationTokenSource();
            var token = source.Token;
            
            var task = Task.Run(() => bulletinDrawing.ParseImage(_imagePath, int.Parse(scaleCombobox.Text), token), token);

            AddLogText("Drawing, please don't do anything on your console until it is finished.");
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            var choofdlog = new OpenFileDialog();
            const string filter = "image files (*.jpg, *.png)|*.jpg; *png";
            choofdlog.Filter = filter;
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() != DialogResult.OK) return;
            _imagePath = choofdlog.FileName;
            string fileName = Path.GetFileName(_imagePath);
            AddLogText($"added {fileName}");
        }

        private void AddLogText(string text)
        {
            var sb = new StringBuilder(logTextbox.Text);
            sb.AppendLine(text);
            logTextbox.Text = sb.ToString();
        }
    }
}