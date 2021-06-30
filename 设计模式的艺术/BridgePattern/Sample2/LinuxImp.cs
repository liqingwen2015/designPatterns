using System;

namespace BridgePattern.Sample2
{
    /// <summary>
    /// Linux 操作系统实现类：具体实现类
    /// </summary>
    public class LinuxImp : IImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("在 Linux 操作系统中显示图像：");
        }
    }
}