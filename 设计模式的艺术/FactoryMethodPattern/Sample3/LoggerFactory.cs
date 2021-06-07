using FactoryMethodPattern.Sample1;

namespace FactoryMethodPattern.Sample3
{
    /// <summary>
    /// 改为抽象类
    /// </summary>
    public abstract class LoggerFactory
    {
        /// <summary>
        /// 在工厂类中直接调用日志记录器类的业务方法
        /// </summary>
        public void WriteLog()
        {
            CreateLogger().WriteLog();
        }

        public abstract ILogger CreateLogger();
    }
}