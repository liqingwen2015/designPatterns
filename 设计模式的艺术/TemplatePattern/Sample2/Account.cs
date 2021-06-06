using System;

namespace TemplatePattern.Sample2
{
    public abstract class Account
    {
        public bool Validate(string account, string password)
        {
            Console.WriteLine("账号：" + account);
            Console.WriteLine("密码：" + password);

            if (account.Equals("张无忌") && password.Equals("123456"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 基本方法 - 抽象方法
        /// </summary>
        public abstract void CaculateInterest();

        /// <summary>
        /// 基本方法 - 具体方法
        /// </summary>
        public void Display()
        {
            Console.WriteLine("显示利息！");
        }

        public void Handle(string account, string password)
        {
            if (!Validate(account, password))
            {
                Console.WriteLine("账户或密码错误！");
                return;
            }

            CaculateInterest();
            Display();
        }

        
    }
}