using hm15_task1_filesystem;

FileSystemManager<string> fileSystemManager = new FileSystemManager<string>();
FileSystemDirectory fileSystemDirectory = new FileSystemDirectory();

fileSystemDirectory.FilePath = "Task_1.json";

string greeting = "Hello User it is Task 1 test message!";
fileSystemManager.SaveToFile(fileSystemDirectory, greeting);



Console.WriteLine("---------------------------------------------");



FileSystemReader fileSystemReader = new FileSystemReader();

Console.WriteLine("Available files in directory:\n");
fileSystemReader.ShowFiles(fileSystemDirectory);

Console.WriteLine("\nEnter file name to see it's content");
string filename = Console.ReadLine();
string dirPath = fileSystemDirectory.DirectoryPath;

Console.WriteLine("\nFile content:");
Console.WriteLine(fileSystemReader.ReadFileContents(Path.Combine(dirPath, filename)));