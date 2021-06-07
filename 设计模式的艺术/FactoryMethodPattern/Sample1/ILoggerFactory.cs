namespace FactoryMethodPattern.Sample1
{
    /// <summary>
    /// 日志记录器工厂借口：抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}