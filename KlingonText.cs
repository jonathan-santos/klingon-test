public class KlingonText
{
    public string Text { get; set; }
    public int PrepositionCount { get; set; }
    public int VerbCount { get; set; }
    public int VerbInFirstPersonCount { get; set; }

    public KlingonText(string text)
    {
        Text = text;
        PrepositionCount = GetPrepositionCount();
        VerbCount = GetVerbCount();
        VerbInFirstPersonCount = GetVerbCount(firstPersonOnly: true);
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
}
