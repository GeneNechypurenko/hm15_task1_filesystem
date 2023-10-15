using hm15_task1_filesystem;
using hm15_task4_filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task5_filesystem
{
    public static class WordsCounterExtension
    {
        public static void SearchWord(this FileSystemDirectory dir, string searchWord)
        {
            if (File.Exists(dir.FilePath))
            {
                string content = File.ReadAllText(dir.FilePath);
                int index = 0;
                bool match = false;

                foreach (string word in content.Split())
                {
                    index++;

                    if (word.Equals(searchWord)) { match = true; break; }
                }

                if (match)
                {
                    Console.WriteLine($"\nWord {searchWord} has been found in {Path.GetFileName(dir.FilePath)} file at {index} position");
                }
                else
                {
                    Console.WriteLine($"\nNo mathces with word '{searchWord}' hasn't been found");
                }
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        public static void CountWords(this FileSystemDirectory dir, string searchWord)
        {
            if (File.Exists(dir.FilePath))
            {
                string content = File.ReadAllText(dir.FilePath);
                int count = 0;

                foreach (string word in content.Split())
                {
                    if (word.Equals(searchWord)) { count++; }
                }

                if (count > 0)
                {
                    Console.WriteLine($"\nWord {searchWord} has been found in {Path.GetFileName(dir.FilePath)} file {count} times");
                }
                else
                {
                    Console.WriteLine($"\nNo mathces with word '{searchWord}' hasn't been found");
                }
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }

        public static void CountReversedWords(this FileSystemDirectory dir, string searchWord)
        {
            if (File.Exists(dir.FilePath))
            {
                string content = File.ReadAllText(dir.FilePath);
                int count = 0;
                string reversedWord = new string(searchWord.Reverse().ToArray());

                foreach (string word in content.Split())
                {
                    if (word.Equals(reversedWord)) { count++; }
                }

                if (count > 0)
                {
                    Console.WriteLine($"\nWord {searchWord} has been found in {Path.GetFileName(dir.FilePath)} file {count} times");
                }
                else
                {
                    Console.WriteLine($"\nNo mathces with word '{searchWord}' hasn't been found");
                }
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }
    }
}
