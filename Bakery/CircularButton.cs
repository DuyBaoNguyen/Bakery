using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Bakery
{
    public partial class CircularButton : Button
    {
        Color color = Color.Silver;
        Color mouseEnterColor = Color.Black;
        Image image = null;
        bool mouseEnter = false;
        int radius = 0;
        Color borderColor = Color.Black;
        float borderWidth = 0;

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
                Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        public Color MouseEnterColor
        {
            get
            {
                return mouseEnterColor;
            }
            set
            {
                mouseEnterColor = value;
                Invalidate();
            }
        }

        public Image CenterImage
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

        private Image GetImage()
        {
            Image displayImage = null;
            if (image != null)
            {
                if (image.Width > this.Width && image.Height > this.Height)
                {
                    displayImage = new Bitmap(image, this.Width, this.Height);
                }
                else if (image.Width > this.Width)
                {
                    displayImage = new Bitmap(image, this.Width, image.Height);
                }
                else if (image.Height > this.Height)
                {
                    displayImage = new Bitmap(image, image.Width, this.Height);
                }
                else
                {
                    displayImage = new Bitmap(image);
                }

                Image bmp = new Bitmap(this.Width, this.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(displayImage, (bmp.Width - displayImage.Width) / 2, (bmp.Height - displayImage.Height) / 2);
                }
                displayImage.Dispose();
                displayImage = bmp;
            }
            return displayImage;
        }

        public CircularButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            using (SolidBrush brush = new SolidBrush(color))
            {
                pe.Graphics.FillEllipse(brush, 0, 0, this.Width, this.Height);
            }
            if (image != null)
            {
                Image displayImage = GetImage();
                using (TextureBrush brush = new TextureBrush(displayImage))
                {
                    GraphicsPath gp = new GraphicsPath();
                    gp.AddEllipse(0, 0, this.Width, this.Height);
                    pe.Graphics.FillPath(brush, gp);
                    gp.Dispose();
                }
                displayImage.Dispose();
            }

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(pe.Graphics, base.Text, Font, ClientRectangle, ForeColor, flags);

            if (mouseEnter)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(20, mouseEnterColor)))
                {
                    pe.Graphics.FillEllipse(brush, (this.Width - radius) / 2, (this.Height - radius) / 2, radius, radius);
                }
            }

            if (borderWidth > 0)
            {
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pe.Graphics.DrawEllipse(pen, borderWidth / 2, borderWidth / 2, this.Width - borderWidth, this.Height - borderWidth);
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.Width > this.Height)
            {
                this.Width = this.Height;
            }
            else if (this.Width < this.Height)
            {
                this.Height = this.Width;
            }
            Invalidate();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Invalidate();
            base.OnTextChanged(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            mouseEnter = true;
            Timer t = new Timer();
            t.Interval = 20;
            t.Tick += new EventHandler(Timer_Tick);
            t.Start();
            base.OnMouseEnter(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            radius += (int)(this.Width * 0.2F);
            if (radius >= this.Width)
            {
                radius = this.Width;
                Timer t = sender as Timer;
                t.Dispose();
            }
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mouseEnter = false;
            radius = 0;
            Invalidate();
            base.OnMouseLeave(e);
        }
    }
}
