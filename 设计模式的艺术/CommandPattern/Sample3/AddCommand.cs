namespace CommandPattern.Sample3
{
    /// <summary>
    /// 加法命令（具体命令）
    /// </summary>
  public  class AddCommand : AbstractCommand
    {
        private readonly Adder _adder = new();
        private int _value;

        public override int Execute(int value)
        {
            _value = value;
            return _adder.Add(value);
        }

        public override int Undo() => _adder.Add(-_value);
    }
}