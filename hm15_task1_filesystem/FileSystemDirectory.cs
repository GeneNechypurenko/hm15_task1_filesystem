using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task1_filesystem
{
    public class FileSystemDirectory
    {
        private string _directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saved files");
        private string _filePath;
        public string DirectoryPath
        {
            get { return _directoryPath; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = Path.Combine(_directoryPath, value); }
        }
    }
}
