using hm15_task1_filesystem;

FileSystemDirectory fileSystemDirectory = new FileSystemDirectory();
FileSystemManager<int[]> fileSystemManager = new FileSystemManager<int[]>();
FileSystemReader fileSystemReader = new FileSystemReader();

fileSystemDirectory.FilePath = "Task_2_3_array.json";

string fileContents = fileSystemReader.ReadFileContents(fileSystemDirectory.FilePath);

Console.WriteLine("File Task_2_3_array.json content:\n");
Console.WriteLine(fileContents);



Console.WriteLine("\n----------------------------------------------\n");



int size = 5;
int[] array = new int[size];

Console.WriteLine("Enter values of array elements:\n");

for (int i = 0; i < array.Length; ++i)
{
    Console.Write($"index[{i}] = ");
    array[i] = int.Parse(Console.ReadLine());
}

fileSystemManager.SaveToFile(fileSystemDirectory, array);

Console.WriteLine("\nData saved to Task_2_3_array.json file");



Console.WriteLine("\n----------------------------------------------\n");



int[] loadedArray = new int[array.Length];
loadedArray = fileSystemManager.LoadFromFile(fileSystemDirectory);

Console.WriteLine("Loaded data from Task_2_3_array.json file:\n");

for(int i = 0; i < loadedArray.Length; ++i)
{
    Console.WriteLine($"index[{i}] = {loadedArray[i]}");
}