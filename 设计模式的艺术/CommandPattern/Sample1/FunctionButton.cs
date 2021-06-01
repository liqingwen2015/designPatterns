using System;

namespace CommandPattern.Sample1
{
    /// <summary>
    /// 功能键（请求发送者）
    /// </summary>
    class FunctionButton
    {
        public string Name { get; set; }

        /// <summary>
        /// 命令
        /// </summary>
        public Command Command { get; set; }

        public FunctionButton(string name)
        {
            Name = name;
        }

        public void OnClick()
        {
            Console.WriteLine("点击功能键：");
            Command.Execute();
        }

    }
}