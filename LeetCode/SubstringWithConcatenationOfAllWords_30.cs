using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class SubstringWithConcatenationOfAllWords_30
    {
        private string S;
        private string[] Words;
        private int WordLen;

        public SubstringWithConcatenationOfAllWords_30()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            

            var a = FindSubstring("ejwwmybnorgshugzmoxopwuvshlcwasclobxmckcvtxfndeztdqiakfusswqsovdfwatanwxgtctyjvsmlcoxijrahivwfybbbudosawnfpmomgczirzscqvlaqhfqkithlhbodptvdhjljltckogcjsdbbktotnxgwyuapnxuwgfirbmdrvgapldsvwgqjfxggtixjhshnzphcemtzsvodygbxpriwqockyavfscvtsewyqpxlnnqnvrkmjtjbjllilinflkbfoxdhocsbpirmcbznuioevcojkdqvoraeqdlhffkwqbjsdkfxstdpxryixrdligpzldgtiqryuasxmxwgtcwsvwasngdwovxzafuixmjrobqbbnhwpdokcpfpxinlfmkfrfqrtzkhabidqszhxorzfypcjcnopzwigmbznmjnpttflsmjifknezrneedvgzfmnhoavxqksjreddpmibbodtbhzfehgluuukupjmbbvshzxyniaowdjamlfssndojyyephstlonsplrettspwepipwcjmfyvfybxiuqtkdlzqedjxxbvdsfurhedneauccrkyjfiptjfxmpxlssrkyldfriuvjranikluqtjjcoiqffdxaukagphzycvjtvwdhhxzagkevvuccxccuoccdkbboymjtimdrmerspxpktsmrwrlkvpnhqrvpdekmtpdfuxzjwpvqjjhfaupylefbvbsbhdncsshmrhxoyuejenqgjheulkxjnqkwvzznriclrbzryfaeuqkfxrbldyusoeoldpbwadhrgijeplijcvqbormrqglgmzsprtmryvkeevlthvflsvognbxfjilwkdndyzwwxgdbeqwlldyezmkopktzugxgkklimhhjqkmuaifnodtpredhqygmedtqpezboimeuyyujfjxkdmbjpizpqltvgknnlodtbhnbhjkmuhwxvzgmkhbcvvadhnssbvneecglnqxhavhvxpkjxlluilzpysjcnwguyofnhfvhaceztoiscumkhociglkvispihvyoatxcxbeqsmluixgsliatukrecgoldmzfhwkgaqzsckonjuhxdhqztjfxstjvikdrhpyjfxbjjryslfpqoiphrwfjqqhaamrjbrsiovrxmqsyxhqmritjeauwqbwtpqcqhvyyssvfknfhxvtodpzipueixdbntdfcaeatyyainfpkclbgaaqrwwzwbcjwiqzkwzfuxfclmsxpdyvfbnwxjytnaejivivriamhgqsskqhnqeurttrfrmstrbeokzhuzvbfmwywohmgogyhzpmsdemugqkspsmoppwbnwabdmiruibwznqcuczculujfiavzwynsyqxmarjkshjhxobandwyzggjibjgzyaaqxorqxbkenscbveqbaociwmqxxyzvyblypeongzrttvwqzmrccwkzidyfbxcaypyquodcpwxkstbthuvjqgialhfmgjohzoxvdaxuywfqrgmyahhtpqtazbphmfoluliznftodyguesshcacrsvutylalqrykehjuofisdookjhrljvedsywrlyccpaowjaqyfaqioesxnlkwgpbznzszyudpwrlgrdgwdyhucztsneqttsuirmjriohhgunzatyfrfzvgvptbgpwajgtysligupoqeoqxoyqtzozufvvlktnvahvsseymtpeyfvxttqosgpplkmxwgmsgtpantazppgnubmpwcdqkvhwfuvcahwibniohiqyywnuzzmxeppokxksrfwrpuzqhjgqryorwboxdauhrkxehiwaputeouwxdfoudcoagcxjcuqvenznxxnprgvhasffxtzaxpcfrcovwgrcwqptoekhmgpoywtxruxokcubekzcrqengviwbtgnzvdzrwwkqvacxwgdhffyvjldgvchoiwnfzoyvkiogisdfyjmfomcazigukqlumyzmnzjzhzfpslwsukykwckvktswjdqxdrlsqvsxwxpqkljeyjpulbswwmuhplfueqnvnhukgjarxlxvwmriqjgmxawmndhsvwnjdjvjtxcsjapfogpesxtpypenunfpjuyoevzztctecilqqbxkaqcyhiobvtqgqruumvvhxolbyzsqcrdchhdqprtkkjsccowrjtyjjmkhleanvfpemuublnnyzfabtxsestncfalqenfcswgerbfcqsapzdtscnzugmwlmidtxkvqhbuaecevwhmwkfqmvpgbefpqpsjmdecmixmmbsjxzwvjdmxydechlraajjmoqpcyoqmrjwoiumuzatydzcnktnkeyztoqvogodxxznhvzduzxudwwqhpftwdspuimioanlzobhjakgajafgzxpqckmhdbbnqmcszpuoqbztnftzgahhxwxbgkilnmzfydyxusnnvngksbjabqjaohdvrniezhmxmkxhemwbbclwdxwgngicplzgajmaryzfkyoqlkrmmfirchzrphveuwmvgaxzbwenvteifxuuefnimnadwxhruvoavlzyhfmeasmgrjawongccgfbgoualiaivbhcgvjjnxpggrewglalthmzvgziobrjeanlvyukwlscexbkibvdjhdgnepdiimmkcxhattwglbkicvsfswocbvphmtpwhcgjbnmxgidtlqcnnwtfujhvgzdussqbwynylzvtjapvqtidpdjkpshvrmqlhindhabubyokzdfrwqvnvgzkyhistydagsgnujiviyijdnabfxqbdqnexvwsvzvcsbrmkbkuzsdehghndyqjodnnblfwmaygdstotfkvxozgwhtbhlkvrzismnozqpfthajafuxekzlgigjpsukjvsdihrjzgovnreqwapdkoqswyclqyvbvpedzyoyedvuuamscbxnqnfmmjyehvidnoimmxmtcinwkbqmcobubjjpshucechrqrffqsyscnqoohcsxenypyqhfklloudgmklcejvgynwouzhtfwuuukdbwpmkjrqxeeaipxrokncholathupdetgaktmvmftqjvzyssocftjwemroghrncynmtchhhcaqxbqpthuaafwgrouaxonzocljeuslzsdwvuoodipdpnlhdihaywzmymxdjrqikughquwtenyucjdgrmipiidiwclhuepgyynoslhzahtdqwliktzsddaahohbszhqxxgripqlwlomjbwtuynydoakejmwkvojuwbfltqjfgxqhwkduzbxpdhtpvrzrfjndmsqfizmqxdxtpbpoemekvxzrrakwjxcxqsdasptruqmjtbaapgmkfnbwnlvzlxwdpzfjryanrmzmpzoefapmnsjdgecrdywsabctaegttffigupnwgakylngrrxurtotxqmzxvsqazajvrwsxyeyjteakeudzjxwbjvagnsjntskmocmpgkybqbnwvrwgoskzqkgffpsyhfmxhymqinrbohxlytsmoeleqrjvievpjipsgdkrqeuglrsjnmvdsihicsgkybcjltcswolpsfxdypmlbjotuxewskisnmczfgreuevnjssjifvlqlhkllifxrxkdbjlhcpegmtrelbosyajljvwwedtxbdccpnmreqaqjrxwulpunagwxesbilalrdniqbzxrbpcvmzpyqklsskpwctgqtrjwhrpisocwderqfiqxsdpkphjsapkvhvsqojyixaechvuoemmyqdlfkuzmlliugckuljfkljoshjhlvvlnywvjswvekfyqhjnsusefdtakejxbejrchoncklguqgnyrcslwztbstmycjziuskegagtlonducdogwbevugppsptdqbajmepmmizaycwcgmjeopbivsyphtvxvvgjbyxpgwpganjiaumojpyhhywosrmnouwpstgbrvhtlqcnmqbygbfnabesvshjmdbhyhirfrkqkmfwdgujhzyjdcbyuijjnkqluaczrnrbbwaeeupnwqzbsazplkyaxqorqsshhlljjlpphhedxdepgfgrqerpuhgmaawhnhqwsgnznrfmxjbdrkwjopylxezxgvetcvrwdewsxdeumhzfrvoilmvksuhyqltuimrnsphqslmgvmmojawwptghonigbdclqtbikiacwpjrbxhmzejozpypfixglatdvuogdoizdtsgsztsfcihtgwyqugeuahpuvvzmgarbsyuutmbxuisdfrvbxzxzhmuektssuktoknkfbmcwwubbnwenybmfqglaceuyqnoadzfenjcjfdlvcpiatuhjdujhaffqsvqvuxchgerokejovrqonxxstibunikiedfyahijobxyhimebctobsjudkqstbcxgixgrhpfiofpwruzvpqyjzvollheoldutddnksutjakhtghpxxnjykxjwgqmsvhnykclexepxqxqzghwfxfdhfmflesfabvanxlrurjtigkjotftqnwyskffpxlragrnfffawqtgyfpmzxfpkdpenxlewyxxgrkmwrmshhzfnorolyfxbvdrspxqnxnuoygkruczddgssygfymdcjgvdxutlrhffhnpyjuxmxefrelxezcgikdliyhvpocvvpkvagvmezrxffujeysplvavtjqjxsgujqsjznxforctwzecxyrkwufpdxadrgzczrnyelfschnagucguuqqqwitviynrypsrdswqxqsegulcwrwsjnihxedfcqychqumiscfkwmqqxunqrfbgqjdwmkyelbldxympctbzfupeocwhkypchuyvhybsbmvymjppfrqmlfrbkpjwpyyytytawuuyjrwxboogfessmltwdcssdqtwomymjskujjtmxiueopwacrwfuqazitvyhvlspvoaeipdsjhgyfjbxhityisidnhlksfznubucqxwaheamndjxmcxwufajmnveuwuoyosqnoqwvtjkwuhkzghvmjhawcfszbhzrbpgsidnbmxxihihnrfbamcyojqpkzodbejtmmipahojoysepzhpljpaugrghgjimtdahnpivdtlcnptnxjyiaafislqavamqgmxtdfoiaakorebqpbbpegawrqymqkewycsdjglkiwaacdqterkixkgraedtqirqmjtvsfhadhafktyrmkzmvidxmisfskvevpcnujqxrqedleuyowkjgphsxzzqlvujkwwgiodbfjesnbsbzcnftuzrvzjjudsgcqmmfpnmyrenuxotbbyvxyovzxgtcyzgqnsvcfhczoptnfnojnlinbfmylhdlijcvcxzjhdixuckaralemvsnbgooorayceuedtomzyjtctvtwgyiesxhynvogxnjdjphcftbefxgasawzagfugmuthjahylkhatlgpnkuksuesrduxkodwjzgubpsmzzmvkskzeglxaqrrvmrgcwcnvkhwzbibaxwnriowoavosminabvfxastkcrkdclgzjvqrjofjjvbyfragofeoazzeqljuypthkmywaffmcjkickqqsuhsviyovhitxeajqahshpejaqtcdkuvgdpclnsguabtgbfwdmrmbvydorfrbcokfdmtsgboidkpgpnmdeyhawkqqshtwxdbarwuxykgduxjlkxppwyruihkcqgynjcpbylayvgdqfpbqmshksyfbhrfxxemhgbkgmkhjtkzyzdqmxxwqvdtevyducpdksntgyaqtkrrkwiyuhukfadjvdnrievszilfinxbyrvknfihmetreydbcstkwoexwsfhfekfvfplmxszcosgovisnbemrjlndqwkvhqsofdbdychmupcsxvhazvrihhnxfyumonbvqeyoghccxfuwacxzxqkezxefxarnnujgyjugrzjoefmghjfhcrnbrtgouaehwnnxwkdplodpuqxdbemfwahptpfppjzowoltyqijfoabgzejerpatwponuefgdtcrgxswiddygeeflpjeelzccnsztxfyqhqyhkuppapvgvdtkmxraytcolbhkiiasaazkvqzvfxbaaxkoudovxrjkusxdazxaawmvoostlvvnsfbpjqkijvudpriqrfsrdfortimgdhtypunakzituezjyhbrpuksbamuiycngvlvpyvczfxvlwhjgicvempfobbwadkiavdswyuxdttoqaaykctprkwfmyeodowglzyjzuhencufcwdobydslazxadnftllhmjslfbrtdlahkgwlebdpdeofidldoymakfnpgekmsltcrrnxvspywfggjrmxryybdltmsfykstmlnzjitaipfoyohkmzimcozxardydxtpjgquoluzbznzqvlewtqyhryjldjoadgjlyfckzbnbootlzxhupieggntjxilcqxnocpyesnhjbauaxcvmkzusmodlyonoldequfunsbwudquaurogsiyhydswsimflrvfwruouskxjfzfynmrymyyqsvkajpnanvyepnzixyteyafnmwnbwmtojdpsucthxtopgpxgnsmnsrdhpskledapiricvdmtwaifrhnebzuttzckroywranbrvgmashxurelyrrbslxnmzyeowchwpjplrdnjlkfcoqdhheavbnhdlltjpahflwscafnnsspikuqszqpcdyfrkaabdigogatgiitadlinfyhgowjuvqlhrniuvrketfmboibttkgakohbmsvhigqztbvrsgxlnjndrqwmcdnntwofojpyrhamivfcdcotodwhvtuyyjlthbaxmrvfzxrhvzkydartfqbalxyjilepmemawjfxhzecyqcdswxxmaaxxyifmouauibstgpcfwgfmjlfhketkeshfcorqirmssfnbuqiqwqfhbmol", new string[] { "toiscumkhociglkvispihvyoatxcx", "ndojyyephstlonsplrettspwepipw", "yzfkyoqlkrmmfirchzrphveuwmvga", "mxxihihnrfbamcyojqpkzodbejtmm", "fenjcjfdlvcpiatuhjdujhaffqsvq", "ehghndyqjodnnblfwmaygdstotfkv", "heoldutddnksutjakhtghpxxnjykx", "cvrwdewsxdeumhzfrvoilmvksuhyq", "ftqjvzyssocftjwemroghrncynmtc", "idiwclhuepgyynoslhzahtdqwlikt", "eurttrfrmstrbeokzhuzvbfmwywoh", "jxlluilzpysjcnwguyofnhfvhacez", "uskegagtlonducdogwbevugppsptd", "xmcxwufajmnveuwuoyosqnoqwvtjk", "wolpsfxdypmlbjotuxewskisnmczf", "fjryanrmzmpzoefapmnsjdgecrdyw", "jgmxawmndhsvwnjdjvjtxcsjapfog", "wuhkzghvmjhawcfszbhzrbpgsidnb", "yelbldxympctbzfupeocwhkypchuy", "vzduzxudwwqhpftwdspuimioanlzo", "bdpdeofidldoymakfnpgekmsltcrr", "fmyeodowglzyjzuhencufcwdobyds", "dhtypunakzituezjyhbrpuksbamui", "bdmiruibwznqcuczculujfiavzwyn", "eudzjxwbjvagnsjntskmocmpgkybq", "tuynydoakejmwkvojuwbfltqjfgxq", "psrdswqxqsegulcwrwsjnihxedfcq", "cokfdmtsgboidkpgpnmdeyhawkqqs", "fujhvgzdussqbwynylzvtjapvqtid", "rqeuglrsjnmvdsihicsgkybcjltcs", "vhybsbmvymjppfrqmlfrbkpjwpyyy", "aukagphzycvjtvwdhhxzagkevvucc", "hwkduzbxpdhtpvrzrfjndmsqfizmq", "ywnuzzmxeppokxksrfwrpuzqhjgqr", "qbajmepmmizaycwcgmjeopbivsyph", "uamscbxnqnfmmjyehvidnoimmxmtc", "nxvspywfggjrmxryybdltmsfykstm", "amrjbrsiovrxmqsyxhqmritjeauwq", "yorwboxdauhrkxehiwaputeouwxdf", "qkewycsdjglkiwaacdqterkixkgra", "ycngvlvpyvczfxvlwhjgicvempfob", "jgphsxzzqlvujkwwgiodbfjesnbsb", "mkxhemwbbclwdxwgngicplzgajmar", "mryvkeevlthvflsvognbxfjilwkdn", "mezrxffujeysplvavtjqjxsgujqsj", "rtotxqmzxvsqazajvrwsxyeyjteak", "sabctaegttffigupnwgakylngrrxu", "xccuoccdkbboymjtimdrmerspxpkt", "xusnnvngksbjabqjaohdvrniezhmx", "oyuejenqgjheulkxjnqkwvzznricl", "mxszcosgovisnbemrjlndqwkvhqso", "wsgnznrfmxjbdrkwjopylxezxgvet", "dxmisfskvevpcnujqxrqedleuyowk", "dhrgijeplijcvqbormrqglgmzsprt", "vuxchgerokejovrqonxxstibuniki", "lumyzmnzjzhzfpslwsukykwckvkts", "inwkbqmcobubjjpshucechrqrffqs", "ywtxruxokcubekzcrqengviwbtgnz", "ccpnmreqaqjrxwulpunagwxesbila", "pesxtpypenunfpjuyoevzztctecil", "sygfymdcjgvdxutlrhffhnpyjuxmx", "uisdfrvbxzxzhmuektssuktoknkfb", "cejvgynwouzhtfwuuukdbwpmkjrqx", "oudcoagcxjcuqvenznxxnprgvhasf", "sxnlkwgpbznzszyudpwrlgrdgwdyh", "qqbxkaqcyhiobvtqgqruumvvhxolb", "mkhleanvfpemuublnnyzfabtxsest", "bibaxwnriowoavosminabvfxastkc", "bcxgixgrhpfiofpwruzvpqyjzvoll", "lzccnsztxfyqhqyhkuppapvgvdtkm", "pdjkpshvrmqlhindhabubyokzdfrw", "qbbnhwpdokcpfpxinlfmkfrfqrtzk", "rnyelfschnagucguuqqqwitviynry", "qtrjwhrpisocwderqfiqxsdpkphjs", "vxttqosgpplkmxwgmsgtpantazppg", "tyisidnhlksfznubucqxwaheamndj", "kgaqzsckonjuhxdhqztjfxstjvikd", "jeuslzsdwvuoodipdpnlhdihaywzm", "vdzrwwkqvacxwgdhffyvjldgvchoi", "cftbefxgasawzagfugmuthjahylkh", "xraytcolbhkiiasaazkvqzvfxbaax", "oyqtzozufvvlktnvahvsseymtpeyf", "rnnujgyjugrzjoefmghjfhcrnbrtg", "rfzvgvptbgpwajgtysligupoqeoqx", "igbdclqtbikiacwpjrbxhmzejozpy", "dyzwwxgdbeqwlldyezmkopktzugxg", "hmetreydbcstkwoexwsfhfekfvfpl", "zcnftuzrvzjjudsgcqmmfpnmyrenu", "zzmvkskzeglxaqrrvmrgcwcnvkhwz", "vjswvekfyqhjnsusefdtakejxbejr", "rwwzwbcjwiqzkwzfuxfclmsxpdyvf", "fdbdychmupcsxvhazvrihhnxfyumo", "vdtevyducpdksntgyaqtkrrkwiyuh", "nbvqeyoghccxfuwacxzxqkezxefxa", "vpgbefpqpsjmdecmixmmbsjxzwvjd", "jwgqmsvhnykclexepxqxqzghwfxfd", "olyfxbvdrspxqnxnuoygkruczddgs", "qgmxtdfoiaakorebqpbbpegawrqym", "liaivbhcgvjjnxpggrewglalthmzv", "choncklguqgnyrcslwztbstmycjzi", "fpkdpenxlewyxxgrkmwrmshhzfnor", "hhhcaqxbqpthuaafwgrouaxonzocl", "ipahojoysepzhpljpaugrghgjimtd", "wosrmnouwpstgbrvhtlqcnmqbygbf", "nwyskffpxlragrnfffawqtgyfpmzx", "bcvvadhnssbvneecglnqxhavhvxpk", "hoavxqksjreddpmibbodtbhzfehgl", "lazxadnftllhmjslfbrtdlahkgwle", "uuukupjmbbvshzxyniaowdjamlfss", "tpqtazbphmfoluliznftodyguessh", "ychqumiscfkwmqqxunqrfbgqjdwmk", "rkdclgzjvqrjofjjvbyfragofeoaz", "pphhedxdepgfgrqerpuhgmaawhnhq", "cacrsvutylalqrykehjuofisdookj", "kyldfriuvjranikluqtjjcoiqffdx", "bnwvrwgoskzqkgffpsyhfmxhymqin", "uzmlliugckuljfkljoshjhlvvlnyw", "abfxqbdqnexvwsvzvcsbrmkbkuzsd", "xotbbyvxyovzxgtcyzgqnsvcfhczo", "bwtpqcqhvyyssvfknfhxvtodpzipu", "nsfbpjqkijvudpriqrfsrdfortimg", "tgwyqugeuahpuvvzmgarbsyuutmbx", "upnwqzbsazplkyaxqorqsshhlljjl", "edfyahijobxyhimebctobsjudkqst", "ialhfmgjohzoxvdaxuywfqrgmyahh", "jlhcpegmtrelbosyajljvwwedtxbd", "tpfppjzowoltyqijfoabgzejerpat", "mgogyhzpmsdemugqkspsmoppwbnwa", "nubmpwcdqkvhwfuvcahwibniohiqy", "ukfadjvdnrievszilfinxbyrvknfi", "dgnepdiimmkcxhattwglbkicvsfsw", "syqxmarjkshjhxobandwyzggjibjg", "bnwxjytnaejivivriamhgqsskqhnq", "hzyjdcbyuijjnkqluaczrnrbbwaee", "yscnqoohcsxenypyqhfklloudgmkl", "habidqszhxorzfypcjcnopzwigmbz", "wjdqxdrlsqvsxwxpqkljeyjpulbsw", "tytawuuyjrwxboogfessmltwdcssd", "pfixglatdvuogdoizdtsgsztsfcih", "apkvhvsqojyixaechvuoemmyqdlfk", "ouaehwnnxwkdplodpuqxdbemfwahp", "ixuckaralemvsnbgooorayceuedto", "ymxdjrqikughquwtenyucjdgrmipi", "smrwrlkvpnhqrvpdekmtpdfuxzjwp", "bhjakgajafgzxpqckmhdbbnqmcszp", "beqsmluixgsliatukrecgoldmzfhw", "greuevnjssjifvlqlhkllifxrxkdb", "yzsqcrdchhdqprtkkjsccowrjtyjj", "sviyovhitxeajqahshpejaqtcdkuv", "qtwomymjskujjtmxiueopwacrwfuq", "mzyjtctvtwgyiesxhynvogxnjdjph", "dyfbxcaypyquodcpwxkstbthuvjqg", "hfmflesfabvanxlrurjtigkjotftq", "mxydechlraajjmoqpcyoqmrjwoium", "nabesvshjmdbhyhirfrkqkmfwdguj", "bhrfxxemhgbkgmkhjtkzyzdqmxxwq", "gziobrjeanlvyukwlscexbkibvdjh", "mcwwubbnwenybmfqglaceuyqnoadz", "xyzvyblypeongzrttvwqzmrccwkzi", "ncfalqenfcswgerbfcqsapzdtscnz", "dtqpezboimeuyyujfjxkdmbjpizpq", "wmuhplfueqnvnhukgjarxlxvwmriq", "qwapdkoqswyclqyvbvpedzyoyedvu", "uoqbztnftzgahhxwxbgkilnmzfydy", "zsddaahohbszhqxxgripqlwlomjbw", "bwadkiavdswyuxdttoqaaykctprkw", "eixdbntdfcaeatyyainfpkclbgaaq", "nmjnpttflsmjifknezrneedvgzfmn", "avlzyhfmeasmgrjawongccgfbgoua", "kklimhhjqkmuaifnodtpredhqygme", "xzbwenvteifxuuefnimnadwxhruvo", "ugmwlmidtxkvqhbuaecevwhmwkfqm", "rhpyjfxbjjryslfpqoiphrwfjqqha", "eeaipxrokncholathupdetgaktmvm", "ltuimrnsphqslmgvmmojawwptghon", "azitvyhvlspvoaeipdsjhgyfjbxhi", "efrelxezcgikdliyhvpocvvpkvagv", "znxforctwzecxyrkwufpdxadrgzcz", "kcqgynjcpbylayvgdqfpbqmshksyf", "hrljvedsywrlyccpaowjaqyfaqioe", "cjmfyvfybxiuqtkdlzqedjxxbvdsf", "zeqljuypthkmywaffmcjkickqqsuh", "wnfzoyvkiogisdfyjmfomcazigukq", "zyaaqxorqxbkenscbveqbaociwmqx", "ahnpivdtlcnptnxjyiaafislqavam", "edtqirqmjtvsfhadhafktyrmkzmvi", "wponuefgdtcrgxswiddygeeflpjee", "xozgwhtbhlkvrzismnozqpfthajaf", "ptnfnojnlinbfmylhdlijcvcxzjhd", "uxekzlgigjpsukjvsdihrjzgovnre", "rbohxlytsmoeleqrjvievpjipsgdk", "fxtzaxpcfrcovwgrcwqptoekhmgpo", "tvxvvgjbyxpgwpganjiaumojpyhhy", "vqjjhfaupylefbvbsbhdncsshmrhx", "urhedneauccrkyjfiptjfxmpxlssr", "ltvgknnlodtbhnbhjkmuhwxvzgmkh", "ucztsneqttsuirmjriohhgunzatyf", "rbzryfaeuqkfxrbldyusoeoldpbwa", "atlgpnkuksuesrduxkodwjzgubpsm", "lrdniqbzxrbpcvmzpyqklsskpwctg", "qvnvgzkyhistydagsgnujiviyijdn", "uzatydzcnktnkeyztoqvogodxxznh", "ocbvphmtpwhcgjbnmxgidtlqcnnwt", "koudovxrjkusxdazxaawmvoostlvv", "ptruqmjtbaapgmkfnbwnlvzlxwdpz", "xdxtpbpoemekvxzrrakwjxcxqsdas", "gdpclnsguabtgbfwdmrmbvydorfrb", "htwxdbarwuxykgduxjlkxppwyruih" });

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
        }

        public IList<int> FindSubstring(string s, string[] words)
        {
            //List<int> copies = GetCopies(words);

            IList<int> toReturn = new List<int>();

            if (words.Length == 0) return toReturn;

            S = s;
            Words = words;
            WordLen = words[0].Length;

            List<int> standings = GetNewStandings();

            for (int i = 0; i < s.Length - WordLen + 1; i++)
            {
                for (int j = 0; j < Words.Length; j++)
                {
                    //if (copies.Contains(j)) continue;

                    if (Search(RefreshStandings(standings, j), i))
                    {
                        toReturn.Add(i);
                        break;
                    }
                }
            }

            return toReturn;
        }

        private bool Search(List<int> standings, int index)
        {
            if (!WordMaches(standings, ref index))
            {
                return false;
            }
            else if (IsCompletedStandings(standings))
            {
                return true;
            }
            else
            {
                List<int> nextIndexes = GetNextIndexes(standings);

                foreach (int newWordIndex in nextIndexes)
                {
                    List<int> newStandings = standings.ToList();
                    newStandings[newWordIndex] = 0;
                    if (Search(newStandings, index))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private bool WordMaches(List<int> standings, ref int index)
        {
            int wordIndex = GetWordIndex(standings);
            string theWord = Words[wordIndex];

            bool wordMatches = S.Length >= index + theWord.Length && theWord.Equals(S.Substring(index, theWord.Length));

            if (wordMatches)
            {
                MarkStandingAsComplete(standings, wordIndex);
                index += WordLen;
            }

            return wordMatches;
        }

        private void MarkStandingAsComplete(List<int> standings, int index)
        {
            standings[index] = 1;
        }

        private List<int> GetNextIndexes(List<int> standings)
        {
            List<int> toReturn = new List<int>();
            for (int i = 0; i < standings.Count; i++)
            {
                if (standings[i] == -1) toReturn.Add(i);
            }

            return toReturn;
        }

        private int GetWordIndex(List<int> standings)
        {
            int toReturn = 0;
            int maxStandig = 0;

            for (int i = 0; i < standings.Count; i++)
            {
                int standing = standings[i];
                if (standing == 0) return i;

                if (standing > 0 && !IsCompletedStanding(standing) && maxStandig < standing)
                {
                    maxStandig = standing;
                    toReturn = i;
                }
            }

            return toReturn;
        }

        private bool IsCompletedStanding(int standing)
        {
            return standing == 1;
        }

        private bool IsCompletedStandings(List<int> standings)
        {
            foreach (int standing in standings)
            {
                if (!IsCompletedStanding(standing)) return false;
            }

            return true;
        }

        private List<int> GetCopies(string[] words)
        {
            List<int> toReturn = new List<int>();
            List<string> passedWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (passedWords.Contains(word))
                {
                    toReturn.Add(i);
                }
                else
                {
                    passedWords.Add(word);
                }
            }

            return toReturn;
        }

        private List<int> RefreshStandings(List<int> standings, int j)
        {
            for (int i = 0; i < Words.Length; i++)
            {
                standings[i] = i != j ? -1 : 0;
            }
            return standings;
        }

        private List<int> GetNewStandings()
        {
            List<int> standings = new List<int>();
            for (int i = 0; i < Words.Length; i++)
            {
                standings.Add(-1);
            }
            return standings;
        }
    }
}
