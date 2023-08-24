using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithusUI.Effects.FadeEffect
{
    public class FadeEffect : IFadeEffect, IDisposable
    {
        private Form _targetForm;

        private const int FADE_TICK_VALUE = 25;
        private const double FADE_OPACITY_VALUE = 0.050;

        private Timer _fadeTimer = new Timer();
        private bool _isFading = false;

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

            _targetForm = form;
            _targetForm.Opacity = 0;

            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeInTimer_Tick;
            _fadeTimer.Start();
        }

        public async Task FormFadeInAsync(Form form)
        {
            if (_isFading) return;

            _targetForm = form;
            _targetForm.Opacity = 0.1;

            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeInTimer_Tick;
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

        public void FormFadeOut(Form form)
        {
            if (_isFading) return;

            _targetForm = form;

            _isFading = true;

            _fadeTimer.Interval = FADE_TICK_VALUE;
            _fadeTimer.Tick += FadeOutTimer_Tick;
            _fadeTimer.Start();
        }

        public async Task FormFadeOutAsync(Form form)
        {
            if (_isFading) return;

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
                _fadeTimer.Tick -= FadeInTimer_Tick;
                _isFading = false;
                _targetForm = null;
                _fadeTimer.Stop();
            }
            else
            {
                _targetForm.Opacity += FADE_OPACITY_VALUE;
            }
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (_targetForm.Opacity <= 0)
            {
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

        public void Dispose()
        {
            Abort();
            _fadeTimer.Dispose();
        }
    }
}
