namespace CommandPattern.Sample3
{
    /// <summary>
    /// 加法器（请求接收者）
    /// </summary>
    class Adder
    {
        private int _num = 0;

        public int Add(int value)
        {
            _num += value;
            return _num;
        }
    }
}