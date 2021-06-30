using System;

namespace BridgePattern.Sample2
{
    /// <summary>
    /// UNIX 操作系统实现类：具体实现类
    /// </summary>
    public class UnixImp : IImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("在 UNIX 操作系统中显示图像：");
        }
    }
}