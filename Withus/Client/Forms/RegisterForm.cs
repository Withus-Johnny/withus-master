using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace Client.Forms
{
    public partial class RegisterForm : Form
    {
        private Rectangle _borderRect;

        private bool _isDraging = false;
        private Point _dragStartPoint;

        private bool _isDragging = false;

        private const int GRIP_SIZE = 15;
        private Rectangle _gripRect;
        private bool _isResizing = false;
        private Point _lastMousePosition;

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Colors.FormBackGroundColor;
            this.Padding = new Padding(Const.RegisterForm_Padding);
            _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
            _gripRect = new Rectangle(this.Width - GRIP_SIZE, this.Height - GRIP_SIZE, GRIP_SIZE, GRIP_SIZE);

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);



            panel_Container.MouseDown += Panel_DragMouseDown;
            panel_Container.MouseMove += Panel_DragMouseMove;
            panel_Container.MouseUp += Panel_DragMouseUp;

            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
        }



        #region Control Events
        private void button_Return_Click(object sender, EventArgs e)
        {
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_isResizing && e.Button == MouseButtons.Left)
            {
                if (_gripRect.Contains(e.Location))
                {
                    _isResizing = true;
                    _lastMousePosition = e.Location;
                }
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None && !_isResizing)
            {
                if (_gripRect.Contains(e.Location))
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }

            if (_isResizing)
            {
                this.Width += e.X - _lastMousePosition.X;
                this.Height += e.Y - _lastMousePosition.Y;
                if (_lastMousePosition != e.Location)
                {
                    _lastMousePosition = e.Location;

                    _borderRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                    _gripRect = new Rectangle(this.Width - GRIP_SIZE, this.Height - GRIP_SIZE, GRIP_SIZE, GRIP_SIZE);

                    this.Invalidate();
                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                _isDragging = false;
            }

            if (_isResizing)
            {
                _isResizing = false;
            }
        }

        private void Panel_DragMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDraging = true;
                _dragStartPoint = e.Location;
            }
        }

        private void Panel_DragMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDraging)
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
                _isDraging = false;
            }
        }
        #endregion

        #region Override Events

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var g = e.Graphics;

            using (var p = new Pen(Colors.FormBorderColor))
            {
                g.DrawRectangle(p, _borderRect);
                g.FillRectangle(Brushes.Gray, _gripRect);
            }
        }

        #endregion
    }
}
