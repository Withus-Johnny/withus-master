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
            get { return Color.FromArgb(153, 178, 202); }
        }

        public static Color PrimeButtonActiveBorderColor
        {
            get { return Color.FromArgb(0, 90, 173); }
        }

        public static Color PrimeActiveBackGroundColor
        {
            get { return Color.FromArgb(0, 63, 122); }
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
            get { return Color.FromArgb(11, 116, 224); }
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

        public static Color DarkTextBoxForeColor
        {
            get { return Color.FromArgb(136, 136, 139); }
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

        #region Test
        public static Color GreyBackground
        {
            get { return Color.FromArgb(60, 63, 65); }
        }

        public static Color HeaderBackground
        {
            get { return Color.FromArgb(57, 60, 62); }
        }

        public static Color BlueBackground
        {
            get { return Color.FromArgb(66, 77, 95); }
        }

        public static Color DarkBlueBackground
        {
            get { return Color.FromArgb(52, 57, 66); }
        }

        public static Color DarkBackground
        {
            get { return Color.FromArgb(43, 43, 43); }
        }

        public static Color MediumBackground
        {
            get { return Color.FromArgb(49, 51, 53); }
        }

        public static Color LightBackground
        {
            get { return Color.FromArgb(69, 73, 74); }
        }

        public static Color LighterBackground
        {
            get { return Color.FromArgb(95, 101, 102); }
        }

        public static Color LightestBackground
        {
            get { return Color.FromArgb(178, 178, 178); }
        }

        public static Color LightBorder
        {
            get { return Color.FromArgb(81, 81, 81); }
        }

        public static Color DarkBorder
        {
            get { return Color.FromArgb(51, 51, 51); }
        }

        public static Color LightText
        {
            get { return Color.FromArgb(220, 220, 220); }
        }

        public static Color DisabledText
        {
            get { return Color.FromArgb(153, 153, 153); }
        }

        public static Color BlueHighlight
        {
            get { return Color.FromArgb(104, 151, 187); }
        }

        public static Color BlueSelection
        {
            get { return Color.FromArgb(75, 110, 175); }
        }

        public static Color GreyHighlight
        {
            get { return Color.FromArgb(122, 128, 132); }
        }

        public static Color GreySelection
        {
            get { return Color.FromArgb(92, 92, 92); }
        }

        public static Color DarkGreySelection
        {
            get { return Color.FromArgb(82, 82, 82); }
        }

        public static Color DarkBlueBorder
        {
            get { return Color.FromArgb(51, 61, 78); }
        }

        public static Color LightBlueBorder
        {
            get { return Color.FromArgb(86, 97, 114); }
        }

        public static Color ActiveControl
        {
            get { return Color.FromArgb(159, 178, 196); }
        }
        #endregion
    }
}
