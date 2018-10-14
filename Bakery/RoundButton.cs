using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Bakery
{
    public partial class RoundButton : Button
    {
        float roundScale = 1;
        float clientRoundScale = 1;
        Color color = Color.Silver;
        Image image = null;
        bool mouseEnter = false;
        bool mouseDown = false;
        Color borderColor = Color.Silver;
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

        public RoundButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private GraphicsPath GetGraphicsPath()
        {
            GraphicsPath gp = new GraphicsPath();
            float diameterArc = (this.Height - borderWidth) * roundScale;
            if (diameterArc > 0)
            {
                gp.AddArc(borderWidth / 2, borderWidth / 2, diameterArc, diameterArc, 180, 90);
                gp.AddArc(this.Width - diameterArc - borderWidth / 2, borderWidth / 2, diameterArc, diameterArc, 270, 90);
                gp.AddArc(this.Width - diameterArc - borderWidth / 2, this.Height - diameterArc - borderWidth / 2, diameterArc, diameterArc, 0, 90);
                gp.AddArc(borderWidth / 2, this.Height - diameterArc - borderWidth / 2, diameterArc, diameterArc, 90, 90);
                gp.AddLine(borderWidth / 2, this.Height - diameterArc / 2 - borderWidth, borderWidth / 2, borderWidth / 2 + diameterArc / 2);
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

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
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
                    Image displayImage = GetImage();
                    using (TextureBrush brush = new TextureBrush(displayImage))
                    {
                        pe.Graphics.FillPath(brush, gp);
                    }
                    displayImage.Dispose();
                }

                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                TextRenderer.DrawText(pe.Graphics, base.Text, Font, ClientRectangle, ForeColor, flags);

                if (mouseEnter)
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(10, Color.Black)))
                    {
                        pe.Graphics.FillPath(brush, gp);
                    }
                }
                if (mouseDown)
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(20, Color.Black)))
                    {
                        pe.Graphics.FillPath(brush, gp);
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseDown = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseDown = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            mouseEnter = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mouseEnter = false;
            Invalidate();
        }
    }
}
