using NUnit.Framework;

public class KlingonAlphabetUtilsTest
{
    [Test]
    public void MustOnlyValidateFooLetters()
    {
        Assert.AreEqual(true, KlingonAlphabetUtils.isLetterFoo('s'));
        Assert.AreEqual(true, KlingonAlphabetUtils.isLetterFoo('l'));
        Assert.AreEqual(true, KlingonAlphabetUtils.isLetterFoo('f'));
        Assert.AreEqual(true, KlingonAlphabetUtils.isLetterFoo('w'));
        Assert.AreEqual(true, KlingonAlphabetUtils.isLetterFoo('k'));
        Assert.AreNotEqual(true, KlingonAlphabetUtils.isLetterFoo('h'));
        Assert.AreNotEqual(true, KlingonAlphabetUtils.isLetterFoo('r'));
    }

    [Test]
    public void MustConvertLettersIntoNumbers()
    {
        Assert.AreEqual(0, KlingonAlphabetUtils.GetLetterNumberValue('k'));
        Assert.AreEqual(10, KlingonAlphabetUtils.GetLetterNumberValue('m'));
        Assert.AreEqual(19, KlingonAlphabetUtils.GetLetterNumberValue('s'));
    }

    [Test]
    public void MustCompareWordsAlphabetically()
    {
        Assert.AreEqual(-1, KlingonAlphabetUtils.CompareWordsAlphabeticaly("kkr", "kkqrz"));
        Assert.AreEqual(-1, KlingonAlphabetUtils.CompareWordsAlphabeticaly("kkr", "wvkzzjfj"));
        Assert.AreEqual(1, KlingonAlphabetUtils.CompareWordsAlphabeticaly("mml", "xrbv"));
        Assert.AreEqual(1, KlingonAlphabetUtils.CompareWordsAlphabeticaly("gjtx", "rqhqz"));
    }
}
