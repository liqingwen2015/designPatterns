using System;

namespace PrototypePattern.Sample5
{
    /// <summary>
    /// 抽象公文接口，也可以定义为抽象类，提供 clone() 方法的实现，将业务方法声明为抽象方法
    /// </summary>
    public interface IOfficialDocument : ICloneable
    {

        void Display();

    }
}