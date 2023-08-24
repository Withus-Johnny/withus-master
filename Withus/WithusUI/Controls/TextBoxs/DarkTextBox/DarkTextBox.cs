using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WithusUI.Configs;

namespace WithusUI.Controls.TextBoxs.DarkTextBox
{
    public partial class DarkTextBox : UserControl
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [Category("커스텀 이벤트")]
        public event EventHandler TextChangedEvent;

        [Category("커스텀 이벤트")]
        public event KeyEventHandler KeyDownEvent;

        [Category("커스텀 이벤트")]
        public event MouseEventHandler MouseDownEvent;


        private Color borderColor = Colors.DarkTextBoxBorderColor;
        private Color borderFocusColor = Colors.DarkTextBoxFocusBorderColor;
        private Color borderHoverColor = Color.DarkGray;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private bool isHover = false;
        private int borderRadius = 0;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        #region Properties

        [Category("커스텀 속성")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("커스텀 속성")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("커스텀 속성")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("커스텀 속성")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("커스텀 속성")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("커스텀 속성")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("커스텀 속성")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("커스텀 속성")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("커스텀 속성")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        [Category("커스텀 속성")]
        public HorizontalAlignment Alignment
        {
            get
            {
                return textBox1.TextAlign;
            }
            set
            {
                textBox1.TextAlign = value;
                textBox1.SelectionStart = textBox1.TextLength;
            }
        }

        [Category("커스텀 속성")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("커스텀 속성")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, placeholderText);
            }
        }

        #endregion

        public DarkTextBox()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            Padding = new Padding(14, 7, 10, 7);
            Size = new Size(250, 30);
            BackColor = Colors.DarkTextBoxBackGroundColor;
            ForeColor = Colors.DarkTextBoxForeColor;
            textBox1.MaxLength = 30;

            textBox1.ShortcutsEnabled = false;

            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += TextBox1_KeyDown;

            textBox1.MouseDown += TextBox1_MouseDown;
            textBox1.MouseHover += TextBox1_MouseHover;
            textBox1.MouseLeave += TextBox1_MouseLeave;
        }

        

        #region Funtions

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (textBox1.Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #endregion

        #region Events

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDownEvent != null)
            {
                MouseDownEvent.Invoke(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextChangedEvent != null)
            {
                TextChangedEvent.Invoke(sender, e);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyDownEvent != null)
            {
                KeyDownEvent.Invoke(sender, e);
            }
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (isFocused) return;
            isHover = false;
            this.Invalidate();
        }

        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            if (!isFocused)
            {
                isHover = true;
                this.Invalidate();
            }
        }

        #endregion       

        #region Overridde

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            isFocused = true;
            isHover = false;
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            isFocused = false;
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, placeholderText);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;
                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;
                    }

                    if (isHover)
                    {
                        penBorder.Color = borderHoverColor;
                    }

                    if (underlinedStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);

                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);

                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        #endregion
    }
}