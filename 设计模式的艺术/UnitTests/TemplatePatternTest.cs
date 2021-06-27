using System.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplatePattern.Sample2;
using TemplatePattern.Sample3;

namespace UnitTests
{
    [TestClass]
    public class TemplatePatternTest
    {
        [TestMethod]
        public void Sample2()
        {
            Account account = new CurrentAccount();
            account.Handle("张无忌", "123456");
        }

        [TestMethod]
        public void Sample3()
        {
            var dv = new SubDataViewer();
            dv.Process();
        }
    }
}