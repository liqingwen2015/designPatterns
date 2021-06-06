using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatePattern.Sample1;
using StatePattern.Sample2;
using StatePattern.Sample3;

namespace UnitTests
{
    [TestClass]
    public class StatePatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            var account = new Account("段誉", 0.0);
            account.Deposite(1000);

            account.Withdraw(2000);
            account.Deposite(3000);
            account.Withdraw(4000);
            account.Withdraw(1000);

            account.ComputerInterest();
        }

        [TestMethod]
        public void Sample2()
        {
            var s1 = new Switch("开关1");
            var s2 = new Switch("开关2");

            s1.On();
            s2.On();

            s1.Off();
            s2.Off();

            s2.On();
            s1.On();
        }

        [TestMethod]
        public void Sample3()
        {
            var screen = new Screen();
            screen.OnClick();
            screen.OnClick();
            screen.OnClick();
        }

    }
}
