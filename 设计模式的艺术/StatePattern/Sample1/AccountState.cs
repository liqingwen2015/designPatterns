namespace StatePattern.Sample1
{
    public abstract class AccountState
    {
        public Account Account { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void ComputeInterest();
        public abstract void CheckState();
    }
}