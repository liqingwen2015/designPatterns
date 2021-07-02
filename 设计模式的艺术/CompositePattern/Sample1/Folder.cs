using System;
using System.Collections.Generic;

namespace CompositePattern.Sample1
{
    /// <summary>
    /// 文件夹类
    /// </summary>
    public class Folder
    {
        private readonly List<Folder> _folders = new List<Folder>();

        private readonly List<ImageFile> _imageFiles = new List<ImageFile>();

        private readonly List<TextFile> _textFiles = new List<TextFile>();

        public string Name { get; set; }

        public Folder(string name)
        {
            Name = name;
        }

        public void AddFolder(Folder folder)
        {
            _folders.Add(folder);
        }

        public void AddImageFile(ImageFile image)
        {
            _imageFiles.Add(image);
        }

        public void AddTextFile(TextFile text)
        {
            _textFiles.Add(text);
        }

        public void KillVirus()
        {
            Console.WriteLine($"**** 对文件夹'{Name}'进行杀毒");

            foreach (var folder in _folders)
            {
                ((Folder)folder).KillVirus();
            }

            foreach (var imageFile in _imageFiles)
            {
                ((ImageFile)imageFile).KillVirus();
            }

            foreach (var textFile in _textFiles)
            {
                textFile.KillVirus();
            }
        }
    }
}