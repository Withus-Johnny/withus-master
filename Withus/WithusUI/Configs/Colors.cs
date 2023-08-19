using System.Drawing;

namespace WithusUI.Configs
{
    /// <summary>
    /// WithusUI Colors
    /// </summary>
    public sealed class Colors
    {
        #region Form
        public static Color FormBackGroundColor
        {
            get { return Color.FromArgb(21, 23, 30); }
        }

        public static Color FormBorderColor
        {
            get { return Color.FromArgb(54, 56, 62); }
        }
        #endregion

        #region CaptionControls

        public static Color CaptionControlDefaultForeColor
        {
            get { return Color.FromArgb(133, 134, 138); }
        }

        public static Color CaptionTrayHoverBackGroundColor
        {
            get { return Color.FromArgb(35, 37, 43); }
        }

        public static Color CaptionCloseHoverForeColor
        {
            get { return Color.FromArgb(35, 37, 43); }
        }

        public static Color CaptionCloseHoverBackGroundColor
        {
            get { return Color.FromArgb(221, 19, 19); }
        }
        #endregion

        #region PrimeButton        
        public static Color PrimeButtonBackGroundColor
        {
            get { return Color.FromArgb(0, 116, 224); }
        }

        public static Color PrimeButtonBorderColor
        {
            get { return Color.FromArgb(12, 124, 229); }
        }

        public static Color PrimeButtonHoverBorderColor
        {
            get { return Color.FromArgb(71, 166, 255); }
        }

        public static Color PrimeButtonActiveForeColor
        {
            get { return Color.FromArgb(0, 63, 112); }
        }

        public static Color PrimeButtonActiveBorderColor
        {
            get { return Color.FromArgb(0, 90, 173); }
        }
        #endregion

        #region ServiceLabel
        public static Color ServiceLabelForeColor
        {
            get { return Color.FromArgb(21, 142, 255); }
        }

        public static Color ServiceLabelHoverForeColor
        {
            get { return Color.FromArgb(71, 166, 255); }
        }

        public static Color ServiceLabelActiveColor
        {
            get { return Color.FromArgb(11, 166, 244); }
        }
        #endregion

        #region DarkTextBox
        public static Color DarkTextBoxBorderColor
        {
            get { return Color.FromArgb(105, 107, 111); }
        }

        public static Color DarkTextBoxBackGroundColor
        {
            get { return Color.FromArgb(16, 17, 23); }
        }

        public static Color DarkTextBoxFocusBorderColor
        {
            get { return Color.FromArgb(20, 142, 255); }
        }

        public static Color DarkTextBoxInvalidBorderColor
        {
            get { return Color.FromArgb(255, 180, 0); }
        }
        #endregion

        #region AlertPanel
        public static Color AlertPanelBackGroundColor
        {
            get { return Color.FromArgb(34, 36, 44); }
        }

        public static Color AlertPanelBorderColor
        {
            get { return Color.FromArgb(61, 63, 70); }
        }
        #endregion

        #region DarkPlaceHolder
        public static Color DarkPlaceHolderForeColor
        {
            get { return Color.FromArgb(136, 136, 139); }
        }
        #endregion

        #region DarkCheckBox
        public static Color DarkCheckBoxBackGroundColor
        {
            get { return Color.FromArgb(16, 17, 23); }
        }

        public static Color DarkCheckBoxBorderColor
        {
            get { return Color.FromArgb(102, 103, 107); }
        }

        public static Color DarkCheckBoxCheckedColor
        {
            get { return Color.FromArgb(70, 164, 252); }
        }
        #endregion
    }
}
