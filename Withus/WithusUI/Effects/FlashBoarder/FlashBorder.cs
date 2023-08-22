using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithusUI.Configs;

namespace WithusUI.Effects.FlashBoarder
{
    public class FlashBorder : IFlashBorder
    {
        private int _duration = 150;
        private int _repeatCount = 3;
        private Color _borderColor = Color.IndianRed;

        public FlashBorder SetOption(int duration, int repeatCount, Color borderColor)
        {
            _duration = duration;
            _repeatCount = repeatCount;
            _borderColor = borderColor;
            return this;
        }

        public async void Flush(Form form)
        {
            Rectangle borderRect = new Rectangle(form.ClientRectangle.Location, new Size(form.ClientRectangle.Width - 1, form.ClientRectangle.Height - 1));

            using (Graphics g = form.CreateGraphics())
            {
                g.ResetClip();                
                
                for (int i = 0; i < _repeatCount+1; i++)
                {
                    using (Pen pen = new Pen(_borderColor))
                    {
                        g.DrawRectangle(pen, borderRect);
                    }

                    await Task.Delay(_duration);

                    using (Pen pen = new Pen(Colors.FormBorderColor))
                    {
                        g.DrawRectangle(pen, borderRect);
                    }
                    await Task.Delay(_duration);
                }
            }
        }        
    }
}
