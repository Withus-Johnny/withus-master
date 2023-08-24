using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Effects.FlashBoarder;
using WM = WithusUI.Win32.WindowMessage;

namespace WithusUI.Forms
{
    public class WithusForm : Form
    {
        private bool _allowResize = true;
        private bool _allowWindowDrag = true;
        private int _borderSize = 4;

        private Color _formBackGroundColor = Colors.FormBackGroundColor;
        private Color _formBorderColor = Colors.FormBorderColor;

        private bool _isDragging = false;
        private Point _dragStartPoint;

        private IFlashBorder _flashBorder;
        private IFadeEffect _fadeEffect;

        private bool _flashBorderEnable = true;
        private int _flashDuration = 150;
        private int _flashRepeatCount = 3;
        private Color _flashBorderColor = Color.IndianRed;

        public bool IsLoaded { get; private set; }

        #region 보더 스트럭쳐
        public new Rectangle Top()
        {
            return new Rectangle(0, 0, this.ClientSize.Width, _borderSize);
        }

        public new Rectangle Left()
        {
            return new Rectangle(0, 0, _borderSize, this.ClientSize.Height);
        }

        public new Rectangle Bottom()
        {
            return new Rectangle(0, this.ClientSize.Height - _borderSize, this.ClientSize.Width, _borderSize);
        }

        public new Rectangle Right()
        {
            return new Rectangle(this.ClientSize.Width - _borderSize, 0, _borderSize, this.ClientSize.Height);
        }

        public Rectangle TopLeft()
        {
            return new Rectangle(0, 0, _borderSize, _borderSize);
        }

        public Rectangle TopRight()
        {
            return new Rectangle(this.ClientSize.Width - _borderSize, 0, _borderSize, _borderSize);
        }

        public Rectangle BottomLeft()
        {
            return new Rectangle(0, this.ClientSize.Height - _borderSize, _borderSize, _borderSize);
        }

        public Rectangle BottomRight()
        {
            return new Rectangle(this.ClientSize.Width - _borderSize, this.ClientSize.Height - _borderSize, _borderSize, _borderSize);
        }
        #endregion

        [Category("커스텀 속성")]
        public bool FlashBorderEnable
        {
            get { return _flashBorderEnable; }
            set
            {
                _flashBorderEnable = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public int FlashDuration
        {
            get { return _flashDuration; }
            set
            {
                _flashDuration = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public int FlashRepeatCount
        {
            get { return _flashRepeatCount; }
            set
            {
                _flashRepeatCount = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color FlashBorderColor
        {
            get { return _flashBorderColor; }
            set
            {
                _flashBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public bool AllowResize
        {
            get { return _allowResize; }
            set
            {
                _allowResize = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public bool AllowWindowDrag
        {
            get { return _allowWindowDrag; }
            set
            {
                _allowWindowDrag = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color BorderColor
        {
            get { return _formBorderColor; }
            set
            {
                _formBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color FormBackGroundColor
        {
            get { return _formBackGroundColor; }
            set
            {
                _formBackGroundColor = value;
                this.BackColor = FormBackGroundColor;
                this.Invalidate();
            }
        }

        public WithusForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            this.Padding = new Padding(Const.RegisterForm_Padding);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            _flashBorder = new FlashBorder();
            _fadeEffect = new FadeEffect();
            this.Load += WithusForm_Load;
        }

        private async void WithusForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            await _fadeEffect.FormFadeInAsync(this);
            IsLoaded = true;
            this.Visible = true;
        }

        public void SubscribeToDragEventsForPanels(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control.GetType() == typeof(Panel) || control.GetType() == typeof(PictureBox))
                {
                    if (control.Tag == null || control.Tag.Equals("Subscribed"))
                    {
                        control.MouseDown += Panel_MouseDown;
                        control.MouseMove += Panel_MouseMove;
                        control.MouseUp += Panel_MouseUp;

                        control.Tag = "Subscribed";

                        if (control.HasChildren)
                        {
                            SubscribeToDragEventsForPanels(control);
                        }
                    }
                }
            }
        }

        public void UnsubscribeFromDragEventsForPanels(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.Equals("Subscribed"))
                    {
                        control.MouseDown -= Panel_MouseDown;
                        control.MouseMove -= Panel_MouseMove;
                        control.MouseUp -= Panel_MouseUp;

                        control.Tag = null;

                        if (control.HasChildren)
                        {
                            UnsubscribeFromDragEventsForPanels(control);
                        }
                    }
                }
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _dragStartPoint = e.Location;
            }
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - _dragStartPoint.X, currentScreenPos.Y - _dragStartPoint.Y);
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;

                Screen currentScreen = Screen.FromControl(this);
                Rectangle screenBounds = currentScreen.WorkingArea;
                Rectangle formBounds = new Rectangle(this.Location, this.Size);

                bool isOutOfBounds = !screenBounds.Contains(formBounds);

                if (isOutOfBounds)
                {
                    formBounds.X = Math.Max(screenBounds.Left, Math.Min(formBounds.X, screenBounds.Right - formBounds.Width));
                    formBounds.Y = Math.Max(screenBounds.Top, Math.Min(formBounds.Y, screenBounds.Bottom - formBounds.Height));

                    this.Location = formBounds.Location;
                    this.Invalidate();
                    _flashBorder.SetOption(_flashDuration, _flashRepeatCount, _flashBorderColor).Flush(this);
                }
            }
        }

        #region 윈도우 메세지 프로시저       

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (!AllowResize) return;

            if (m.Msg == WM.WM_NCHITTEST)
            {
                var mousePoint = this.PointToClient(Cursor.Position);

                if (TopLeft().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTTOPLEFT;
                else if (TopRight().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTTOPRIGHT;
                else if (BottomLeft().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTBOTTOMLEFT;
                else if (BottomRight().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTBOTTOMRIGHT;
                else if (Top().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTTOP;
                else if (Left().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTLEFT;
                else if (Right().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTRIGHT;
                else if (Bottom().Contains(mousePoint))
                    m.Result = (IntPtr)WM.HTBOTTOM;
            }
        }
        #endregion

        #region Override Events
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!_allowResize)
            {
                _borderSize = 1;
            }

            using (SolidBrush b = new SolidBrush(_formBorderColor))
            {
                e.Graphics.FillRectangle(b, Top());
                e.Graphics.FillRectangle(b, Left());
                e.Graphics.FillRectangle(b, Right());
                e.Graphics.FillRectangle(b, Bottom());
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
        #endregion
    }
}
