using hm15_task1_filesystem;
using hm15_task4_filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm15_task6_filesystem
{
    public static class TextStatisticsExtension
    {
        public static void ShowTextStatistics(this FileSystemDirectory dir)
        {
            if (File.Exists(dir.FilePath))
            {
                string content = File.ReadAllText(dir.FilePath);

                char[] sentenceSeparators = { '.', '!', '?' };
                int sentenceCount = 0;
                int uppercaseCount = 0;
                int lowercaseCount = 0;
                int vowelCount = 0;
                int consonantCount = 0;
                int digitCount = 0;

                foreach (char separator in sentenceSeparators)
                {
                    sentenceCount += content.Split(separator).Length - 1;
                }

                foreach (char c in content)
                {
                    if (char.IsUpper(c)) { uppercaseCount++; }
                    else if (char.IsLower(c)) { lowercaseCount++; }
                    if ("aeiouAEIOU".Contains(c)) { vowelCount++; }
                    else if (char.IsLetter(c)) { consonantCount++; }
                    else if (char.IsDigit(c)) { digitCount++; }
                }

                Console.WriteLine($"\nStatistics for {Path.GetFileName(dir.FilePath)} file:");
                Console.WriteLine($"Sentences: {sentenceCount}");
                Console.WriteLine($"Uppercase letters: {uppercaseCount}");
                Console.WriteLine($"Lowercase letters: {lowercaseCount}");
                Console.WriteLine($"Vowels: {vowelCount}");
                Console.WriteLine($"Consonants: {consonantCount}");
                Console.WriteLine($"Digits: {digitCount}");
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }
        }
    }
}
