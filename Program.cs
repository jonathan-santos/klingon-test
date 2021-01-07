using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        var textA = new KlingonText(File.ReadAllText("Texts/A.txt"));
        Console.WriteLine($"Text A preposition ammount: {textA.PrepositionCount}");
        Console.WriteLine($"Text A verb ammount: {textA.VerbCount}");
        Console.WriteLine($"Text A verb ammount (first person): {textA.VerbInFirstPersonCount}");
        Console.WriteLine($"Text A vocabulary: {textA.Vocabulary}");
        Console.WriteLine($"Text A beautiful distinct numbers quantity: {textA.BeautifulDistinctNumbers.Length}");

        var textB = new KlingonText(File.ReadAllText("Texts/B.txt"));
        Console.WriteLine($"\nText B preposition ammount: {textB.PrepositionCount}");
        Console.WriteLine($"Text B verb ammount: {textB.VerbCount}");
        Console.WriteLine($"Text B verb ammount (first person): {textB.VerbInFirstPersonCount}");
        Console.WriteLine($"Text B vocabulary: {textB.Vocabulary}");
        Console.WriteLine($"Text B beautiful distinct numbers quantity: {textB.BeautifulDistinctNumbers.Length}");
    }
}
