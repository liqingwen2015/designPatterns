using System;
using AdapterPattern.Sample1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AdapterPatternTest : TestBase
    {
        protected override string PatternConfigJsonPath => "adapterPattern";
        protected override string AssemblyName => "AdapterPattern";

        [TestMethod]
        public void Sample1()
        {
            // 针对抽象目标接口编程
            // 读取配置文件，反射生成对象
            IScoreOperation opration = CreateInstance<OperationAdapter>();
            var scores = new int[] { 84, 76, 50, 69, 90, 91, 88, 96 };
            // 定义成绩数组
            var results = opration.Sort(scores);

            Console.WriteLine("成绩排序结构");

            // 遍历输出成绩
            foreach (var result in results)
            {
                Console.WriteLine(result + ",");
            }

            Console.WriteLine();

            Console.WriteLine("查找成绩 90：");

            var score = opration.Search(results, 90);

            Console.WriteLine(score != -1 ? "找到成绩 90." : "没有找到成绩 90.");

            Console.WriteLine("查找成绩 92：");

            score = opration.Search(results, 92);

            Console.WriteLine(score != -1 ? "找到成绩 92." : "没有找到成绩 92.");
        }
    }
}