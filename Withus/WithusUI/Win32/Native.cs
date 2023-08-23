using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WithusUI.Win32
{
    public static class Native
    {
        [DllImport("user32.dll")]
        public static extern int GetScrollInfo(IntPtr hwnd, int fnBar, ref SCROLLINFO lpsi);

        #region 구조체
        [StructLayout(LayoutKind.Sequential)]
        public struct SCROLLINFO
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
    }
}
