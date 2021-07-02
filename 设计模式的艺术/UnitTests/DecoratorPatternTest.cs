using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Sample1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DecoratorPatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            Component component = new Window();
            component = new ScrollBarDecorator(component);

            component.Display();
        }

        [TestMethod]
        public void Sample1_1()
        {
            Component component = new Window();
            component = new ScrollBarDecorator(component);
            component = new BlackBorderDecorator(component);

            component.Display();
        }
    }
}
