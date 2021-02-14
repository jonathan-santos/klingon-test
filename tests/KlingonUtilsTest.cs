using NUnit.Framework;

public class KlingonUtilsTest
{
    [Test]
    public void MustOnlyValidateFooLetters()
    {
        Assert.AreEqual(true, KlingonUtils.IsLetterFoo('s'));
        Assert.AreEqual(true, KlingonUtils.IsLetterFoo('l'));
        Assert.AreEqual(true, KlingonUtils.IsLetterFoo('f'));
        Assert.AreEqual(true, KlingonUtils.IsLetterFoo('w'));
        Assert.AreEqual(true, KlingonUtils.IsLetterFoo('k'));
        Assert.AreNotEqual(true, KlingonUtils.IsLetterFoo('h'));
        Assert.AreNotEqual(true, KlingonUtils.IsLetterFoo('r'));
    }

    [Test]
    public void MustConvertLettersIntoNumbers()
    {
        Assert.AreEqual(0, KlingonUtils.ConvertLetterToNumber('k'));
        Assert.AreEqual(10, KlingonUtils.ConvertLetterToNumber('m'));
        Assert.AreEqual(19, KlingonUtils.ConvertLetterToNumber('s'));
    }

    [Test]
    public void MustConvertWordsToNumbers()
    {
        Assert.AreEqual(4852, KlingonUtils.ConvertWordToNumber("vwv"));
        Assert.AreEqual(59435160, KlingonUtils.ConvertWordToNumber("kpfjlp"));
        Assert.AreEqual(556028353, KlingonUtils.ConvertWordToNumber("hzmrchx"));
        Assert.AreEqual(17938089542, KlingonUtils.ConvertWordToNumber("wzrbhdkt"));
    }

    [Test]
    public void MustCompareWordsAlphabetically()
    {
        Assert.AreEqual(-1, KlingonUtils.CompareWordsLexically("kkr", "kkqrz"));
        Assert.AreEqual(-1, KlingonUtils.CompareWordsLexically("kkr", "wvkzzjfj"));
        Assert.AreEqual(1, KlingonUtils.CompareWordsLexically("mml", "xrbv"));
        Assert.AreEqual(1, KlingonUtils.CompareWordsLexically("gjtx", "rqhqz"));
    }
}
