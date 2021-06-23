using System;

namespace PrototypePattern.Sample3
{
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }

        public string Date { get; set; }

        public string Content { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}