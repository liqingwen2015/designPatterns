using FactoryMethodPattern.Sample1;

namespace FactoryMethodPattern.Sample3
{
    /// <summary>
    /// 数据库日志记录器工厂类：具体工厂
    /// </summary>
    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}