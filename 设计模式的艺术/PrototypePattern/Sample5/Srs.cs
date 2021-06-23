using System;

namespace PrototypePattern.Sample5
{
    /// <summary>
    /// 软件需求规格说明书（Software Requirements Specification）类
    /// </summary>
    public class Srs : IOfficialDocument
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("《软件需求规则说明书》");
        }
    }
}