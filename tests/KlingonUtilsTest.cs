using NUnit.Framework;

public class KlingonUtilsTest
{
    [Test]
    public void MustValidatePrepositions()
    {
        Assert.AreEqual(true, KlingonUtils.IsWordPreposition("bzh"));
        Assert.AreEqual(true, KlingonUtils.IsWordPreposition("vwm"));
        Assert.AreEqual(true, KlingonUtils.IsWordPreposition("vvr"));
        Assert.AreEqual(false, KlingonUtils.IsWordPreposition("vwrdkfbs"));
        Assert.AreEqual(false, KlingonUtils.IsWordPreposition("kxll"));
        Assert.AreEqual(false, KlingonUtils.IsWordPreposition("sjlkk"));
    }

    [Test]
    public void MustValidateVerbs()
    {
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("qgnrnlhk"));
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("vwrdkfbs"));
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("lkclqnrs"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("sqdkm"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("wzrbhdkt"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("fjht"));
    }

    [Test]
    public void MustValidateFirstPersonVerbs()
    {
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("xmbhxlml"));
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("gzhwxlxk"));
        Assert.AreEqual(true, KlingonUtils.IsWordVerb("gnhpjjhf"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("wnfwhcrp"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("lpjppbb"));
        Assert.AreEqual(false, KlingonUtils.IsWordVerb("spgqpfkh"));
    }
    
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
    public void MustValidateBeautifulNumbers()
    {
        Assert.AreEqual(true, KlingonUtils.IsNumberBeautiful(186137616));
        Assert.AreEqual(true, KlingonUtils.IsNumberBeautiful(60685164));
        Assert.AreEqual(true, KlingonUtils.IsNumberBeautiful(15486421050));
        Assert.AreEqual(false, KlingonUtils.IsNumberBeautiful(1012784));
        Assert.AreEqual(false, KlingonUtils.IsNumberBeautiful(20141490899));
        Assert.AreEqual(false, KlingonUtils.IsNumberBeautiful(183475));
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
