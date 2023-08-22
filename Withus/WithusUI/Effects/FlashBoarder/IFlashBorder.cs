using System;
using System.Drawing;
using System.Windows.Forms;

namespace WithusUI.Effects.FlashBoarder
{
    public interface IFlashBorder
    {
        FlashBorder SetOption(int duration, int repeatCount, Color borderColor);
        void Flush(Form form);
    }
}
