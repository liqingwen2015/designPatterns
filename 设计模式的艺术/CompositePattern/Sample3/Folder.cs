using System;
using System.Collections.Generic;

namespace CompositePattern.Sample3
{
    public class Folder : AbstractFile
    {
        private readonly List<AbstractFile> _files = new List<AbstractFile>();

        public string Name { get; set; }

        public Folder(string name)
        {
            Name = name;
        }

        public override void Add(AbstractFile file)
        {
            _files.Add(file);
        }

        public override void Remove(AbstractFile file)
        {
            _files.Remove(file);
        }

        public override AbstractFile GetChild(int i)
        {
            return _files[i];
        }

        public override void KillVirus()
        {
            Console.WriteLine($"**** 对文件夹'{Name}'进行杀毒");

            foreach (var file in _files)
            {
                file.KillVirus();
            }
        }
    }
}