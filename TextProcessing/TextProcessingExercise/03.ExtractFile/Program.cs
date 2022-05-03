using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int slashIndex = path.LastIndexOf('\\');
            int pointIndex = path.IndexOf('.');
            pointIndex += 1;
            slashIndex += 1;

            string fileExtension = path.Substring(pointIndex, path.Length - pointIndex);
            string fileName = path.Substring(slashIndex, pointIndex - slashIndex - 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
