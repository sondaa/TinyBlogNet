﻿using System.Collections.Generic;
using System.IO;

namespace TinyBlogNet.IO
{
    public class FileSystem
    {
        private readonly string _path;

        internal FileSystem()
        {
            
        }

        public FileSystem(string path)
        {
            _path = path;
        }

        public virtual IEnumerable<FileBase> GetFiles(string pattern = "*.*")
        {
            var data = new DirectoryInfo(_path);

            foreach (var file in data.EnumerateFiles(pattern, SearchOption.TopDirectoryOnly))
            {
               yield return new File(file);
            }
        }
    }
}