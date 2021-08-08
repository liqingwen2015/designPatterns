using System;
using FlyweightPattern.Sample2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IgoChessmanFactory = FlyweightPattern.Sample1.IgoChessmanFactory;

namespace UnitTests
{
    /// <summary>
    /// 享元模式
    /// </summary>
    [TestClass]
    public class FlyweightPatternTest
    {
        /// <summary>
        /// 示例一
        /// </summary>
        [TestMethod]
        public void S1()
        {
            // 获取享元工厂对象
            var factory = IgoChessmanFactory.Instance;

            // 通过享元工厂获取 3 颗黑子
            var black1 = factory.GetIgoChessman("b");
            var black2 = factory.GetIgoChessman("b");
            var black3 = factory.GetIgoChessman("b");
            Console.WriteLine($"判断两颗黑子是否相同：{black1 == black2}");

            // 通过享元工厂获取两颗白字
            var white1 = factory.GetIgoChessman("w");
            var white2 = factory.GetIgoChessman("w");
            Console.WriteLine($"判断两颗白子是否相同：{white1 == white2}");

            // 显示棋子
            black1.Display();
            black2.Display();
            black3.Display();
            white1.Display();
            white2.Display();
        }

        /// <summary>
        /// 示例二
        /// </summary>
        [TestMethod]
        public void S2()
        {
            // 获取向原工厂对象
            var factory = FlyweightPattern.Sample2.IgoChessmanFactory.Instance;

            // 通过享元工厂获取 3 颗黑子
            var black1 = factory.GetIgoChessman("b");
            var black2 = factory.GetIgoChessman("b");
            var black3 = factory.GetIgoChessman("b");
            Console.WriteLine($"判断两颗黑子是否相同：{black1 == black2}");

            // 通过享元工厂获取两颗白子
            var white1 = factory.GetIgoChessman("w");
            var white2 = factory.GetIgoChessman("w");
            Console.WriteLine($"判断两颗白子是否相同：{white1 == white2}");

            // 显示棋子，同时设置棋子的坐标位置
            black1.Display(new Coordinates(1, 2));
            black2.Display(new Coordinates(3, 4));
            black3.Display(new Coordinates(1, 3));

            white1.Display(new Coordinates(2, 5));
            white2.Display(new Coordinates(2, 4));
        }
    }
}