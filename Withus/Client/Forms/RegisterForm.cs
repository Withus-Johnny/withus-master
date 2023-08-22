using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Effects.FadeEffect;
using WithusUI.Effects.FlashBoarder;

namespace Client.Forms
{
    public partial class RegisterForm : Form
    {
        private bool _isResizing = false;
        private bool _isDragging = false;
        private Point _dragStartPoint;

        private IFadeEffect fadeEffect;
        private IFlashBorder flashBorder;

        const int ImaginaryBorderSize = 4;

        [DllImport("user32.dll")]
        private static extern int GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        #region 보더 스트럭쳐
        public new Rectangle Top()
        {
            return new Rectangle(0, 0, this.ClientSize.Width, ImaginaryBorderSize);
        }

        public new Rectangle Left()
        {
            return new Rectangle(0, 0, ImaginaryBorderSize, this.ClientSize.Height);
        }

        public new Rectangle Bottom()
        {
            return new Rectangle(0, this.ClientSize.Height - ImaginaryBorderSize, this.ClientSize.Width, ImaginaryBorderSize);
        }

        public new Rectangle Right()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, this.ClientSize.Height);
        }

        public Rectangle TopLeft()
        {
            return new Rectangle(0, 0, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle TopRight()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle BottomLeft()
        {
            return new Rectangle(0, this.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle BottomRight()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, this.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize);
        }
        #endregion

        #region 스크롤인포 스트럭쳐 및 상수
        private const int SB_VERT = 1;
        private const int SIF_RANGE = 0x1;
        private const int SIF_PAGE = 0x2;
        private const int SIF_POS = 0x4;
        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;

        [StructLayout(LayoutKind.Sequential)]
        private struct SCROLLINFO
        {
            public uint cbSize;
            public uint fMask;
            public int nMin;
            public int nMax;
            public uint nPage;
            public int nPos;
            public int nTrackPos;
        }
        #endregion

        #region 윈도우 메세지 프로시저
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                var mousePoint = this.PointToClient(Cursor.Position);

                if (TopLeft().Contains(mousePoint))
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight().Contains(mousePoint))
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft().Contains(mousePoint))
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight().Contains(mousePoint))
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (Top().Contains(mousePoint))
                    m.Result = (IntPtr)HTTOP;
                else if (Left().Contains(mousePoint))
                    m.Result = (IntPtr)HTLEFT;
                else if (Right().Contains(mousePoint))
                    m.Result = (IntPtr)HTRIGHT;
                else if (Bottom().Contains(mousePoint))
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }
        #endregion

        

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            this.Padding = new Padding(Const.RegisterForm_Padding);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            panel_Container.MouseDown += Panel_DragMouseDown;
            panel_Container.MouseMove += Panel_DragMouseMove;
            panel_Container.MouseUp += Panel_DragMouseUp;

            flashBorder = new FlashBorder();
            fadeEffect = new FadeEffect();

            panel_ControlContainer.Enabled = false;
        }

        #region Control Events

        private async void button_Return_Click(object sender, EventArgs e)
        {
            if (fadeEffect.IsFading()) return;

            await fadeEffect.FormFadeOutAsync(this);
            this.Close();
        }

        private void checkBox_Agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agreement.Checked)
            {
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
            }
            else
            {
                panel_ControlContainer.Enabled = false;
                richTextBox1.SelectionStart = 0;
                richTextBox1.ScrollToCaret();
            }
        }
        
        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            SCROLLINFO scrollInfo = new SCROLLINFO
            {
                cbSize = (uint)Marshal.SizeOf(typeof(SCROLLINFO)),
                fMask = SIF_ALL
            };

            GetScrollInfo(richTextBox1.Handle, SB_VERT, ref scrollInfo);

            bool isAtBottom = scrollInfo.nPos + scrollInfo.nPage >= scrollInfo.nMax;

            if (isAtBottom)
            {
                panel_ControlContainer.Enabled = true;
                if (!checkBox_Agreement.Checked)
                {
                    checkBox_Agreement.Checked = true;
                }
            }
        }

        private void primeButton_Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Size);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            fadeEffect.FormFadeIn(this);
        }

        private void Panel_DragMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _dragStartPoint = e.Location;
            }
        }

        private void Panel_DragMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - _dragStartPoint.X, currentScreenPos.Y - _dragStartPoint.Y);
            }

            if (!_isResizing)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Panel_DragMouseUp(object sender, MouseEventArgs e)
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
                    flashBorder.SetOption(150, 3, Color.IndianRed).Flush(this);
                }
            }
        }

        #endregion

        #region Override Events
        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Colors.FormBorderColor))
            {
                e.Graphics.FillRectangle(b, Top());
                e.Graphics.FillRectangle(b, Left());
                e.Graphics.FillRectangle(b, Right());
                e.Graphics.FillRectangle(b, Bottom());
            }
        }

        #endregion        
    }
}