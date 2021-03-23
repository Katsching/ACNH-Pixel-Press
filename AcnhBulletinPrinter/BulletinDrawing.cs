using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Comparisons;

namespace AcnhBulletinPrinter
{
    public static class BulletinDrawing
    {
        private static Controller _sysBot;

        private static AcnhColor _blueColor;
        private static AcnhColor _redColor;
        private static AcnhColor _yellowColor;
        private static AcnhColor _blackColor;
        private static AcnhColor _whiteColor;
        private static readonly List<AcnhColor> RgbList = new();

        public static string ConnectSysbot(string ipAddress, int pollingRate)
        {
            string message;
            _sysBot = new Controller();
            try
            {
                _sysBot.Connect(ipAddress, "6000");
                message = "Connected successfully";
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            _sysBot.Bot.sendPollRate(pollingRate);
            return message;
        }

        public static void SetColors(Rgb Red, Rgb Blue, Rgb Yellow, Rgb Black, Rgb White)
        {
            _blueColor = new AcnhColor("blue", Blue, 609, 80);
            _redColor = new AcnhColor("red", Red, 670, 80);
            _yellowColor = new AcnhColor("yellow", Yellow, 730, 80);
            _blackColor = new AcnhColor("black", Black, 540, 80);
            _whiteColor = new AcnhColor("white", White, 0, 0);
            AcnhColor[] colorRange = {_blueColor, _redColor, _yellowColor, _blackColor, _whiteColor};
            RgbList.AddRange(colorRange);
        }
        
        public static async void ParseImage(string imagePath, int scale)
        {
            var img = Image.FromFile(imagePath);
            var resized = (Bitmap) FixedSize(img, 760 / scale, 460 / scale);
            var previousColor = "white";
            for (var xCoord = 0; xCoord < 760; xCoord += scale)
            {
                for (var yCoord = 0; yCoord < 460; yCoord += scale)
                {
                    Color pixelColor = resized.GetPixel(xCoord / scale, yCoord / scale);

                    var currentPixel = new Rgb {R = pixelColor.R, G = pixelColor.G, B = pixelColor.B};
                    var smallestDistance = double.MaxValue;
                    var chosenColor = new AcnhColor();
                    foreach (var currentColor in RgbList)
                    {
                        var deltaE = currentPixel.Compare(currentColor.RgbColor, new Cie1976Comparison());
                        if (!(deltaE < smallestDistance)) continue;
                        smallestDistance = deltaE;
                        chosenColor = currentColor;
                    }

                    var x = xCoord + 259;
                    var y = yCoord + 168;

                    switch (chosenColor.Name)
                    {
                        case "black":
                            // DrawPoint(BlackColor, x, y, previousColor);
                            DrawPoint(_blackColor, x, y);
                            previousColor = chosenColor.Name;
                            break;
                        case "blue":
                            DrawPoint(_blueColor, x, y);
                            previousColor = chosenColor.Name;
                            break;
                        case "red":
                            DrawPoint(_redColor, x, y);
                            previousColor = chosenColor.Name;
                            break;
                        case "yellow":
                            DrawPoint(_yellowColor, x, y);
                            previousColor = chosenColor.Name;
                            break;
                    }
                }
            }
        }

        /**
         * No additional color press
         */
        private static void DrawPointPrevious(AcnhColor color, int x, int y, string previousColor)
        {
            if (!previousColor.Equals(color.Name))
            {
                TouchPixel(color.ColorXPosition, color.ColorYPosition);
            }

            TouchPixel(x, y);
        }

        private static void DrawPoint(AcnhColor color, int x, int y)
        {
            TouchPixel(color.ColorXPosition, color.ColorYPosition);
            TouchPixel(x, y);
        }

        private static void TouchPixel(int x, int y)
        {
            _sysBot.Bot.touch($"{x} {y}");
        }

        /**
         * Fix ratio of the input picture
         */
        private static Image FixedSize(Image imgPhoto, int width, int height)
        {
            var sourceWidth = imgPhoto.Width;
            var sourceHeight = imgPhoto.Height;
            var sourceX = 0;
            var sourceY = 0;
            var destX = 0;
            var destY = 0;

            float nPercent;
            float nPercentW;
            float nPercentH;

            nPercentW = (width / (float) sourceWidth);
            nPercentH = (height / (float) sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = Convert.ToInt16((width -
                                         (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = Convert.ToInt16((height -
                                         (sourceHeight * nPercent)) / 2);
            }

            var destWidth = (int) (sourceWidth * nPercent);
            var destHeight = (int) (sourceHeight * nPercent);

            var bmPhoto = new Bitmap(width, height,
                PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                imgPhoto.VerticalResolution);

            var grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
    }
}