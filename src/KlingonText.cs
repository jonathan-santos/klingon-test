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
        this.Text = text;
        this.PrepositionCount = GetPrepositionCount();
        this.VerbCount = GetVerbCount();
        this.VerbInFirstPersonCount = GetVerbCount(firstPersonOnly: true);
        this.Vocabulary = GetVocabulary();
        this.BeautifulDistinctNumbers = GetBeautifulDistinctNumbers();
    }

    int GetPrepositionCount()
    {
        var words = this.Text.Split(" ");
        int prepositionCount = 0;

        foreach (var word in words) {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = !KlingonAlphabetUtils.IsLetterFoo(word[2]);

            if (isLength3 && doesntHaveD && isLastLetterTypeBar)
                prepositionCount++;
        }

        return prepositionCount;
    }

    int GetVerbCount(bool firstPersonOnly = false)
    {
        var words = this.Text.Split(" ");
        int verbCount = 0;

        foreach (var word in words) {
            var isLengthEqualOrGreaterThan8 = word.Length >= 8;
            var isLastLetterTypeFoo = KlingonAlphabetUtils.IsLetterFoo(word[word.Length - 1]);

            if (firstPersonOnly && KlingonAlphabetUtils.IsLetterFoo(word[0]))
                continue;

            if (isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo)
                verbCount++;
        }

        return verbCount;
    }

    string GetVocabulary()
    {
        var words = this.Text.Split(" ");

        Array.Sort<string>(words, KlingonAlphabetUtils.CompareWordsLexically);

        return String.Join(' ', words);
    }

    ulong[] GetBeautifulDistinctNumbers()
    {
        var words = this.Text.Split(" ");
        ulong[] numbers = new ulong[words.Length];

        for (var i = 0; i < words.Length; i++)
            numbers[i] = KlingonAlphabetUtils.ConvertWordToNumber(words[i]);
        
        return numbers.Where(n => n >= 440566 && n % 3 == 0)
            .Distinct<ulong>()
            .ToArray();;
    }
}
