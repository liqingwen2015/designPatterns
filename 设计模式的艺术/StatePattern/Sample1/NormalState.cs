using System;

namespace StatePattern.Sample1
{
    /// <summary>
    /// 正常状态
    /// </summary>
    public class NormalState : AccountState
    {
        public NormalState(Account account) => Account = account;

        public NormalState(AccountState state) => Account = state.Account;

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

        public override void ComputeInterest() => Console.WriteLine("正常状态，无需支付利息！");

        public override void CheckState()
        {
            if (Account.Balance > -2000 && Account.Balance <= 0)
            {
                Account.State = new OverdraftState(this);
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