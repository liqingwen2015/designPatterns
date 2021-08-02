using System;

namespace FacadePattern.Sample2
{
    /// <summary>
    /// 基于移位运算的数据加密类：子系统类
    /// </summary>
    public class NewCipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine("数据加密，将明文转换为密文：");
            var es = "";
            var key = 10;

            foreach (var t in plainText)
            {
                var c = t;

                if (c is >= 'a' and <= 'z')
                {
                    c += (char)(key % 26);

                    if (c > 'z')
                    {
                        c -= (char)26;
                    }

                    if (c < 'A')
                    {
                        c += (char)26;
                    }

                    es += c;
                }
            }


            Console.WriteLine(es);
            return es;
        }
    }
}