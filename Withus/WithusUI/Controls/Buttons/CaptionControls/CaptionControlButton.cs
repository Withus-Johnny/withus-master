using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WithusUI.Configs;
using WithusUI.Controls.Buttons.CaptionControls;

namespace WithusUI.Controls.Buttons.TrayButton
{
    [ToolboxBitmap(typeof(Button))]
    [DefaultEvent("Click")]
    public class CaptionControlButton : Button
    {
        #region Field Region        
        private ButtonState _buttonState = ButtonState.Normal;
        private ButtonType _buttonType = ButtonType.Tray;
        private bool _spacePressed;

        #endregion

        #region Designer Property Region
        public new string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        public new bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                Invalidate();
            }
        }

        [Category("커스텀 속성")]
        [Description("타이틀바 버튼 타입")]
        [DefaultValue(ButtonType.Tray)]
        public ButtonType ButtonType
        {
            get { return _buttonType; }
            set
            {
                _buttonType = value;
                Invalidate();
            }
        }

        #endregion
        public CaptionControlButton()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            SetButtonState(ButtonState.Normal);
        }
        #region Method Region

        private void SetButtonState(ButtonState buttonState)
        {
            if (_buttonState != buttonState)
            {
                _buttonState = buttonState;
                Invalidate();
            }
        }

        #endregion

        #region Event Handler Region

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_spacePressed)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                    SetButtonState(ButtonState.Pressed);
                else
                    SetButtonState(ButtonState.Hover);
            }
            else
            {
                SetButtonState(ButtonState.Hover);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!ClientRectangle.Contains(e.Location))
                return;

            SetButtonState(ButtonState.Pressed);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_spacePressed)
                return;

            SetButtonState(ButtonState.Normal);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (_spacePressed)
                return;

            SetButtonState(ButtonState.Normal);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            if (_spacePressed)
                return;

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

            _spacePressed = false;

            var location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
                SetButtonState(ButtonState.Normal);
            else
                SetButtonState(ButtonState.Hover);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = true;
                SetButtonState(ButtonState.Pressed);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = false;

                var location = Cursor.Position;

                if (!ClientRectangle.Contains(location))
                    SetButtonState(ButtonState.Normal);
                else
                    SetButtonState(ButtonState.Hover);
            }
        }
        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);

            var textColor = Colors.CaptionControlDefaultForeColor;
            var fillColor = Colors.FormBackGroundColor;

            if (Enabled)
            {
                switch (_buttonState)
                {
                    case ButtonState.Hover:

                        if (_buttonType == ButtonType.Tray)
                        {
                            textColor = Color.Gainsboro;
                            fillColor = Colors.CaptionTrayHoverBackGroundColor;
                        }
                        else
                        {
                            textColor = Color.Gainsboro;
                            fillColor = Colors.CaptionCloseHoverBackGroundColor;
                        }
                        break;
                    case ButtonState.Pressed:
                        break;
                }
            }
            else
            {
                textColor = Color.Gainsboro;
                fillColor = Color.IndianRed;
            }

            using (var b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            var textOffsetX = 0;
            var textOffsetY = 0;

            using (var b = new SolidBrush(textColor))
            {
                var modRect = new Rectangle(rect.Left + textOffsetX + Padding.Left,
                                            rect.Top + textOffsetY + Padding.Top, rect.Width - Padding.Horizontal,
                                            rect.Height - Padding.Vertical);

                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.DrawString(Text, Font, b, modRect, stringFormat);
            }
        }

        #endregion
    }
}
