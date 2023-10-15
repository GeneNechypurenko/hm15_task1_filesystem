using hm15_task1_filesystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task4_filesystem
{
    public static class StatisticsCounter
    {
        public static void CountElements(this FileSystemDirectory dir)
        {
            if (File.Exists(dir.FilePath))
            {
                string jsonData = File.ReadAllText(dir.FilePath);
                int[] data = JsonConvert.DeserializeObject<int[]>(jsonData);
                int count = 0;

                foreach (int el in data) { count++; }

                Console.WriteLine($"elements in file {Path.GetFileName(dir.FilePath)} = {count}");
            }
            else { throw new FileNotFoundException("File not found"); }
        }
    }
}
