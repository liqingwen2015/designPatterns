namespace CommandPattern.Sample3
{
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class AbstractCommand
    {
        public abstract int Execute(int value);

        public abstract int Undo();
    }
}