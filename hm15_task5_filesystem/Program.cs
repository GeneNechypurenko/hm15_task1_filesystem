using hm15_task1_filesystem;
using hm15_task4_filesystem;
using hm15_task5_filesystem;

FileSystemDirectory fileSystemDirectory = new FileSystemDirectory();
FileSystemManager<string> fileSystemManager = new FileSystemManager<string>();
FileSystemReader fileSystemReader = new FileSystemReader();


fileSystemDirectory.FilePath = "text.json";

fileSystemReader.ShowFiles(fileSystemDirectory);

string text =
    "In the land of dreams, where dreams come to life, you can dream any dream you desire.\n" +
    "Dreams hold the key to unlocking the secrets of the dreamer's heart. So, dream big,\n" +
    "dream often, and let your dreams guide you on your journey.";

fileSystemManager.SaveToFile(fileSystemDirectory, text);

Console.WriteLine($"\r\n{text}");

fileSystemDirectory.SearchWord("dream");
fileSystemDirectory.CountWords("dream");
fileSystemDirectory.CountReversedWords("maerd");