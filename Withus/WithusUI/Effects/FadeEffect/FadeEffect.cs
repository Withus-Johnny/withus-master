using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithusUI.Effects.FadeEffect
{
    public class FadeEffect : IFadeEffect
    {
        private Form _targetForm;

        private const int FADE_TICK_VALUE = 25;
        private const double FADE_OPACITY_VALUE = 0.050;

        private Timer _fadeTimer = new Timer();
        private bool _isFading = false;
        private EffectState EffectState { get; set; }

        public void Abort()
        {
            _isFading = false;
            _fadeTimer.Tick -= FadeInTimer_Tick;
            _fadeTimer.Stop();
        }

        public bool IsFading()
        {
            return _isFading;
        }

        public void FormFadeIn(Form form)
        {
            if (_isFading) return;

            EffectState = EffectState.Active;

            _targetForm = form;
            _targetForm.Opacity = 0;

            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeInTimer_Tick;
            _fadeTimer.Start();
        }

        public void FormFadeOut(Form form)
        {
            if (_isFading) return;

            EffectState = EffectState.Active;

            _targetForm = form;

            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeOutTimer_Tick;
            _fadeTimer.Start();
        }

        public async Task FormFadeOutAsync(Form form)
        {
            if (_isFading) return;

            EffectState = EffectState.Active;
            _targetForm = form;
            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeOutTimer_Tick;
            _fadeTimer.Start();

            await Task.Run(() =>
            {
                while (_isFading)
                {
                    Task.Delay(FADE_TICK_VALUE);
                }
            });
            return;
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (_targetForm.Opacity == 1)
            {
                EffectState = EffectState.Completed;
                _fadeTimer.Tick -= FadeInTimer_Tick;
                _isFading = false;
                _targetForm = null;
                _fadeTimer.Stop();
            }
            else
            {
                EffectState = EffectState.InProgress;
                _targetForm.Opacity += FADE_OPACITY_VALUE;
            }
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (_targetForm.Opacity <= 0)
            {
                EffectState = EffectState.Completed;
                _fadeTimer.Tick -= FadeOutTimer_Tick;
                _isFading = false;
                _targetForm = null;
                _fadeTimer.Stop();
            }
            else
            {
                _targetForm.Opacity -= FADE_OPACITY_VALUE;
            }
        }
    }
}
