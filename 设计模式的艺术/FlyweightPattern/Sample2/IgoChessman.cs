using System;

namespace FlyweightPattern.Sample2
{
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coordinates)
        {
            Console.WriteLine($"棋子颜色：{GetColor()}，棋子位置：{coordinates.X}，{coordinates.Y}");
        }
    }
}