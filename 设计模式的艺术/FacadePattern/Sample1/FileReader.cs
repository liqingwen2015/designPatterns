using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Sample1
{
    /// <summary>
    /// 文件读取类：子系统类
    /// </summary>
    public class FileReader
    {
        public string Read(string fileNameSrc)
        {
            Console.WriteLine("读取文件，获取明文：");
            return File.ReadAllText(fileNameSrc);
        }
    }
}

