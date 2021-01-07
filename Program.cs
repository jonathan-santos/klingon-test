using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        foreach(var file in Directory.GetFiles("./Texts"))
        {
            var text = new KlingonText(File.ReadAllText(file));
            var cleanFileName = file.Replace("./Texts\\", "").Replace(".txt", "");
            Console.WriteLine($"Text {cleanFileName} preposition ammount: {text.PrepositionCount}");
            Console.WriteLine($"Text {cleanFileName} verb ammount: {text.VerbCount}");
            Console.WriteLine($"Text {cleanFileName} verb ammount (first person): {text.VerbInFirstPersonCount}");
            Console.WriteLine($"Text {cleanFileName} vocabulary:\n{text.Vocabulary}");
            Console.WriteLine($"Text {cleanFileName} beautiful distinct numbers quantity: {text.BeautifulDistinctNumbers.Length}\n");
        }
    }
}
