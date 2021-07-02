using System;

namespace CompositePattern.Sample3
{
    /// <summary>
    /// 图像文件类：叶子构件
    /// </summary>
    public class ImageFile : AbstractFile
    {
        public string Name { get; set; }

        public ImageFile(string name)
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
            Console.WriteLine($"----对图像文件'{Name}'进行杀毒");
        }

        
    }
}