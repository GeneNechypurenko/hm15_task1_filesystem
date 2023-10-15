using hm15_task1_filesystem;
using hm15_task4_filesystem;

FileSystemDirectory fileSystemDirectory = new FileSystemDirectory();
FileSystemManager<int[]> fileManager = new FileSystemManager<int[]>();
FileSystemReader fileSystemReader = new FileSystemReader();

Random random = new Random();

int size = 10000;
int[] array = new int[size];
int[] odds = new int[size];
int[] evens = new int[size];




for (int i = 0; i < array.Length; ++i) { array[i] = random.Next(1, 99); }

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1) { odds[i] = array[i]; }
    else { evens[i] = array[i]; }
}

odds = odds.Where(x => x != 0).ToArray();
evens = evens.Where(x => x != 0).ToArray();



Console.WriteLine("Files in directory:");
fileSystemReader.ShowFiles(fileSystemDirectory);
Console.WriteLine();

fileSystemDirectory.FilePath = "odds.json";
fileManager.SaveToFile(fileSystemDirectory, odds);
Console.Write("Odd numbers of ");
fileSystemDirectory.CountElements();

fileSystemDirectory.FilePath = "evens.json";
fileManager.SaveToFile(fileSystemDirectory, evens);
Console.Write("Even numbers of ");
fileSystemDirectory.CountElements();