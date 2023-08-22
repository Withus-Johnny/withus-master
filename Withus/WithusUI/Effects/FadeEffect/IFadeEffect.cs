using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithusUI.Effects.FadeEffect
{
    public interface IFadeEffect
    {
        bool IsFading();
        void FormFadeIn(Form control);
        void FormFadeOut(Form control);
        Task FormFadeOutAsync(Form control);

        void Abort();
    }
}
