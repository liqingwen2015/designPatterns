using System;

namespace CompositePattern.Sample1
{
    /// <summary>
    /// 文本文件类
    /// </summary>
    public class TextFile
    {
        public string Name { get; set; }

        public TextFile(string name)
        {
            Name = name;
        }

        public void KillVirus()
        {
            Console.WriteLine($"---- 对文本文件'{Name}'进行杀毒");
        }
    }
}