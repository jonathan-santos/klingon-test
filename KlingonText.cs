using System;
using System.Collections.Generic;
using System.Linq;

public class KlingonText
{
    static Dictionary<char, int> _letterNumberValues = new Dictionary<char, int> ()
    {
        ['k'] = 0,
        ['b'] = 1,
        ['w'] = 2,
        ['r'] = 3,
        ['q'] = 4,
        ['d'] = 5,
        ['n'] = 6,
        ['f'] = 7,
        ['x'] = 8,
        ['j'] = 9,
        ['m'] = 10,
        ['l'] = 11,
        ['v'] = 12,
        ['h'] = 13,
        ['t'] = 14,
        ['c'] = 15,
        ['g'] = 16,
        ['z'] = 17,
        ['p'] = 18,
        ['s'] = 19
    };
    
    public string Text { get; set; }
    public int PrepositionCount { get; set; }
    public int VerbCount { get; set; }
    public int VerbInFirstPersonCount { get; set; }
    public ulong[] BeautifulDistinctNumbersInText { get; set; }

    public KlingonText(string text)
    {
        Text = text;
        PrepositionCount = GetPrepositionCount();
        VerbCount = GetVerbCount();
        VerbInFirstPersonCount = GetVerbCount(firstPersonOnly: true);
        BeautifulDistinctNumbersInText = GetDistinctNumbersInText();
    }

    bool isLetterFoo(char letter)
    {
        return letter == 's' || letter == 'l' || letter == 'f' || letter == 'w' || letter == 'k';
    }

    int GetPrepositionCount()
    {
        var words = Text.Split(" ");
        int prepositionCount = 0;

        foreach (var word in words) {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = !isLetterFoo(word[2]);

            if (isLength3 && doesntHaveD && isLastLetterTypeBar)
                prepositionCount++;
        }

        return prepositionCount;
    }

    int GetVerbCount(bool firstPersonOnly = false)
    {
        var words = Text.Split(" ");
        int verbCount = 0;

        foreach (var word in words) {
            var isLengthEqualOrGreaterThan8 = word.Length >= 8;
            var isLastLetterTypeFoo = isLetterFoo(word[word.Length - 1]);

            if (firstPersonOnly && isLetterFoo(word[0]))
                continue;

            if (isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo)
                verbCount++;
        }

        return verbCount;
    }

    ulong[] GetDistinctNumbersInText()
    {
        var words = Text.Split(" ");
        ulong[] numbers = new ulong[words.Length];

        for (var i = 0; i < words.Length; i++)
            numbers[i] = ConvertWordToNumber(words[i]);
        
        return numbers.Where(n => n >= 440566 && n % 3 == 0)
            .Distinct<ulong>()
            .ToArray();;
    }

    ulong ConvertWordToNumber(string word)
    {
        ulong value = 0;

        for (var i = 0; i < word.Length; i++)
        {
            var add = _letterNumberValues[word[i]] * Math.Pow(20, i); 
            value += (ulong) add;
        }

        return value;
    }
}
