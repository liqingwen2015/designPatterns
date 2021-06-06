using System;

namespace CommandPattern.Sample3
{
    /// <summary>
    /// 计算器界面（请求发送者）
    /// </summary>
    public class CaculatorForm
    {
        public AbstractCommand Command { get; set; }


        public void Compute(int value)
        {
            // 调用命令对象的执行方法
            var i = Command.Execute(value);
            Console.WriteLine($"执行运算，运算结果为：{i}");
        }

        public void Undo()
        {
            // 调用命令对象的执行方法
            var i = Command.Undo();
            Console.WriteLine($"执行撤销，运算结果为：{i}");
        }
    }
}