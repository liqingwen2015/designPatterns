using System;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Sample1
{
    /// <summary>
    /// 图像文件类
    /// </summary>
    public class ImageFile
    {
        public string Name { get; set; }

        public ImageFile(string name)
        {
            Name = name;
        }

        public void KillVirus()
        {
            Console.WriteLine($"---- 对图像文件'{Name}'进行杀毒");
        }
    }
}
