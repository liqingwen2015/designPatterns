namespace StatePattern
{
    public class Account
    {
        public string State { get; set; }

        public int Balance { get; set; }

        public void Deposite()
        {
            StateCheck();
        }

        public void Withdraw()
        {
            if (State == "" || State == "")
            {
                StateCheck();
            }
            else
            {
                // 取款受限
            }
        }

        public void ComputerInterest()
        {
            if (State == "OverdraftState" || State == "RestrictedState")
            {
                // 计算利息
            }
        }

        /// <summary>
        /// 状态检查和转换操作
        /// </summary>
        public void StateCheck()
        {
            if (Balance >= 0)
            {
                State = "NormalState";
            }
            else if (Balance > -2000 && Balance < 0)
            {
                State = "OverdraftState";
            }
            else if (Balance == -2000)
            {
                State = "RestrictedState";
            }
            else if (Balance < -2000)
            {
                // 操作受限
            }
        }
    }
}