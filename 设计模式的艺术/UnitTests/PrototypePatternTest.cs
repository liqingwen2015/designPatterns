using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern.Sample1;
using PrototypePattern.Sample4;
using PrototypePattern.Sample5;
using WeeklyLog = PrototypePattern.Sample3.WeeklyLog;

namespace UnitTests
{
    [TestClass]
    public class PrototypePatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            Prototype obj1 = new ConcretePrototype()
            {
                Attr = "Sunny"
            };

            var obj2 = (ConcretePrototype)obj1.Clone();
            Console.WriteLine(obj2.Attr);
        }

        [TestMethod]
        public void Sample2()
        {
            Prototype obj1 = new ConcretePrototype()
            {
                Attr = "Sunny"
            };

            var obj2 = (ConcretePrototype)obj1.Clone();
            Console.WriteLine(obj2.Attr);
        }

        [TestMethod]
        public void Sample3()
        {
            // 创建原型对象
            var previousLog = new WeeklyLog()
            {
                Name = "张无忌",
                Date = "第 12 周",
                Content = "这周工作很忙，每天加班！"
            };

            Console.WriteLine("****周报****");
            Console.WriteLine($"周次：{previousLog.Date}");
            Console.WriteLine($"姓名：{previousLog.Name}");
            Console.WriteLine($"内容：{previousLog.Content}");
            Console.WriteLine("------------------------------");

            var newLog = (WeeklyLog)previousLog.Clone();
            newLog.Date = "第 13 周";
            Console.WriteLine("****周报****");
            Console.WriteLine($"周次：{newLog.Date}");
            Console.WriteLine($"姓名：{newLog.Name}");
            Console.WriteLine($"内容：{newLog.Content}");
            Console.WriteLine("------------------------------");
        }

        [TestMethod]
        public void Sample4()
        {
            var previousLog = new PrototypePattern.Sample4.WeeklyLog();
            var attachment = new Attachment();
            previousLog.Attachment = attachment;

            var newLog = (PrototypePattern.Sample4.WeeklyLog)previousLog.Clone();

            // 比较周报
            Console.WriteLine($"周报是否相同？{previousLog == newLog}");
            Console.WriteLine($"附件是否相同？{previousLog.Attachment == newLog.Attachment}");
        }

        [TestMethod]
        public void Sample5()
        {
            var pm = PrototypeManager.GetPrototypeManager();

            var doc1 = pm.GetOfficialDocument("far");
            doc1.Display();

            var doc2 = pm.GetOfficialDocument("far");
            doc2.Display();
            Console.WriteLine(doc1 == doc2);

            var doc3 = pm.GetOfficialDocument("srs");
            doc3.Display();

            var doc4 = pm.GetOfficialDocument("srs");
            doc4.Display();
            Console.WriteLine(doc3 == doc4);
        }
    }
}
