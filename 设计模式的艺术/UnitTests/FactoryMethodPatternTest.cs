using System.Linq.Expressions;
using FactoryMethodPattern.Sample1;
using FactoryMethodPattern.Sample3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FactoryMethodPatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            ILoggerFactory factory = new FileLoggerFactory();
            var logger = factory.CreateLogger();
            logger.WriteLog();
        }

        [TestMethod]
        public void Sample3()
        {
            LoggerFactory factory = new FactoryMethodPattern.Sample3.DatabaseLoggerFactory();
            factory.WriteLog();
        }
    }
}