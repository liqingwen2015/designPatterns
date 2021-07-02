using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Sample1;
using CompositePattern.Sample3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Folder = CompositePattern.Sample1.Folder;
using ImageFile = CompositePattern.Sample1.ImageFile;

namespace UnitTests
{
    [TestClass]
    public class CompositePatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            var folder1 = new Folder("Sunny 的资料");
            var folder2 = new Folder("图像文件");
            var folder3 = new Folder("文本文件");

            var image1 = new ImageFile("小龙女.jpg");
            var image2 = new ImageFile("张无忌.gif");

            var text1 = new CompositePattern.Sample1.TextFile("九阴真经.txt");
            var text2 = new CompositePattern.Sample1.TextFile("葵花宝典.doc");

            folder2.AddImageFile(image1);
            folder2.AddImageFile(image2);
            folder3.AddTextFile(text1);
            folder3.AddTextFile(text2);
            folder1.AddFolder(folder2);
            folder1.AddFolder(folder3);

            folder1.KillVirus();
        }

        [TestMethod]
        public void Sample3()
        {
            AbstractFile folder1 = new CompositePattern.Sample3.Folder("Sunny 的资料");
            var folder2 = new CompositePattern.Sample3.Folder("图像文件");
            var folder3 = new CompositePattern.Sample3.Folder("文本文件");
            var folder4 = new CompositePattern.Sample3.Folder("视频文件");

            var file1 = new CompositePattern.Sample3.ImageFile("小龙女.jpg");
            var file2 = new CompositePattern.Sample3.ImageFile("张无忌.gif");
            var file3 = new CompositePattern.Sample3.TextFile("九阴真经.txt");
            var file4 = new CompositePattern.Sample3.TextFile("葵花宝典.doc");
            var file5 = new CompositePattern.Sample3.ImageFile("笑傲江湖.rmvb");

            folder2.Add(file1);
            folder2.Add(file2);
            folder3.Add(file3);
            folder3.Add(file4);
            folder4.Add(file5);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            folder1.KillVirus();
        }
    }
}
