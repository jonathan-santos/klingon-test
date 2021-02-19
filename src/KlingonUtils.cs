using System;
using System.Collections.Generic;

public static class KlingonUtils
{
    static Dictionary<char, int> _letterNumberValues = new()
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

    public static bool IsWordPreposition(string word)
    {
        if (word.Length < 3)
            return false;
        
        var isLength3 = word.Length == 3;
        var doesntHaveD = !word.Contains('d');
        var isLastLetterTypeBar = !KlingonUtils.IsLetterFoo(word[2]);

        return isLength3 && doesntHaveD && isLastLetterTypeBar;
    }

    public static bool IsWordVerb(string word)
    {
        var isLengthEqualOrGreaterThan8 = word.Length >= 8;
        var isLastLetterTypeFoo = KlingonUtils.IsLetterFoo(word[word.Length - 1]);

        return isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo;
    }

    public static bool isVerbInFirstPerson(string verb)
    {
        return !IsLetterFoo(verb[0]);
    }

    public static bool IsLetterFoo(char letter)
    {
        return letter == 's' || letter == 'l' || letter == 'f' || letter == 'w' || letter == 'k';
    }

    public static int ConvertLetterToNumber(char letter)
    {
        if (!_letterNumberValues.ContainsKey(letter))
            return 0;

        return _letterNumberValues[letter];
    }

    public static ulong ConvertWordToNumber(string word)
    {
        ulong value = 0;

        for (var i = 0; i < word.Length; i++)
        {
            var add = ConvertLetterToNumber(word[i]) * Math.Pow(20, i); 
            value += (ulong) add;
        }

        return value;
    }

    public static bool IsNumberBeautiful(ulong number)
    {
        return number >= 440566 && number % 3 == 0;
    }

    public static int CompareWordsLexically(string word1, string word2)
    {
        for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++) { 
            if (word1[i] == word2[i]) 
                continue;

            return _letterNumberValues[word1[i]] > _letterNumberValues[word2[i]] ? 1 : -1; 
	    } 
	    return word1.Length > word2.Length ? 1 : -1; 
    }
}
