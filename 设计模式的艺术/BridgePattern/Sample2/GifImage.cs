using System;

namespace BridgePattern.Sample2
{
    /// <summary>
    /// GIF 格式图像：扩充抽象类
    /// </summary>
    public class GifImage : Image
    {
        public override void ParseFile(string fileName)
        {
            Imp.DoPaint(new Matrix());
            Console.WriteLine($"{fileName}，格式为 GIF。");
        }
    }
}