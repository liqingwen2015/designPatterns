using System;

namespace BridgePattern.Sample2
{
    /// <summary>
    /// Windows 操作系统实现类：具体实现类
    /// </summary>
    public class WimdowsImp : IImageImp
    {
        public void DoPaint(Matrix m)
        {
            // 调用 Windows 系统的绘制函数绘制像素矩阵
            Console.WriteLine("在 Windows 操作系统中显示图像：");
        }


    }
}