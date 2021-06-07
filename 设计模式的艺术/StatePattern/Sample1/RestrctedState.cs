using System;

namespace StatePattern.Sample1
{
    public class RestrctedState : AccountState
    {
        public RestrctedState(AccountState state) => Account = state.Account;

        public override void Deposit(double amount) => Account.Balance += amount;

        public override void Withdraw(double amount) => Console.WriteLine("账号受限，取款失败");

        public override void ComputeInterest() => Console.WriteLine("计算利息！");

        public override void CheckState()
        {
            if (Account.Balance > 0)
            {
                Account.State = new NormalState(this);
            }
            else if (Account.Balance > -2000)
            {
                Account.State = new OverdraftState(this);
            }
        }
    }
}