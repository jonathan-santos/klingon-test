using System;
using System.Linq;

public class KlingonText
{
    public string Text { get; }
    public int PrepositionCount { get; }
    public int VerbCount { get; }
    public int VerbInFirstPersonCount { get; }
    public string Vocabulary { get; }
    public ulong[] BeautifulDistinctNumbers { get; }

    public KlingonText(string text)
    {
        Text = text;
        PrepositionCount = GetPrepositionCount();
        VerbCount = GetVerbCount();
        VerbInFirstPersonCount = GetVerbCount(firstPersonOnly: true);
        Vocabulary = GetVocabulary();
        BeautifulDistinctNumbers = GetBeautifulDistinctNumbers();
    }

    int GetPrepositionCount()
    {
        var words = Text.Split(" ");
        int prepositionCount = 0;

        foreach (var word in words) {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = !KlingonAlphabetUtils.isLetterFoo(word[2]);

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
            var isLastLetterTypeFoo = KlingonAlphabetUtils.isLetterFoo(word[word.Length - 1]);

            if (firstPersonOnly && KlingonAlphabetUtils.isLetterFoo(word[0]))
                continue;

            if (isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo)
                verbCount++;
        }

        return verbCount;
    }

    string GetVocabulary()
    {
        var words = Text.Split(" ");

        Array.Sort<string>(words, KlingonAlphabetUtils.CompareWordsAlphabeticaly);

        return String.Join(' ', words);
    }

    ulong[] GetBeautifulDistinctNumbers()
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
            var add = KlingonAlphabetUtils.GetLetterNumberValue(word[i]) * Math.Pow(20, i); 
            value += (ulong) add;
        }

        return value;
    }
}
