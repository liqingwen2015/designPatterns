namespace CommandPattern.Sample1
{
    /// <summary>
    /// 帮助命令
    /// </summary>
    public class HelpCommand : Command
    {
        private readonly HelpeHandler _handler = new();

        public override void Execute() => _handler.Display();
    }
}