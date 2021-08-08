using System;

namespace FlyweightPattern.Sample1
{
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display()
        {
            Console.WriteLine("Æå×ÓÑÕÉ«£º" + GetColor());
        }
    }
}