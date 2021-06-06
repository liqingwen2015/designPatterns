namespace CommandPattern.Sample4
{
    /// <summary>
    /// 增加命令（具体命令）
    /// </summary>
    public class InsertCommand : Command
    {
        public InsertCommand(string name) : base(name)
        {
        }

        public override void Execute(string args)
        {
            Args = args;
            ConfigOperator.Insert(args);
        }

        public override void Execute()
        {
            ConfigOperator.Insert(Args);
        }
    }
}