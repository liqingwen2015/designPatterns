using System;

namespace BridgePattern.Sample2
{
    /// <summary>
    /// PNG 格式图像：扩充抽象类
    /// </summary>
    public class PngImage : Image
    {


        public override void ParseFile(string fileName)
        {
            Imp.DoPaint(new Matrix());
            Console.WriteLine($"{fileName}，格式为 PNG。");

        }
    }
}