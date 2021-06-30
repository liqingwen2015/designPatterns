using System;
using AdapterPattern.Sample1;
using BridgePattern.Sample2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BridgePatternTest : TestBase
    {
        protected override string PatternConfigJsonPath => "bridgePattern";
        protected override string AssemblyName => "BridgePattern";

        [TestMethod]
        public void Sample1()
        {
            var (image, imp) = CreateInstance<Image, IImageImp>();
            image.SetImageImp(imp);
            image.ParseFile("小龙女");
        }
    }
}