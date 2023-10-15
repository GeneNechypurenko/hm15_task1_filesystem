using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task1_filesystem
{
    public class FileSystemManager<T>
    {
        public void SaveToFile(FileSystemDirectory dir, T data)
        {
            if (!Directory.Exists(dir.DirectoryPath)) { Directory.CreateDirectory(dir.DirectoryPath); }

            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(dir.FilePath, jsonData);
        }

        public T? LoadFromFile(FileSystemDirectory dir)
        {
            if (File.Exists(dir.FilePath))
            {
                string jsonData = File.ReadAllText(dir.FilePath);
                T data = JsonConvert.DeserializeObject<T>(jsonData);

                return data;
            }
            else { throw new FileNotFoundException("File not found."); }
        }
    }
}
