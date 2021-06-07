using System;

namespace StatePattern.Sample1
{
    /// <summary>
    /// 银行账户（环境类）
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 状态（维持一个队抽象状态对象的引用）
        /// </summary>
        public AccountState State { get; set; }

        public string Owner { get; set; }

        public double Balance { get; set; }

        public Account(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
            State = new NormalState(this);
            Console.WriteLine($"{Owner}开户，初始金额为{balance}");
            Console.WriteLine("------------------");
        }

        public void Deposite(double amount)
        {
            Console.WriteLine($"{Owner}存款{amount}");
            State.Deposit(amount);
            Console.WriteLine($"现在余额为{Balance}");
            Console.WriteLine($"现在账户状态为{State.GetType().Name}");
            Console.WriteLine("------------------");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"{Owner}取款{amount}");
            State.Withdraw(amount);
            Console.WriteLine($"现在余额为{Balance}");
            Console.WriteLine($"现在账户状态为{State.GetType().Name}");
            Console.WriteLine("------------------");
        }

        public void ComputerInterest() => State.ComputeInterest();
    }
}