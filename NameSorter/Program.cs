using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.WriteLine("Start sorting file by pressing Enter key!");
        Console.ReadLine();
        string inputFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "unsorted-names-list.txt");
        string outputFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sorted-names-list.txt");

        SortingService sortingService = new SortingService();
        sortingService.SortNames(inputFilePath, outputFilePath);

        Console.WriteLine("Names sorted & written to sorted-names-list.txt file");
    }
}
