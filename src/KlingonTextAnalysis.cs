using System;
using System.Collections.Generic;
using System.Linq;

public class KlingonTextAnalysis
{
    public string Text { get; private set; }
    public string[] Prepositions { get; private set; }
    public string[] Verbs { get; private set; }
    public string[] VerbsInFirstPerson { get; private set; }
    public string[] Vocabulary { get; private set; }
    public ulong[] BeautifulNumbers { get; private set; }

    public KlingonTextAnalysis(string text)
    {
        this.Text = text;

        if (String.IsNullOrWhiteSpace(text))
        {
            this.Prepositions = new string[0];
            this.Verbs = new string[0];
            this.VerbsInFirstPerson = new string[0];
            this.Vocabulary = new string[0];
            this.BeautifulNumbers = new ulong[0];
            return;   
        }
        
        AnalyseText();
    }

    void AnalyseText()
    {
        var prepositions = new List<string>();
        var verbs = new List<string>();
        var verbsInFirstPerson = new List<string>();
        var vocabulary = new List<string>();
        var beautifulNumbers = new List<ulong>();

        var words = this.Text.Split(' ');
        foreach (var word in words)
        {
            if (KlingonUtils.IsWordPreposition(word))
                prepositions.Add(word);

            if (KlingonUtils.IsWordVerb(word))
            {
                verbs.Add(word);

                if (KlingonUtils.isVerbInFirstPerson(word))
                    verbsInFirstPerson.Add(word);
            }

            beautifulNumbers.Add(KlingonUtils.ConvertWordToNumber(word));
        }

        this.Prepositions = prepositions.ToArray();

        this.Verbs = verbs.ToArray();

        this.VerbsInFirstPerson = verbsInFirstPerson.ToArray();

        Array.Sort<string>(words, KlingonUtils.CompareWordsLexically);
        this.Vocabulary = words;
        
        this.BeautifulNumbers = beautifulNumbers.Where(n => KlingonUtils.IsNumberBeautiful(n))
            .Distinct<ulong>()
            .ToArray();
    }
}
