using System;

namespace PrototypePattern.Sample2
{
    public abstract class Prototype : ICloneable
    {
        public abstract object Clone();
    }
}