using AbstractFactoryPattern.Sample2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AbstractFactoryPatternTest
    {
        [TestMethod]
        public void Sample2()
        {
            ISkinFactory factory = new SpringSkinFactory();

            var bt = factory.CreateButton();
            var tf = factory.CreaTextField();
            var cb = factory.CreateComboBox();

            bt.Display();
            tf.Display();
            cb.Display();
        }
    }
}