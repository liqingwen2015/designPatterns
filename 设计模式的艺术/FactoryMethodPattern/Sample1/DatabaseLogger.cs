using System;

namespace FactoryMethodPattern.Sample1
{
    /// <summary>
    /// 数据库日志记录器：具体产品
    /// </summary>
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志记录。");
        }
    }
}