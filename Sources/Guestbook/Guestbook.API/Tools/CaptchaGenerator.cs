namespace Guestbook.API.Tools
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System;

    public class CaptchaGenerator : IDisposable
    {
        private readonly Random random = new Random();

        private string text;
        private int width;
        private int height;
        private Bitmap image;
        
        public CaptchaGenerator(int width, int height)
        {
            this.text = this.GenerateCode();
            this.width = width;
            this.height = height;
            this.Generate();
        }

        public string Text
        {
            get
            {
                return this.text;
            }
        }

        public Bitmap Image
        {
            get
            {
                return this.image;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                this.image.Dispose();
        }

        private void Generate()
        {
            var bitmap = new Bitmap(this.width, this.height, PixelFormat.Format32bppArgb);

            var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, this.width, this.height);
            var hatchBrush = new HatchBrush(HatchStyle.SmallConfetti, Color.LightGray, Color.White);

            graphics.FillRectangle(hatchBrush, rect);

            SizeF size;
            float fontSize = rect.Height + 1;
            Font font;

            do
            {
                fontSize--;
                font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
                size = graphics.MeasureString(this.text, font);
            } while (size.Width > rect.Width);

            var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var path = new GraphicsPath();

            //path.AddString(this.text, font.FontFamily, (int) font.Style, 
            //    font.Size, rect, format);

            path.AddString(this.text, font.FontFamily, (int)font.Style, 75, rect, format);
            float v = 4F;
            PointF[] points = 
            {
                new PointF(this.random.Next(rect.Width) / v, this.random.Next(
                   rect.Height) / v),
                new PointF(rect.Width - this.random.Next(rect.Width) / v, 
                    this.random.Next(rect.Height) / v),
                new PointF(this.random.Next(rect.Width) / v, 
                    rect.Height - this.random.Next(rect.Height) / v),
                new PointF(rect.Width - this.random.Next(rect.Width) / v,
                    rect.Height - this.random.Next(rect.Height) / v)
            };
            
            var matrix = new Matrix();
            matrix.Translate(0F, 0F);
            path.Warp(points, rect, matrix, WarpMode.Perspective, 0F);
            hatchBrush = new HatchBrush(HatchStyle.Percent10, Color.Black, Color.SkyBlue);
            graphics.FillPath(hatchBrush, path);
            int m = Math.Max(rect.Width, rect.Height);
            for (int i = 0; i < (int)(rect.Width * rect.Height / 30F); i++)
            {
                int x = this.random.Next(rect.Width);
                int y = this.random.Next(rect.Height);
                int w = this.random.Next(m / 50);
                int h = this.random.Next(m / 50);
                graphics.FillEllipse(hatchBrush, x, y, w, h);
            }

            font.Dispose();
            hatchBrush.Dispose();
            graphics.Dispose();

            this.image = bitmap;
        }

        private string GenerateCode()
        {
            var randoizer = new Random();
            string s = "";
            for (int j = 0; j < 5; j++)
            {
                int i = randoizer.Next(3);
                int ch;
                switch (i)
                {
                    case 1:
                        ch = randoizer.Next(0, 9);
                        s = s + ch.ToString();
                        break;
                    case 2:
                        ch = randoizer.Next(65, 90);
                        s = s + Convert.ToChar(ch).ToString();
                        break;
                    case 3:
                        ch = randoizer.Next(97, 122);
                        s = s + Convert.ToChar(ch).ToString();
                        break;
                    default:
                        ch = randoizer.Next(97, 122);
                        s = s + Convert.ToChar(ch).ToString();
                        break;
                }
                randoizer.NextDouble();
                randoizer.Next(100, 1999);
            }
            return s;
        }
    }
}