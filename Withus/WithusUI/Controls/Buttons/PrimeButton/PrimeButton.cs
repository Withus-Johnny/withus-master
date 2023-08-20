using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace WithusUI.Controls.Buttons.PrimeButton
{
    public class PrimeButton : Button
    {
        private int borderSize = 2;
        private int borderRadius = 20;
        private Color defaultBorderColor = Colors.PrimeButtonBackGroundColor;
        private Color hoverBorderColor = Colors.PrimeButtonHoverBorderColor;
        private Color activeBorderColor = Colors.PrimeButtonActiveBorderColor;
        private Color borderColor = default;

        private ButtonState _buttonState = ButtonState.Normal;


        #region Properties
        [Category("커스텀 속성")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color DefaultBorderColor
        {
            get { return defaultBorderColor; }
            set
            {
                defaultBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color HoverBorderColor
        {
            get { return hoverBorderColor; }
            set
            {
                hoverBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color ActiveBorderColor
        {
            get { return activeBorderColor; }
            set
            {
                activeBorderColor = value;
                this.Invalidate();
            }
        }


        [Category("커스텀 속성")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("커스텀 속성")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        #endregion

        public PrimeButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Colors.PrimeButtonBackGroundColor;
            this.ForeColor = Color.WhiteSmoke;
            this.Resize += new EventHandler(Button_Resize);

            this.FlatAppearance.MouseOverBackColor = Colors.PrimeButtonBackGroundColor;
            this.FlatAppearance.MouseDownBackColor = Colors.PrimeActiveBackGroundColor;
            this.borderColor = Colors.PrimeButtonBorderColor;

            this.MouseDown += PrimeButton_MouseDown;
            this.MouseUp += PrimeButton_MouseUp;
            this.MouseHover += PrimeButton_MouseHover;
            this.MouseLeave += PrimeButton_MouseLeave;
        }

        private void PrimeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void PrimeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ForeColor = Colors.PrimeButtonActiveForeColor;
        }

        private void PrimeButton_MouseLeave(object sender, EventArgs e)
        {
            _buttonState = ButtonState.Normal;
            borderColor = Colors.PrimeButtonBorderColor;
        }

        private void PrimeButton_MouseHover(object sender, EventArgs e)
        {
            _buttonState = ButtonState.Hover;
            borderColor = Colors.PrimeButtonHoverBorderColor;
            this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Region = new Region(pathSurface);

                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
