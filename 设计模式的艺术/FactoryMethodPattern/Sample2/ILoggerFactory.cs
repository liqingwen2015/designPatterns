using FactoryMethodPattern.Sample1;

namespace FactoryMethodPattern.Sample2
{
    /// <summary>
    /// 日志记录器工厂借口：抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();

        ILogger CreateLogger(string args);

        ILogger CreateLogger(object obj);

    }
}