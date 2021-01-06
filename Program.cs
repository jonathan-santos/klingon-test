using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var textA = File.ReadAllText("Texts/A.txt");
        Console.WriteLine($"Text A preposition ammount: {getPrepositionAmmount(textA)}");
        Console.WriteLine($"Text A verb ammount: {getVerbAmmount(textA)}");
        Console.WriteLine($"Text A verb ammount (first person): {getVerbAmmount(textA, firstPersonOnly: true)}");

        var textB = File.ReadAllText("Texts/B.txt");
        Console.WriteLine($"\nText B preposition ammount: {getPrepositionAmmount(textB)}");
        Console.WriteLine($"Text B verb ammount: {getVerbAmmount(textB)}");
        Console.WriteLine($"Text B verb ammount (first person): {getVerbAmmount(textB, firstPersonOnly: true)}");
    }

    static bool isLetterFoo(char letter) {
        return letter == 's' || letter == 'l' || letter == 'f' || letter == 'w' || letter == 'k';
    }

    static int getPrepositionAmmount(string text) {
        var words = text.Split(" ");
        int prepositionAmmount = 0;

        foreach (var word in words) {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = !isLetterFoo(word[2]);

            if (isLength3 && doesntHaveD && isLastLetterTypeBar)
                prepositionAmmount++;
        }

        return prepositionAmmount;
    }

    static int getVerbAmmount(string text, bool firstPersonOnly = false) {
        var words = text.Split(" ");
        int verbAmmount = 0;

        foreach (var word in words) {
            var isLengthEqualOrGreaterThan8 = word.Length >= 8;
            var isLastLetterTypeFoo = isLetterFoo(word[word.Length - 1]);

            if (firstPersonOnly && isLetterFoo(word[0]))
                continue;

            if (isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo)
                verbAmmount++;
        }

        return verbAmmount;
    }
}
