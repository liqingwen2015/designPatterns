namespace StatePattern.Sample3
{
    /// <summary>
    /// 屏幕
    /// </summary>
    public class Screen
    {
        private readonly State _normalState;
        private readonly State _largerState;
        private readonly State _largestState;

        public Screen()
        {
            _normalState = new NormalState();
            _largerState = new LargerState();
            _largestState = new LargestState();
            CurrentState = _normalState;
            CurrentState.Display();
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public State CurrentState { get; set; }

        /// <summary>
        /// 点击
        /// </summary>
        public void OnClick()
        {
            if (CurrentState == _normalState)
            {
                CurrentState = _largerState;
                CurrentState.Display();
            }
            else if (CurrentState == _largerState)
            {
                CurrentState = _largestState;
                CurrentState.Display();
            }
            else if (CurrentState == _largestState)
            {
                CurrentState = _normalState;
                CurrentState.Display();
            }
        }
    }
}