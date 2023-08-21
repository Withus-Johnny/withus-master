using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.Resize += new EventHandler(Button_Resize);

            this.FlatAppearance.MouseOverBackColor = Colors.PrimeButtonBackGroundColor;
            this.FlatAppearance.MouseDownBackColor = Colors.PrimeActiveBackGroundColor;
            this.borderColor = Colors.PrimeButtonBorderColor;
        }

        #region Functions
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

        private void SetButtonState(ButtonState buttonState)
        {
            if (_buttonState != buttonState)
            {
                _buttonState = buttonState;
                Invalidate();
            }
        }
        #endregion

        #region Events
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion

        #region Override
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
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                    SetButtonState(ButtonState.Pressed);
                else
                {
                    SetButtonState(ButtonState.Hover);
                }
            }
            else
            {
                borderColor = Colors.PrimeButtonHoverBorderColor;
                SetButtonState(ButtonState.Hover);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!ClientRectangle.Contains(e.Location))
                return;

            this.Font = new Font(this.Font.FontFamily, this.Font.Size + 1, this.Font.Style);
            this.ForeColor = Colors.PrimeButtonActiveForeColor;
            SetButtonState(ButtonState.Pressed);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            this.Font = new Font(this.Font.FontFamily, this.Font.Size + -1, this.Font.Style);
            this.ForeColor = Color.WhiteSmoke;
            SetButtonState(ButtonState.Normal);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            borderColor = Colors.PrimeButtonBorderColor;
            SetButtonState(ButtonState.Normal);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            var location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
                SetButtonState(ButtonState.Normal);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            var location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
                SetButtonState(ButtonState.Normal);
            else
                SetButtonState(ButtonState.Hover);
        }
        #endregion
    }
}
