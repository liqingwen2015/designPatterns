using System;
using NiuX.Extensions;

namespace PrototypePattern.Sample4
{
    [Serializable]
    public class WeeklyLog : ICloneable
    {
        public Attachment Attachment { get; set; }
        public string Name { get; set; }

        public string Date { get; set; }

        public string Content { get; set; }

        /// <summary>
        /// 这里替换为深克隆
        /// </summary>
        /// <returns></returns>
        public object Clone() => this.ToJsonString().ToJson<WeeklyLog>();
    }
}