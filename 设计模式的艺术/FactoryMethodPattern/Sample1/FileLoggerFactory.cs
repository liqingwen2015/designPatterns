namespace FactoryMethodPattern.Sample1
{
    /// <summary>
    /// 文件日志记录器工厂类：具体工厂
    /// </summary>
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}