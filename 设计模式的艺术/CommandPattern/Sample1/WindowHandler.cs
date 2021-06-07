using System;

namespace CommandPattern.Sample1
{
    /// <summary>
    /// 窗口处理（请求接收者）
    /// </summary>
    class WindowHandler
    {
        public void Minimize() => Console.WriteLine("将窗口最小化至托盘！");
    }
}