using System;
using System.Collections.Generic;
using System.Linq;

public class SortingService
{
    public void SortNames(string inputFilePath, string outputFilePath)
    {
        List<string> names = FileReadWrite.ReadNamesFromFile(inputFilePath);
        if (names.Count == 0)
        {
            Console.WriteLine("No names found in the input file.");
            return;
        }
        //function that sorts the names
        names.Sort();

        Console.WriteLine("Sorted names: ");
        Console.WriteLine("--------------");
        for (int i = 0; i < names.Count; i++) {
            Console.WriteLine(names[i].ToString());
        }
        Console.WriteLine("--------------");
        FileReadWrite.WriteNamesToFile(names, outputFilePath);
    }
}
