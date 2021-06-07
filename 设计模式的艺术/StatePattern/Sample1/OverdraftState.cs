using System;

namespace StatePattern.Sample1
{
    /// <summary>
    /// 透支状态
    /// </summary>
    public class OverdraftState : AccountState
    {
        public OverdraftState(AccountState state) => Account = state.Account;

        public override void Deposit(double amount)
        {
            Account.Balance += amount;
            CheckState();
        }

        public override void Withdraw(double amount)
        {
            Account.Balance -= amount;
            CheckState();
        }

        public override void ComputeInterest() => Console.WriteLine("计算利息");

        public override void CheckState()
        {
            if (Account.Balance > 0)
            {
                Account.State = new NormalState(this);
            }
            else if (Account.Balance == -2000)
            {
                Account.State = new RestrctedState(this);
            }
            else if (Account.Balance < -2000)
            {
                Console.WriteLine("操作受限！");
            }
        }
    }
}