namespace FactoryMethodPattern.Sample1
{
    /// <summary>
    /// 数据库日志记录器工厂类：具体工厂
    /// </summary>
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}