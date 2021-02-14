using NUnit.Framework;

public class KlingonAlphabetUtilsTest
{
    [Test]
    public void MustOnlyValidateFooLetters()
    {
        Assert.AreEqual(true, KlingonAlphabetUtils.IsLetterFoo('s'));
        Assert.AreEqual(true, KlingonAlphabetUtils.IsLetterFoo('l'));
        Assert.AreEqual(true, KlingonAlphabetUtils.IsLetterFoo('f'));
        Assert.AreEqual(true, KlingonAlphabetUtils.IsLetterFoo('w'));
        Assert.AreEqual(true, KlingonAlphabetUtils.IsLetterFoo('k'));
        Assert.AreNotEqual(true, KlingonAlphabetUtils.IsLetterFoo('h'));
        Assert.AreNotEqual(true, KlingonAlphabetUtils.IsLetterFoo('r'));
    }

    [Test]
    public void MustConvertLettersIntoNumbers()
    {
        Assert.AreEqual(0, KlingonAlphabetUtils.ConvertLetterToNumber('k'));
        Assert.AreEqual(10, KlingonAlphabetUtils.ConvertLetterToNumber('m'));
        Assert.AreEqual(19, KlingonAlphabetUtils.ConvertLetterToNumber('s'));
    }

    [Test]
    public void MustConvertWordsToNumbers()
    {
        Assert.AreEqual(4852, KlingonAlphabetUtils.ConvertWordToNumber("vwv"));
        Assert.AreEqual(59435160, KlingonAlphabetUtils.ConvertWordToNumber("kpfjlp"));
        Assert.AreEqual(556028353, KlingonAlphabetUtils.ConvertWordToNumber("hzmrchx"));
        Assert.AreEqual(17938089542, KlingonAlphabetUtils.ConvertWordToNumber("wzrbhdkt"));
    }

    [Test]
    public void MustCompareWordsAlphabetically()
    {
        Assert.AreEqual(-1, KlingonAlphabetUtils.CompareWordsLexically("kkr", "kkqrz"));
        Assert.AreEqual(-1, KlingonAlphabetUtils.CompareWordsLexically("kkr", "wvkzzjfj"));
        Assert.AreEqual(1, KlingonAlphabetUtils.CompareWordsLexically("mml", "xrbv"));
        Assert.AreEqual(1, KlingonAlphabetUtils.CompareWordsLexically("gjtx", "rqhqz"));
    }
}
