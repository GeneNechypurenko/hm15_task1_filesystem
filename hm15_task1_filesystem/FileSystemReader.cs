using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task1_filesystem
{
    public class FileSystemReader
    {
        public void ShowFiles(FileSystemDirectory dir)
        {
            if (Directory.Exists(dir.DirectoryPath))
            {
                string[] files = Directory.GetFiles(dir.DirectoryPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Console.WriteLine(fileName);
                }
            }
            else { throw new DirectoryNotFoundException("Directory not found"); }
        }

        public string ReadFileContents(string filename)
        {
            if (File.Exists(filename)) { return File.ReadAllText(filename); }
            else { throw new FileNotFoundException("File not found"); }
        }
    }
}
