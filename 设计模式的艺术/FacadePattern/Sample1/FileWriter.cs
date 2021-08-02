using System;
using System.IO;

namespace FacadePattern.Sample1
{
    /// <summary>
    /// 文件保存类：子系统类
    /// </summary>
    public class FileWriter
    {
        public void Write(string encryptStr, string fileNameDes)
        {
            Console.WriteLine("保存密文，写入文件");
            File.WriteAllText(fileNameDes, encryptStr);
        }
    }
}