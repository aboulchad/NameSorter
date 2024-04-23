using System;
using System.Collections.Generic;
using System.IO;

public static class FileReadWrite
{
    public static List<string> ReadNamesFromFile(string filePath)
    {
        List<string> names = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        return names;
    }

    public static void WriteNamesToFile(List<string> names, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing file: {ex.Message}");
        }
    }
}