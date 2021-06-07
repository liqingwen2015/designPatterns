using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactoryPattern.Sample1;
using SimpleFactoryPattern.Sample2;

namespace UnitTests
{
    [TestClass]
    public class SimpleFactoryPatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            var product = Factory.GetProduct("A");
            product.MethodSame();
            product.MethodDiff();
        }

        [TestMethod]
        public void Sample2()
        {
            var chart = ChartFactory.GetChart("histogram");
            chart.Display();
        }
    }
}