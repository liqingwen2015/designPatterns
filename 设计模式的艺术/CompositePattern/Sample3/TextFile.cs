using System;

namespace CompositePattern.Sample3
{
    /// <summary>
    /// 文本文件类：叶子构件
    /// </summary>
    public class TextFile : AbstractFile
    {
        public string Name { get; set; }

        public TextFile(string name)
        {
            Name = name;
        }

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("对不起，不支持该方法！");
            return null;
        }

        public override void KillVirus()
        {
            // 模拟杀毒
            Console.WriteLine($"----对文本文件'{Name}'进行杀毒");
        }
    }
}