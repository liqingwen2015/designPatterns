using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Sample1;
using FacadePattern.Sample2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FacadePatternTest : TestBase
    {
        protected override string PatternConfigJsonPath => "facadePattern";
        protected override string AssemblyName => "FacadePattern";

        [TestMethod]
        public void Sample1()
        {
            var ef = new EncrytFacade();
            ef.FileEncrypt("facade/src.txt", "facade/des.txt");
        }

        [TestMethod]
        public void Sample2()
        {
            AbstractEncryptFacade ef=CreateInstance<NewEncryptFacade>();
            ef.FileEncrypt("facade/src.txt", "facade/des.txt");
        }
    }
}
