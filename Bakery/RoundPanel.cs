using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bakery
{
    public partial class RoundPanel : Panel
    {
        float roundScale = 1;
        float clientRoundScale = 1;
        Color color = Color.WhiteSmoke;
        Image image = null;
        Color borderColor = Color.Black;
        float borderWidth = 0;
        int imageHeight = 0;

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public float BorderWidth
        {
            get
            {
                return borderWidth;
            }
            set
            {
                borderWidth = value;
                if (borderWidth > Math.Min(this.Width, this.Height))
                {
                    borderWidth = Math.Min(this.Width, this.Height);
                }

                float scale = (this.Width - borderWidth) / (this.Height - borderWidth);
                if (scale < 1 && roundScale > scale)
                {
                    roundScale = scale;
                }
                Invalidate();
            }
        }

        public float ClientRoundScale
        {
            get
            {
                return clientRoundScale;
            }
            set
            {
                clientRoundScale = value;
                if (clientRoundScale < 0)
                {
                    clientRoundScale = 0;
                }
                else if (clientRoundScale > 1)
                {
                    clientRoundScale = 1;
                }

                roundScale = clientRoundScale;
                float scale = (this.Width - borderWidth) / (this.Height - borderWidth);
                if (scale < 1 && roundScale > scale)
                {
                    roundScale = scale;
                }
                Invalidate();
            }
        }

        public float RoundScale
        {
            get
            {
                return roundScale;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                Invalidate();
            }
        }

        public int ImageHeight
        {
            get
            {
                return imageHeight;
            }
            set
            {
                imageHeight = value;
                if (imageHeight < 0)
                {
                    imageHeight = 0;
                }
                Invalidate();
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Invalidate();
            }
        }
        public RoundPanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private GraphicsPath GetGraphicsPath(int imageHeight = 0)
        {
            GraphicsPath gp = new GraphicsPath();
            float diameterArc = (this.Height - borderWidth) * roundScale;
            if (diameterArc > 0)
            {
                gp.AddArc(borderWidth / 2, borderWidth / 2, diameterArc, diameterArc, 180, 90);
                gp.AddArc(this.Width - diameterArc - borderWidth / 2, borderWidth / 2, diameterArc, diameterArc, 270, 90);
                if (imageHeight > 0)
                {
                    gp.AddLine(this.Width - 1, imageHeight, 0, imageHeight);
                    gp.AddLine(borderWidth / 2, imageHeight, borderWidth / 2, borderWidth / 2 + diameterArc / 2);
                }
                else
                {
                    gp.AddArc(this.Width - diameterArc - borderWidth / 2, this.Height - diameterArc - borderWidth / 2, diameterArc, diameterArc, 0, 90);
                    gp.AddArc(borderWidth / 2, this.Height - diameterArc - borderWidth / 2, diameterArc, diameterArc, 90, 90);
                    gp.AddLine(borderWidth / 2, this.Height - diameterArc / 2 - borderWidth, borderWidth / 2, borderWidth / 2 + diameterArc / 2);
                }
            }
            else
            {
                gp.AddRectangle(new RectangleF(borderWidth / 2, borderWidth / 2, this.Width - borderWidth, this.Height - borderWidth));
            }
            return gp;
        }

        private Image GetImage()
        {
            Image displayImage = null;
            int height;
            if (image != null)
            {
                if (imageHeight > 0)
                {
                    height = imageHeight;
                }
                else
                {
                    height = this.Height;
                }

                if (image.Width > this.Width && image.Height > height)
                {
                    displayImage = new Bitmap(image, this.Width, height);
                }
                else if (image.Width > this.Width)
                {
                    displayImage = new Bitmap(image, this.Width, image.Height);
                }
                else if (image.Height > this.Height)
                {
                    displayImage = new Bitmap(image, image.Width, height);
                }
                else
                {
                    displayImage = new Bitmap(image);
                }

                Image bmp = new Bitmap(this.Width, height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(displayImage, (bmp.Width - displayImage.Width) / 2, (bmp.Height - displayImage.Height) / 2);
                }
                displayImage.Dispose();
                displayImage = bmp;
            }
            return displayImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            using (GraphicsPath gp = GetGraphicsPath())
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    pe.Graphics.FillPath(brush, gp);
                }

                if (image != null)
                {
                    using (GraphicsPath imageGp = GetGraphicsPath(imageHeight))
                    {
                        Image displayImage = GetImage();
                        using (TextureBrush brush = new TextureBrush(displayImage))
                        {
                            pe.Graphics.FillPath(brush, imageGp);
                        }
                        displayImage.Dispose();
                    }
                }

                if (borderWidth > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderWidth))
                    {
                        pe.Graphics.DrawPath(pen, gp);
                    }
                }
            }
            base.OnPaint(pe);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            roundScale = clientRoundScale;
            float scale = (this.Width - borderWidth) / (this.Height - borderWidth);
            if (scale < 1 && roundScale > scale)
            {
                roundScale = scale;
            }
            Invalidate();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            Invalidate();
        }
    }
}
