using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var textA = File.ReadAllText("Texts/A.txt");
        Console.WriteLine($"Text A preposition ammount: {getPrepositionAmmount(textA)}");

        var textB = File.ReadAllText("Texts/B.txt");
        Console.WriteLine($"Text B preposition ammount: {getPrepositionAmmount(textB)}");
    }

    static int getPrepositionAmmount(string text) {
        var words = text.Split(" ");
        int prepositionAmmount = 0;

        foreach (var word in words) {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = word[2] != 's' && word[2] != 'l' && word[2] != 'f' && word[2] != 'w' && word[2] != 'k';

            if (isLength3 && doesntHaveD && isLastLetterTypeBar)
                prepositionAmmount++;
        }

        return prepositionAmmount;
    }
}
