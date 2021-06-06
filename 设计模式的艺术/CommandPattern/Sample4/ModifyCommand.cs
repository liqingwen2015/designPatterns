namespace CommandPattern.Sample4
{
    /// <summary>
    /// 修改命令（具体命令）
    /// </summary>
   public class ModifyCommand : Command
    {
        public ModifyCommand(string name) : base(name)
        {
        }

        public override void Execute(string args)
        {
            Args = args;
            ConfigOperator.Modify(args);
        }

        public override void Execute()
        {
            ConfigOperator.Modify(Args);
        }
    }
}