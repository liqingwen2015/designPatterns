using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern.Sample1;

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
    }
}
