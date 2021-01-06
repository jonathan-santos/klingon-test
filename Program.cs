using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var textA = File.ReadAllText("Texts/A.txt");
        Console.WriteLine($"Text A: \n{textA}\n");

        var textB = File.ReadAllText("Texts/B.txt");
        Console.WriteLine($"Text B: \n{textB}");
    }
}
