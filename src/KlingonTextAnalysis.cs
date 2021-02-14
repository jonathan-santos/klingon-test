using System;
using System.Collections.Generic;
using System.Linq;

public class KlingonTextAnalysis
{
    public string Text { get; }
    public string[] Prepositions { get; }
    public string[] Verbs { get; }
    public string[] VerbsInFirstPerson { get; }
    public string[] Vocabulary { get; }
    public ulong[] BeautifulDistinctNumbers { get; }

    public KlingonTextAnalysis(string text)
    {
        this.Text = text;
        this.Prepositions = GetPrepositions();
        this.Verbs = GetVerbs();
        this.VerbsInFirstPerson = GetVerbsInFirstPerson();
        this.Vocabulary = GetVocabulary();
        this.BeautifulDistinctNumbers = GetBeautifulDistinctNumbers();
    }

    string[] GetPrepositions()
    {
        var words = this.Text.Split(' ');
        var prepositions = new List<string>();

        foreach (var word in words)
        {
            var isLength3 = word.Length == 3;
            var doesntHaveD = !word.Contains('d');
            var isLastLetterTypeBar = !KlingonUtils.IsLetterFoo(word[2]);

            if (isLength3 && doesntHaveD && isLastLetterTypeBar)
                prepositions.Add(word);
        }

        return prepositions.ToArray();
    }

    string[] GetVerbs()
    {
        var words = this.Text.Split(" ");
        var verbs = new List<string>();

        foreach (var word in words)
        {
            var isLengthEqualOrGreaterThan8 = word.Length >= 8;
            var isLastLetterTypeFoo = KlingonUtils.IsLetterFoo(word[word.Length - 1]);

            if (isLengthEqualOrGreaterThan8 && isLastLetterTypeFoo)
                verbs.Add(word);
        }

        return verbs.ToArray();
    }

    string[] GetVerbsInFirstPerson()
    {
        var verbsInFirstPerson = new List<string>();

        foreach (var verb in this.Verbs)
        {
            if (!KlingonUtils.IsLetterFoo(verb[0]))
                verbsInFirstPerson.Add(verb);
        }

        return verbsInFirstPerson.ToArray();
    }

    string[] GetVocabulary()
    {
        var words = this.Text.Split(" ");

        Array.Sort<string>(words, KlingonUtils.CompareWordsLexically);

        return words;
    }

    ulong[] GetBeautifulDistinctNumbers()
    {
        var words = this.Text.Split(" ");
        var numbers = new List<ulong>();

        foreach (var word in words)
            numbers.Add(KlingonUtils.ConvertWordToNumber(word));
        
        return numbers.Where(n => n >= 440566 && n % 3 == 0)
            .Distinct<ulong>()
            .ToArray();;
    }
}
