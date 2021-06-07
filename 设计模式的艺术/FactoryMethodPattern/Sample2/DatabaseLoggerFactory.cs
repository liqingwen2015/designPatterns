using FactoryMethodPattern.Sample1;

namespace FactoryMethodPattern.Sample2
{
    /// <summary>
    /// 数据库日志记录器工厂类：具体工厂
    /// </summary>
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // 使用默认方式连接数据库
            return new DatabaseLogger();
        }

        public ILogger CreateLogger(string args)
        {
            // 使用参数 args 作为连接字符串来连接数据库
            return new DatabaseLogger();
        }

        public ILogger CreateLogger(object obj)
        {
            // 使用封装在参数 obj 中的连接字符串来连接数据库
            return new DatabaseLogger();
        }
    }
}