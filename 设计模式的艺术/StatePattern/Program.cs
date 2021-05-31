using System;
using StatePattern.Sample2;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample1
            {
                //var account = new Account("段誉", 0.0);
                //account.Deposite(1000);

                //account.Withdraw(2000);
                //account.Deposite(3000);
                //account.Withdraw(4000);
                //account.Withdraw(1000);

                //account.ComputerInterest();
            }

            // sample2
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

            //Console.WriteLine("Hello World!");
        }
    }
}
