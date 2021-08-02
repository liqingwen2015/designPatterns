using System;
using System.Linq;

namespace FacadePattern.Sample1
{
    /// <summary>
    /// 数据加密类：子系统类
    /// </summary>
    public class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine("数据加密，将明文转换为密文：");
            var es = plainText.Aggregate("", (current, t) => current + t % 7);

            Console.WriteLine(es);
            return es;
        }
    }
}