# Programming logic test of Klingon
## My project

To run my project which is itself a solution to the test, first have [.net 5](https://dotnet.microsoft.com/download/dotnet/5.0) installed in your machine.

### To run project
Just use the `run` command from `dotnet` in the project root:

``` bash
dotnet run
```

### To run the project tests
Just use the `test` command from `dotnet` in the project root:

``` bash
dotnet test
```

## The Klingon Language test
A scroll was found with two Texts, [A](./texts/A.txt) and [B](./texts/B.txt):

This scroll is in the ancient and mysterious language Klingon. After many years of study, the scholars already discovered a few characteristics of this language.

Firstly, the Klingon letters are classified into two groups:
- The letters `s`, `l`, `f`, `w` and `k` are letters of type `foo`
- All the other letters are of type `bar`

### Prepositions
The Scholars found that prepositions in Klingon are words of 3 letters that finished in a letter of type `bar`, which doesn't have a letter `d`. With that in mind, it's possible to see that there are 63 prepositions in text A.

**Challenge:** How many prepositions are in text B?

### Verbs
Another interesting fact found by the scholars is that in Klingon, the verbs are always words composed of 8 or more letters that finish in a letter of type `foo`. And not only that, if a verb starts with a letter of type bar, the verb is in first person.

Analyzing text A it's possible to identify 26 verbs, of which 23 are in first person.

**Challenge:** How many verbs are in text B?

### Vocabulary
A university professor will use texts A and B to teach Klingon to students. But, in order to better help student's to understand the text, this professor needs to create a vocabulary list for each text, this is, a ordered list (and without repetitions) of words that appear in each one of the texts.

In Klingon, as in the English alphabet, the words are ordered lexically, but the problem is that in Klingon the order of letters are different from our own. The Klingon alphabet order is: `kbwrqdnfxjmlvhtcgzps`. So, when doing theses lists, the professor needs to respect the Klingon letter alphabetic order.

The professor prepared the Vocabulary list for text A:

```
kkr kkqrz kks kbf kwq kwlr kwzjrb krcbp krs kqqbz kqlxjmdn knwgqk kng knpprkz knsxpsj kfgzn kfs kxll kjqq kmk klsdcz khqhpxhz ktlpk kch kctqjsl kgqjfxsn kgcpg kztwskq kpfjlp ksc bbjcsnmh bwlc bwvpc brnkn brnfggrj brsbnk bdb bdxxvtfn bdjck bnjzqgb bnmnmrbh bfcb bxphb blrb bvgqqfg btb btsgvh bcqbwltn bcfnbcx bgpg bzqvnxs bzddqxkp bzh bsj bsgqvvvv bsgtc wkmk wksg wwhqdpqg wrmvbr wdwz wnbkmkvr wnbrptf wnfwhcrp wfw wffjnk wxhld wjvb wmqx wmnc wmslgqz wlj wvkzzjfj wvnbn wvpnz whmfnw whgszgvd wchmbn wgphtk wzrbhdkt wzjxcdb wpfsp wppgb rbsx rwnck rqj rqjdgpv rqhqz rqcprpcw rdkf rdctbpfp rfq rfqsp rxdrgkjp rlpdjtd rvvpg rvzlch rhjs rhpndvh rhpjs rhsj rtghx rcms rcz rgbk rgnq rgfgqfzp rgjhkb rgs rznlm rzhn rzc rpmlxxlt rpcw rspr qkwrxncc qkvwf qwmj qrmd qqmfxqv qdhnr qdph qdppk qxkdqpj qxzttrzf qjpwsmcg qmbzg qmqr qmdv qmzwzq qvm qvzhxdsv qtwtnwd qccz qcg qgnrnlhk qzzl qpvdsp qsqjjn qslnn dkvrsqw dkhz dbcm dwfjfprh dqbrjbg dqrzs dqjmmmp dqv dnnbqj dnvrhhc dxdlf dxnhl dldj dlpf dvnfs dtm dtsm dcbkws dcv dzlrx dzztm dsd nknlpfc nkxbvf nkhvwpd nbvdzrn nbhn nwxlpbqr nrthfqs nqqz nqcqnb ndqnq ndzzrxdn nflwl nxwpfmlj nxgsrkr njc nlmmslnb nvjkj ntwqnchk ntvs ncp ncpj ngszspnv nzwch nzgbmln npfbkj npfqnvq nsjrmnp nszzgp fbbrmxw fbdc fwqqqldj fwm fwvrqs fwthpfb frwjqm frhxmg fqrdt fqzpbc fnhgkb ffp fxxm fxz fjb fjht fjtwz fjtccn fjg fmrt fmpc ftqrbpg ftc fcnxx fclchmkb fgm fgmkc fzx fzjxmtns fpgp fsbh fsprt xbxdrc xbxp xwrhjp xrbv xrgtzxc xqhn xqshpc xdtvpjhs xdssrljz xntwrhp xfpdfhpw xxdkftl xxfcwq xjb xmktdqs xmbhxlml xmq xmpbnp xlwrfcwq xvwh xvdnk xhdlgp xcffkzm xgl xgldndlt xgtrsvbj xzfhwn xzftrjg xpxcg xslxdrr jkvw jkprpc jbqrftv jbdxmb jbgx jwlspvwn jwgbbs jrjzsmh jrhhl jqqk jqqhctv jdx jdssqdds jfhpql jxdqjc jjxlncpn jmjmnqwj jlvf jvjdwsh jvmrsxz jvsf jtbblclw jtlg jtg jck jcl jch jchqs jgx jghvh jzgtdtst jsm mkst mbrwt mbxtgzhz mbmwbflw mbpv mbs mbspg mwjtkdf mrd mrft mrh mqf mqcwb mdl mfdtp mfskzwd mxmgkxvg mxlxblj mml mlksdv mlwqjxgt mlc mvrwtm mvlznjbs mvvwmsbv mhfz mccxbmj mghxmtp mzswtb mpm msn lklksspg lkclqnrs lbhchcdz lwd lrrdz lrqbxdqb lqnwmztx lnvxmsk lfhlp lxws lxsxfqn ljs lmhcc lmzsv lmskl lvbgtsm lvwwrk lhbmhq ltqpph ltdtqrd ltvw lgmnjgw lzd lzf lzhcm lpjppbb lpcpp lppcbl lskqvwz vbfllt vwrdkfbs vwrpqgh vwm vwv vwzwl vql vqvsftk vqgvcq vqzggb vdflfqs vdxxxrvs vfklm vfvjvjhk vxp vjwzjmn vjqckhkc vjftvvx vlrnzbqn vvr vhxxhk vhxhlp vtf vtxk vtmfg vtlfdh vtcsh vcsbh vgrk vzsw vptms vppzfv vsw vsr vsvw hkjbls hkv hbkxjht hbv hwcxxj hrhskq hqkqrlqq hdbjlj hdcrmxz hdpcgrf hnqgg hnzbfvs hxwsvt hxd hxn hmkzq hmfcnjtd hmvwqnps hmvnxfwd hlrrvg hlnfvk hvd hvmscx hhw hhrxq hhrc hhjfz htrh htjjnfg htczjl hcrtb hclw hzmrchx hzsq hsbm hsqgkhm hsvqw hssddc tkfscrmq tbq twndc twgffp twpz tqrsztnh tqfxrbr tqjckk tqgvq tnrrmc tntr tng txktscz txf txmgknxk txvghq tmwshk tlvhvq tvkc ttfr ttxm tcf tcxcf tghhrf tzlgfp tzv tzz tpkndf tpmpk cbwpgf crwstts crqsnlpp crtlpf cqbkq cqzx cdwcbph cdhsspgx cdzvdl cdsqqhnm cnhg cfb cfrzw cfpwpm cxqxhq cxxc cxlvr cjldqqbl cjhdddn cmkfhshr clftm cljqnm chq chfpsxq chzghzr chpwb cgp czj csrcr cscvwnm csch gkqfrpw gbxkk gbmnnnx gbtdlfz gbpxd grb grzj gqtvjlsw gdbnszk gnhpjjhf gfkzcl gffqvwf gfptj gxf gjtx gjpsmc gmwwtb gmq gmxrcl glbqz glwth glcvbs ghkt gtxdhxkl gtjrzkqq gtvhlcs gcr gznb gzhwxlxk gprl gszffz zkg zbnm zbvjwc zrqzjjv zrlslx zrtqk zdmfr zdcvth znjpdq zfkzxk zfrdfjkv zfq zfmcmjdl zfh zlqlndf zlhlfgh zvrg zvgbgb zhctgvl zhs ztdnzg zclnfzv zcvmrckj zcshqzwn zgbswzr zgfztg zgsjn zzkmm zzrfnk zzmv zpwxfmj zpn zpxwmsg zsqwl zsnjvmv zsjvxx pktfltsk pbxp pbzqvs pqls pddkbdz pnbbxsht pnskmbgn pfdbs pfvbjx pxbbcfwj pjdvb pmz pmpr plwcvdx plqnjsk plgf pvrcjdc pvlhvnn phx phlhjcm ptl pct pcz pczwpdqg pgl pzq pzgfkkl ppwn pprmv skxk sbplvr swgv sqdkm sqfnqttc snwtpwtr sffczr sxkftwmg sxrdjgvf sjlkk sjzmnfx slfn svkzqttr svfnm svtx shtd shcrwqkh shsdr stnkc stfdpfgc sgfxxd szdbb szfpkrjv spdv splq spgqpfkh sszdlff
```

**Challenge:** Create a vocabulary for the Text B

### Numbers
In Klingon words are also numbers of base 20, where each letter is a digit and, numbers are ordered from the less valuable to the most valuable (the inverse of our system). Which means that the first position is the unit, the second position is worth 20, the third is worth 400 and, onward. The values of the letters are based on the order in which they appear in Klingon Alphabet (which is different from our own, as seen above), so the first letter (`k`) represents 0, and the second letter (`b`) is worth 1, and onward, until the last letter (`s`) which is worth 19.

For example, the word `vwv` has the numeric value of 4852.

> Note: The numbers resulting in this can be very large, so if you are working with a data type of limited size you may end up with possible overflows.

Beyond that the Klingons consider a number beautiful if the satisfies two properties:
- It is greater or equal to 440566
- It is divisible by 3

Considering text A as a list of numbers (that is, interpreting each word as a number using the convention explained above), it results in 126 beautiful numbers.

**Challenge:** In text B, how many beautiful numbers are there?
