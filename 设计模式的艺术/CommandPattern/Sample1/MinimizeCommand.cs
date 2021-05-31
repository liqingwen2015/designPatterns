namespace CommandPattern.Sample1
{
    /// <summary>
    /// 最小化命令
    /// </summary>
    class MinimizeCommand : Command
    {
        private readonly WindowHandler _handler = new();

        public override void Execute()
        {
            _handler.Minimize();
        }
    }
}