using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Sample1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NiuX.Extensions;

namespace UnitTests
{
    [TestClass]
    public class BuilderPatternTest
    {
        public BuilderPatternTest()
        {
            ProfileOptimization.SetProfileRoot(@"C:\MyAppProfile");
            ProfileOptimization.StartProfile("default");
        }

        [TestMethod]
        public void Sample1()
        {
            var json = File.ReadAllText("Configs/builderPattern.json").ToJson<dynamic>();
            var ac = new ActorController();

            var obj = (ActionBuilder)Activator.CreateInstance(Assembly.Load("BuilderPattern").GetTypes().First(x => x.FullName == (string)json.className));
            var actor = ac.Construct(obj);

            Console.WriteLine($"{actor.GetType()} 的外观：");
            Console.WriteLine($"性别：{actor.Sex}");
            Console.WriteLine($"性别：{actor.Face}");
            Console.WriteLine($"性别：{actor.Costume}");
            Console.WriteLine($"性别：{actor.Hairstyle}");
        }
    }
}
