using System;

namespace CommandPattern.Sample3
{
    /// <summary>
    /// 计算器界面（请求发送者）
    /// </summary>
    class CaculatorForm
    {
        public AbstractCommand Command { get; set; }

        public void Compute(int value)
        {
            var i = Command.Execute(value);
            Console.WriteLine($"执行运算，运算结果为：{i}");
        }

        public void Undo()
        {
            var i = Command.Undo();
            Console.WriteLine($"执行撤销，运算结果为：{i}");
        }
    }
}