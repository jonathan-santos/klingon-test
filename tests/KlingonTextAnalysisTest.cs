using NUnit.Framework;
using System.IO;

public class KlingonTextAnalysisTest
{
    KlingonTextAnalysis _KlingonTextAnalysis;

    [SetUp]
    public void Initialize()
    {
        var textAPathRelativeToTestBin = "../../../texts/A.txt";
        var textA = File.ReadAllText(textAPathRelativeToTestBin);
        this._KlingonTextAnalysis = new KlingonTextAnalysis(textA);
    }

    [Test]
    public void MustGetPrepositions()
    {
        Assert.AreEqual(63, this._KlingonTextAnalysis.Prepositions.Length);
    }

    [Test]
    public void MustGetVerbs()
    {
        Assert.AreEqual(26, this._KlingonTextAnalysis.Verbs.Length);
    }

    [Test]
    public void MustGetVerbsInFirstPerson()
    {
        Assert.AreEqual(23, this._KlingonTextAnalysis.VerbsInFirstPerson.Length);
    }

    [Test]
    public void MustGetVocabulary()
    {
        var expectedVocabulary = "kkr kkqrz kks kbf kwq kwlr kwzjrb krcbp krs kqqbz kqlxjmdn knwgqk kng knpprkz knsxpsj kfgzn kfs kxll kjqq kmk klsdcz khqhpxhz ktlpk kch kctqjsl kgqjfxsn kgcpg kztwskq kpfjlp ksc bbjcsnmh bwlc bwvpc brnkn brnfggrj brsbnk bdb bdxxvtfn bdjck bnjzqgb bnmnmrbh bfcb bxphb blrb bvgqqfg btb btsgvh bcqbwltn bcfnbcx bgpg bzqvnxs bzddqxkp bzh bsj bsgqvvvv bsgtc wkmk wksg wwhqdpqg wrmvbr wdwz wnbkmkvr wnbrptf wnfwhcrp wfw wffjnk wxhld wjvb wmqx wmnc wmslgqz wlj wvkzzjfj wvnbn wvpnz whmfnw whgszgvd wchmbn wgphtk wzrbhdkt wzjxcdb wpfsp wppgb rbsx rwnck rqj rqjdgpv rqhqz rqcprpcw rdkf rdctbpfp rfq rfqsp rxdrgkjp rlpdjtd rvvpg rvzlch rhjs rhpndvh rhpjs rhsj rtghx rcms rcz rgbk rgnq rgfgqfzp rgjhkb rgs rznlm rzhn rzc rpmlxxlt rpcw rspr qkwrxncc qkvwf qwmj qrmd qqmfxqv qdhnr qdph qdppk qxkdqpj qxzttrzf qjpwsmcg qmbzg qmqr qmdv qmzwzq qvm qvzhxdsv qtwtnwd qccz qcg qgnrnlhk qzzl qpvdsp qsqjjn qslnn dkvrsqw dkhz dbcm dwfjfprh dqbrjbg dqrzs dqjmmmp dqv dnnbqj dnvrhhc dxdlf dxnhl dldj dlpf dvnfs dtm dtsm dcbkws dcv dzlrx dzztm dsd nknlpfc nkxbvf nkhvwpd nbvdzrn nbhn nwxlpbqr nrthfqs nqqz nqcqnb ndqnq ndzzrxdn nflwl nxwpfmlj nxgsrkr njc nlmmslnb nvjkj ntwqnchk ntvs ncp ncpj ngszspnv nzwch nzgbmln npfbkj npfqnvq nsjrmnp nszzgp fbbrmxw fbdc fwqqqldj fwm fwvrqs fwthpfb frwjqm frhxmg fqrdt fqzpbc fnhgkb ffp fxxm fxz fjb fjht fjtwz fjtccn fjg fmrt fmpc ftqrbpg ftc fcnxx fclchmkb fgm fgmkc fzx fzjxmtns fpgp fsbh fsprt xbxdrc xbxp xwrhjp xrbv xrgtzxc xqhn xqshpc xdtvpjhs xdssrljz xntwrhp xfpdfhpw xxdkftl xxfcwq xjb xmktdqs xmbhxlml xmq xmpbnp xlwrfcwq xvwh xvdnk xhdlgp xcffkzm xgl xgldndlt xgtrsvbj xzfhwn xzftrjg xpxcg xslxdrr jkvw jkprpc jbqrftv jbdxmb jbgx jwlspvwn jwgbbs jrjzsmh jrhhl jqqk jqqhctv jdx jdssqdds jfhpql jxdqjc jjxlncpn jmjmnqwj jlvf jvjdwsh jvmrsxz jvsf jtbblclw jtlg jtg jck jcl jch jchqs jgx jghvh jzgtdtst jsm mkst mbrwt mbxtgzhz mbmwbflw mbpv mbs mbspg mwjtkdf mrd mrft mrh mqf mqcwb mdl mfdtp mfskzwd mxmgkxvg mxlxblj mml mlksdv mlwqjxgt mlc mvrwtm mvlznjbs mvvwmsbv mhfz mccxbmj mghxmtp mzswtb mpm msn lklksspg lkclqnrs lbhchcdz lwd lrrdz lrqbxdqb lqnwmztx lnvxmsk lfhlp lxws lxsxfqn ljs lmhcc lmzsv lmskl lvbgtsm lvwwrk lhbmhq ltqpph ltdtqrd ltvw lgmnjgw lzd lzf lzhcm lpjppbb lpcpp lppcbl lskqvwz vbfllt vwrdkfbs vwrpqgh vwm vwv vwzwl vql vqvsftk vqgvcq vqzggb vdflfqs vdxxxrvs vfklm vfvjvjhk vxp vjwzjmn vjqckhkc vjftvvx vlrnzbqn vvr vhxxhk vhxhlp vtf vtxk vtmfg vtlfdh vtcsh vcsbh vgrk vzsw vptms vppzfv vsw vsr vsvw hkjbls hkv hbkxjht hbv hwcxxj hrhskq hqkqrlqq hdbjlj hdcrmxz hdpcgrf hnqgg hnzbfvs hxwsvt hxd hxn hmkzq hmfcnjtd hmvwqnps hmvnxfwd hlrrvg hlnfvk hvd hvmscx hhw hhrxq hhrc hhjfz htrh htjjnfg htczjl hcrtb hclw hzmrchx hzsq hsbm hsqgkhm hsvqw hssddc tkfscrmq tbq twndc twgffp twpz tqrsztnh tqfxrbr tqjckk tqgvq tnrrmc tntr tng txktscz txf txmgknxk txvghq tmwshk tlvhvq tvkc ttfr ttxm tcf tcxcf tghhrf tzlgfp tzv tzz tpkndf tpmpk cbwpgf crwstts crqsnlpp crtlpf cqbkq cqzx cdwcbph cdhsspgx cdzvdl cdsqqhnm cnhg cfb cfrzw cfpwpm cxqxhq cxxc cxlvr cjldqqbl cjhdddn cmkfhshr clftm cljqnm chq chfpsxq chzghzr chpwb cgp czj csrcr cscvwnm csch gkqfrpw gbxkk gbmnnnx gbtdlfz gbpxd grb grzj gqtvjlsw gdbnszk gnhpjjhf gfkzcl gffqvwf gfptj gxf gjtx gjpsmc gmwwtb gmq gmxrcl glbqz glwth glcvbs ghkt gtxdhxkl gtjrzkqq gtvhlcs gcr gznb gzhwxlxk gprl gszffz zkg zbnm zbvjwc zrqzjjv zrlslx zrtqk zdmfr zdcvth znjpdq zfkzxk zfrdfjkv zfq zfmcmjdl zfh zlqlndf zlhlfgh zvrg zvgbgb zhctgvl zhs ztdnzg zclnfzv zcvmrckj zcshqzwn zgbswzr zgfztg zgsjn zzkmm zzrfnk zzmv zpwxfmj zpn zpxwmsg zsqwl zsnjvmv zsjvxx pktfltsk pbxp pbzqvs pqls pddkbdz pnbbxsht pnskmbgn pfdbs pfvbjx pxbbcfwj pjdvb pmz pmpr plwcvdx plqnjsk plgf pvrcjdc pvlhvnn phx phlhjcm ptl pct pcz pczwpdqg pgl pzq pzgfkkl ppwn pprmv skxk sbplvr swgv sqdkm sqfnqttc snwtpwtr sffczr sxkftwmg sxrdjgvf sjlkk sjzmnfx slfn svkzqttr svfnm svtx shtd shcrwqkh shsdr stnkc stfdpfgc sgfxxd szdbb szfpkrjv spdv splq spgqpfkh sszdlff".Split(" ");
        Assert.AreEqual(expectedVocabulary.Length, this._KlingonTextAnalysis.Vocabulary.Length);
    }

    [Test]
    public void MustGetBeautifulDistinctNumbers()
    {
        Assert.AreEqual(126, this._KlingonTextAnalysis.BeautifulDistinctNumbers.Length);
    }
}
