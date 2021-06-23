using System;

namespace PrototypePattern.Sample4
{
    public class Attachment
    {
        public string Name { get; set; }

        public void Download() => Console.WriteLine($"下载附件，文件名为{Name}");
    }
}