namespace WithusUI.Win32
{
    public static class WindowMessage
    {
        /// <summary>
        /// 창의 어느 부분이 특정 화면 좌표에 해당하는지 확인하기 위해 창으로 보내집니다. 
        /// 커서가 움직일 때, 마우스 단추를 누르거나 
        /// 놓을 때 또는 WindowFromPoint와 같은 함수 호출에 대한 응답으로 발생할 수 있습니다. 
        /// 마우스가 캡처되지 않으면 커서 아래 창으로 메시지가 보내집니다. 
        /// 그렇지 않으면 마우스를 캡처한 창으로 메시지가 보내집니다.
        /// </summary>
        public const int WM_NCHITTEST = 0x0084;

        /// <summary>
        /// 크기 조정 가능한 창의 왼쪽 테두리에 있습니다. 사용자가 마우스를 클릭하여 창의 크기를 가로로 조정할 수 있습니다.
        /// </summary>
        public const int HTLEFT = 10;

        /// <summary>
        /// 크기 조정 가능한 창의 오른쪽 테두리에 있습니다. 사용자가 마우스를 클릭하여 창의 크기를 가로로 조정할 수 있습니다.
        /// </summary>
        public const int HTRIGHT = 11;

        /// <summary>
        /// 창의 위쪽 가로 테두리에 있습니다.
        /// </summary>
        public const int HTTOP = 12;

        /// <summary>
        /// 창 테두리의 왼쪽 위 모서리에 있습니다
        /// </summary>
        public const int HTTOPLEFT = 13;

        /// <summary>
        /// 창 테두리의 오른쪽 위 모서리에 있습니다.
        /// </summary>
        public const int HTTOPRIGHT = 14;

        /// <summary>
        /// 크기 조정 가능한 창의 아래쪽 가로 테두리에 있습니다. 사용자가 마우스를 클릭하여 창의 크기를 세로로 조정할 수 있습니다.
        /// </summary>
        public const int HTBOTTOM = 15;

        /// <summary>
        /// 크기 조정 가능한 창의 왼쪽 아래 가로 테두리에 있습니다. 사용자가 마우스를 클릭하여 창의 크기를 가로로 조정할 수 있습니다.
        /// </summary>
        public const int HTBOTTOMLEFT = 16;

        /// <summary>
        /// 크기 조정 가능한 창의 오른쪽 아래 가로 테두리에 있습니다. 사용자가 마우스를 클릭하여 창의 크기를 가로로 조정할 수 있습니다.
        /// </summary>
        public const int HTBOTTOMRIGHT = 17;
    }
}
