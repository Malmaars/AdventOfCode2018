﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3Part1 : MonoBehaviour
{
    public string[] ElfIDs = { "#1@179,662:16x27", "#2@609,961:25x21", "#3@73,376:23x28", "#4@599,405:26x25", "#5@28,933:19x29", "#6@441,852:29x23", "#7@512,396:15x17", "#8@702,415:14x10", "#9@730,587:27x21", "#10@252,715:17x27", "#11@541,822:21x13", "#12@901,802:12x24", "#13@759,349:15x26", "#14@862,839:22x25", "#15@862,576:17x16", "#16@265,967:11x25", "#17@124,444:23x25", "#18@971,141:25x15", "#19@864,246:22x27", "#20@841,34:17x15", "#21@173,462:19x22", "#22@122,22:27x20", "#23@327,178:12x19", "#24@576,663:21x10", "#25@410,958:11x12", "#26@676,145:14x10", "#27@177,676:10x22", "#28@663,60:23x15", "#29@686,352:24x19", "#30@68,618:18x12", "#31@20,643:19x18", "#32@683,128:19x22", "#33@88,45:28x25", "#34@442,736:20x29", "#35@824,825:13x13", "#36@668,253:25x27", "#37@254,404:27x25", "#38@712,260:26x17", "#39@588,470:21x20", "#40@114,148:11x26", "#41@242,409:17x26", "#42@342,481:24x21", "#43@104,187:27x12", "#44@440,919:13x22", "#45@177,312:22x15", "#46@249,925:29x15", "#47@376,750:19x20", "#48@157,760:21x21", "#49@760,833:28x15", "#50@955,909:26x12", "#51@941,896:17x25", "#52@154,33:29x20", "#53@236,275:27x29", "#54@848,800:11x18", "#55@950,130:28x24", "#56@351,564:21x11", "#57@32,70:17x11", "#58@215,219:22x18", "#59@816,714:15x21", "#60@738,879:16x27", "#61@218,896:26x27", "#62@953,363:16x19", "#63@836,508:28x13", "#64@839,14:12x21", "#65@831,683:24x15", "#66@809,698:12x26", "#67@887,296:23x11", "#68@770,771:29x21", "#69@383,762:14x25", "#70@542,962:28x14", "#71@236,286:18x10", "#72@517,363:12x18", "#73@171,753:16x17", "#74@272,910:18x20", "#75@658,202:25x14", "#76@534,906:18x25", "#77@468,342:27x12", "#78@426,350:28x26", "#79@277,968:12x20", "#80@390,877:10x27", "#81@859,603:26x12", "#82@491,937:13x16", "#83@19,883:20x15", "#84@47,400:27x15", "#85@627,191:14x26", "#86@164,326:17x28", "#87@768,216:20x24", "#88@947,765:15x19", "#89@917,142:11x20", "#90@351,87:24x29", "#91@872,451:29x10", "#92@749,900:20x26", "#93@935,30:25x12", "#94@221,943:15x10", "#95@344,602:12x24", "#96@677,578:16x26", "#97@452,606:21x10", "#98@2,722:19x22", "#99@310,605:17x29", "#100@262,390:26x23", "#101@640,499:19x13", "#102@852,924:26x16", "#103@309,81:20x16", "#104@108,918:18x11", "#105@249,160:9x17", "#106@26,62:26x25", "#107@407,587:14x24", "#108@956,98:18x27", "#109@944,459:16x26", "#110@209,699:28x25", "#111@710,856:12x22", "#112@744,288:27x25", "#113@489,344:20x21", "#114@438,488:12x16", "#115@884,95:15x22", "#116@60,617:24x24", "#117@957,191:10x11", "#118@315,527:22x23", "#119@199,117:18x26", "#120@255,642:10x15", "#121@957,962:11x14", "#122@193,131:10x13", "#123@2,931:21x11", "#124@36,961:27x23", "#125@863,38:29x14", "#126@31,731:13x15", "#127@357,741:28x15", "#128@209,354:27x23", "#129@524,8:22x20", "#130@302,247:15x12", "#131@76,857:10x16", "#132@531,502:24x10", "#133@559,962:17x15", "#134@233,710:29x15", "#135@762,70:15x24", "#136@934,186:25x20", "#137@808,252:29x29", "#138@550,694:22x19", "#139@265,368:23x25", "#140@640,637:11x14", "#141@736,484:15x10", "#142@946,571:27x17", "#143@332,174:20x20", "#144@797,775:11x23", "#145@684,63:22x13", "#146@932,36:20x12", "#147@375,882:19x17", "#148@656,227:12x20", "#149@455,223:12x15", "#150@732,619:20x20", "#151@292,615:19x29", "#152@615,0:15x28", "#153@463,174:16x15", "#154@322,456:27x15", "#155@352,224:10x15", "#156@966,673:29x21", "#157@527,42:23x27", "#158@632,775:15x15", "#159@871,805:22x15", "#160@667,240:15x27", "#161@607,880:25x25", "#162@447,44:10x21", "#163@445,126:17x15", "#164@844,933:11x29", "#165@471,423:24x27", "#166@715,867:16x16", "#167@778,279:10x18", "#168@490,630:23x16", "#169@687,301:28x13", "#170@476,432:11x18", "#171@123,794:23x26", "#172@738,256:22x25", "#173@336,60:26x28", "#174@698,766:4x10", "#175@511,10:13x10", "#176@580,702:18x20", "#177@218,620:13x22", "#178@476,488:13x25", "#179@154,617:14x29", "#180@620,563:11x6", "#181@168,433:28x10", "#182@60,685:10x24", "#183@880,680:18x18", "#184@859,616:17x25", "#185@114,80:26x19", "#186@236,868:25x10", "#187@135,13:26x29", "#188@810,677:22x10", "#189@938,932:16x14", "#190@427,434:14x11", "#191@83,731:29x23", "#192@960,148:25x16", "#193@577,669:24x16", "#194@67,267:18x29", "#195@603,928:15x26", "#196@881,39:29x11", "#197@963,957:19x23", "#198@891,868:12x13", "#199@799,34:14x12", "#200@529,785:24x27", "#201@596,936:12x21", "#202@832,289:13x10", "#203@664,232:17x22", "#204@171,345:24x26", "#205@283,521:28x22", "#206@702,469:14x10", "#207@490,531:21x27", "#208@411,388:26x21", "#209@120,780:13x28", "#210@711,391:24x12", "#211@347,848:22x13", "#212@956,507:20x18", "#213@844,696:20x26", "#214@550,230:28x25", "#215@71,625:14x26", "#216@701,305:29x23", "#217@629,488:21x14", "#218@966,362:10x26", "#219@802,763:17x19", "#220@631,858:22x17", "#221@175,656:24x26", "#222@822,185:17x15", "#223@110,390:11x19", "#224@328,13:28x26", "#225@479,262:22x12", "#226@178,796:25x25", "#227@23,782:18x21", "#228@597,578:10x12", "#229@692,683:26x29", "#230@268,713:21x28", "#231@112,197:21x15", "#232@619,282:21x19", "#233@765,56:21x29", "#234@96,163:29x11", "#235@229,927:18x29", "#236@588,775:27x29", "#237@498,293:23x15", "#238@311,166:14x25", "#239@134,371:27x28", "#240@450,173:24x16", "#241@700,398:28x12", "#242@216,282:25x10", "#243@886,817:16x15", "#244@291,967:29x25", "#245@406,283:14x20", "#246@601,779:26x28", "#247@767,213:20x10", "#248@802,36:15x17", "#249@264,361:19x27", "#250@565,236:23x28", "#251@260,394:21x18", "#252@506,427:17x26", "#253@479,946:28x10", "#254@463,505:24x19", "#255@42,314:27x27", "#256@901,709:26x14", "#257@716,194:21x29", "#258@404,285:18x21", "#259@838,243:29x28", "#260@276,510:23x11", "#261@66,605:29x16", "#262@225,3:26x16", "#263@451,355:22x21", "#264@423,41:19x17", "#265@942,912:14x11", "#266@915,613:22x11", "#267@316,786:25x24", "#268@640,185:24x17", "#269@4,564:29x18", "#270@535,912:21x16", "#271@95,633:13x17", "#272@517,170:21x19", "#273@857,812:14x23", "#274@682,515:12x21", "#275@615,847:22x14", "#276@547,47:26x18", "#277@461,552:19x28", "#278@866,29:28x28", "#279@725,878:17x15", "#280@604,454:19x24", "#281@529,452:28x12", "#282@731,633:23x22", "#283@505,447:27x18", "#284@75,694:12x16", "#285@212,909:29x13", "#286@96,630:15x29", "#287@168,34:28x18", "#288@935,481:23x26", "#289@892,235:27x16", "#290@942,945:13x15", "#291@759,221:13x25", "#292@604,339:10x27", "#293@699,313:17x23", "#294@319,716:22x24", "#295@718,219:26x26", "#296@11,917:13x19", "#297@666,632:13x24", "#298@85,791:25x29", "#299@179,204:20x17", "#300@292,234:27x11", "#301@527,488:15x19", "#302@651,158:22x10", "#303@727,98:25x25", "#304@452,9:23x26", "#305@520,386:23x22", "#306@755,196:26x11", "#307@321,107:13x25", "#308@654,563:20x25", "#309@188,228:11x23", "#310@416,355:22x19", "#311@679,567:12x8", "#312@319,282:17x27", "#313@276,620:23x23", "#314@50,242:11x19", "#315@759,918:23x19", "#316@599,84:18x21", "#317@675,230:15x28", "#318@96,480:13x13", "#319@386,254:24x19", "#320@682,199:22x19", "#321@14,819:12x14", "#322@231,451:19x17", "#323@36,396:27x13", "#324@459,917:18x26", "#325@149,874:11x10", "#326@182,325:11x25", "#327@142,279:17x12", "#328@954,276:27x24", "#329@512,263:16x19", "#330@446,841:25x25", "#331@79,247:15x11", "#332@378,881:20x17", "#333@958,324:18x22", "#334@583,501:13x23", "#335@966,133:16x20", "#336@236,395:19x19", "#337@588,910:18x10", "#338@35,406:20x25", "#339@326,404:20x29", "#340@293,761:16x24", "#341@420,371:5x5", "#342@694,764:12x17", "#343@617,15:10x14", "#344@859,915:11x15", "#345@522,430:20x17", "#346@727,180:15x14", "#347@208,679:11x16", "#348@523,670:28x22", "#349@512,436:15x13", "#350@170,11:25x18", "#351@353,588:23x12", "#352@201,605:26x12", "#353@561,681:15x12", "#354@500,357:12x12", "#355@813,438:26x26", "#356@759,853:14x28", "#357@152,737:27x27", "#358@646,721:11x13", "#359@588,446:15x21", "#360@713,927:21x28", "#361@189,43:21x29", "#362@655,722:29x22", "#363@614,184:17x14", "#364@465,10:12x19", "#365@493,612:11x24", "#366@594,442:13x18", "#367@392,893:11x16", "#368@77,740:12x21", "#369@628,138:12x27", "#370@173,500:20x11", "#371@363,587:13x27", "#372@852,276:25x19", "#373@410,949:13x10", "#374@359,948:25x25", "#375@546,677:11x29", "#376@854,582:23x19", "#377@761,145:11x10", "#378@300,888:22x17", "#379@284,791:27x16", "#380@758,255:13x20", "#381@453,16:21x16", "#382@525,183:21x22", "#383@114,307:18x15", "#384@556,225:28x20", "#385@463,19:19x13", "#386@601,579:24x14", "#387@314,870:19x21", "#388@541,438:22x17", "#389@704,543:26x11", "#390@420,537:21x22", "#391@728,211:10x17", "#392@232,822:25x16", "#393@482,339:16x17", "#394@460,129:22x18", "#395@223,181:24x28", "#396@270,740:25x24", "#397@220,22:16x17", "#398@416,414:15x21", "#399@391,524:10x20", "#400@448,282:12x29", "#401@247,862:16x13", "#402@967,527:17x20", "#403@279,637:12x15", "#404@792,166:16x29", "#405@597,902:21x12", "#406@375,729:11x13", "#407@404,395:15x27", "#408@852,581:27x17", "#409@97,859:14x19", "#410@867,477:23x24", "#411@419,139:20x23", "#412@395,956:23x15", "#413@498,388:22x24", "#414@880,814:13x19", "#415@845,417:12x25", "#416@498,357:27x29", "#417@366,739:24x29", "#418@86,66:20x23", "#419@619,871:17x4", "#420@896,449:25x24", "#421@414,64:13x27", "#422@308,77:27x10", "#423@105,927:15x12", "#424@213,110:18x26", "#425@912,820:12x15", "#426@755,643:22x13", "#427@850,256:17x12", "#428@581,456:18x29", "#429@881,461:28x22", "#430@204,903:27x19", "#431@12,578:22x13", "#432@69,762:22x27", "#433@140,879:15x18", "#434@548,924:20x23", "#435@256,293:28x22", "#436@583,438:29x27", "#437@31,936:17x11", "#438@53,289:23x26", "#439@753,871:16x27", "#440@64,856:21x28", "#441@832,962:11x15", "#442@305,969:17x29", "#443@562,103:24x24", "#444@243,231:18x11", "#445@210,19:10x29", "#446@62,702:28x18", "#447@167,127:13x29", "#448@751,334:12x20", "#449@404,236:27x28", "#450@869,107:20x18", "#451@167,687:22x22", "#452@79,449:29x19", "#453@821,288:15x26", "#454@235,926:18x10", "#455@902,705:16x18", "#456@777,189:23x25", "#457@560,141:23x17", "#458@711,900:28x12", "#459@650,864:23x19", "#460@965,91:25x29", "#461@366,589:24x18", "#462@262,423:25x21", "#463@775,176:25x10", "#464@634,899:24x15", "#465@330,489:21x16", "#466@711,668:28x14", "#467@283,699:17x15", "#468@12,741:14x11", "#469@10,532:17x19", "#470@763,148:12x17", "#471@630,884:13x26", "#472@39,381:12x19", "#473@313,382:4x17", "#474@617,862:22x18", "#475@113,120:20x21", "#476@913,322:26x17", "#477@197,33:22x15", "#478@760,220:22x29", "#479@395,195:17x4", "#480@25,469:16x19", "#481@289,620:13x20", "#482@41,395:15x21", "#483@50,148:24x22", "#484@787,117:29x24", "#485@456,623:28x15", "#486@938,37:19x10", "#487@475,340:16x22", "#488@221,808:28x22", "#489@387,452:17x19", "#490@835,789:21x23", "#491@153,456:29x20", "#492@462,344:19x13", "#493@927,8:16x27", "#494@172,734:19x15", "#495@562,52:27x15", "#496@781,826:19x26", "#497@204,123:17x13", "#498@839,514:26x25", "#499@324,417:29x11", "#500@746,828:19x11", "#501@737,580:18x14", "#502@802,22:28x20", "#503@974,392:19x17", "#504@426,55:16x14", "#505@845,795:19x13", "#506@261,102:10x27", "#507@415,400:14x22", "#508@62,0:19x29", "#509@643,429:28x10", "#510@713,121:18x19", "#511@829,23:17x16", "#512@268,80:10x11", "#513@826,654:28x29", "#514@73,96:19x18", "#515@696,417:22x13", "#516@253,437:26x29", "#517@842,523:16x10", "#518@274,960:28x10", "#519@410,317:16x22", "#520@334,981:26x18", "#521@183,480:25x29", "#522@794,659:26x26", "#523@416,188:25x10", "#524@735,400:17x21", "#525@836,779:15x26", "#526@913,298:12x15", "#527@28,507:10x18", "#528@596,697:20x20", "#529@322,163:12x20", "#530@626,94:21x10", "#531@39,391:14x10", "#532@894,108:11x29", "#533@384,173:25x18", "#534@557,974:11x23", "#535@780,805:10x11", "#536@448,734:27x14", "#537@68,349:27x17", "#538@215,700:15x13", "#539@921,309:26x16", "#540@312,665:15x3", "#541@301,946:16x22", "#542@798,747:11x22", "#543@850,675:28x28", "#544@438,425:11x18", "#545@477,537:16x25", "#546@869,878:22x22", "#547@830,106:26x15", "#548@16,880:23x28", "#549@89,598:25x10", "#550@911,746:25x20", "#551@132,268:27x14", "#552@107,54:22x16", "#553@617,920:17x25", "#554@888,796:17x17", "#555@911,21:21x13", "#556@901,126:12x28", "#557@501,378:25x26", "#558@231,749:28x10", "#559@534,889:12x24", "#560@388,923:17x14", "#561@113,84:15x28", "#562@924,424:19x27", "#563@669,933:29x22", "#564@317,796:22x24", "#565@149,894:18x11", "#566@815,914:21x17", "#567@686,540:28x10", "#568@531,331:20x24", "#569@459,576:15x28", "#570@127,520:15x24", "#571@466,572:13x26", "#572@935,555:18x19", "#573@461,946:12x20", "#574@918,162:11x12", "#575@279,305:21x15", "#576@650,714:15x13", "#577@486,776:12x27", "#578@81,253:20x17", "#579@906,18:22x14", "#580@306,26:16x16", "#581@184,724:17x28", "#582@751,225:15x10", "#583@26,783:21x11", "#584@103,41:21x26", "#585@283,5:12x24", "#586@733,375:13x27", "#587@193,973:11x21", "#588@47,306:19x14", "#589@964,124:11x19", "#590@856,321:19x12", "#591@437,655:29x14", "#592@368,437:25x24", "#593@537,154:28x17", "#594@574,451:11x13", "#595@963,342:21x26", "#596@250,492:22x18", "#597@962,740:22x14", "#598@697,784:29x22", "#599@153,323:23x23", "#600@534,713:13x12", "#601@75,73:22x18", "#602@166,755:15x12", "#603@273,622:22x12", "#604@660,432:10x24", "#605@119,965:25x25", "#606@751,294:28x14", "#607@676,358:13x11", "#608@204,588:17x29", "#609@792,828:21x14", "#610@163,141:27x12", "#611@159,33:22x19", "#612@158,364:13x15", "#613@711,929:16x14", "#614@811,654:18x29", "#615@903,828:24x20", "#616@323,111:23x26", "#617@891,258:28x28", "#618@551,826:25x12", "#619@660,935:29x19", "#620@41,27:28x19", "#621@590,491:26x24", "#622@174,31:10x25", "#623@563,817:21x25", "#624@961,746:13x27", "#625@599,403:13x11", "#626@852,661:22x27", "#627@84,473:18x19", "#628@580,98:28x27", "#629@138,506:28x15", "#630@981,544:16x26", "#631@418,908:23x24", "#632@371,926:22x25", "#633@701,291:11x20", "#634@66,889:28x25", "#635@641,689:14x26", "#636@177,960:10x16", "#637@60,39:20x18", "#638@378,445:14x25", "#639@113,794:17x16", "#640@197,627:22x16", "#641@324,530:12x25", "#642@8,206:18x29", "#643@359,893:23x15", "#644@795,198:19x17", "#645@239,900:12x20", "#646@504,343:19x10", "#647@708,677:29x10", "#648@63,697:14x12", "#649@403,203:25x18", "#650@305,183:16x18", "#651@609,447:20x22", "#652@508,394:16x29", "#653@178,144:29x27", "#654@870,490:23x19", "#655@130,855:27x14", "#656@333,563:25x14", "#657@862,252:18x16", "#658@40,384:20x29", "#659@639,299:13x10", "#660@869,856:12x23", "#661@35,495:13x28", "#662@545,322:16x26", "#663@671,566:11x12", "#664@342,10:10x17", "#665@932,940:21x14", "#666@726,480:11x11", "#667@249,632:17x21", "#668@939,830:11x14", "#669@812,241:19x25", "#670@739,641:15x21", "#671@307,873:21x25", "#672@845,687:13x11", "#673@953,676:26x17", "#674@137,960:26x13", "#675@853,498:29x13", "#676@396,599:17x17", "#677@431,839:27x27", "#678@745,290:23x16", "#679@336,849:12x23", "#680@852,492:28x15", "#681@467,781:25x23", "#682@525,668:18x15", "#683@941,189:25x24", "#684@130,323:17x26", "#685@410,612:12x20", "#686@967,499:13x23", "#687@947,263:16x22", "#688@158,434:13x13", "#689@920,298:13x15", "#690@361,415:16x21", "#691@302,600:21x20", "#692@65,356:20x24", "#693@855,427:13x12", "#694@877,366:10x10", "#695@138,415:20x14", "#696@818,653:27x12", "#697@829,540:15x29", "#698@636,121:19x28", "#699@324,960:16x23", "#700@680,614:10x11", "#701@380,819:21x21", "#702@873,107:11x15", "#703@42,644:11x17", "#704@62,860:17x21", "#705@728,704:27x27", "#706@604,488:17x25", "#707@418,252:28x14", "#708@715,408:28x17", "#709@747,225:21x13", "#710@124,787:18x18", "#711@394,376:29x18", "#712@182,552:13x16", "#713@129,424:19x23", "#714@852,526:18x12", "#715@849,634:21x19", "#716@220,22:14x21", "#717@327,870:18x15", "#718@627,170:10x13", "#719@108,768:17x22", "#720@870,303:11x28", "#721@616,917:19x18", "#722@118,316:10x11", "#723@476,355:12x13", "#724@235,946:23x12", "#725@310,723:24x21", "#726@28,483:14x28", "#727@746,202:26x12", "#728@736,404:19x28", "#729@973,143:21x26", "#730@226,9:18x24", "#731@717,746:29x26", "#732@793,668:28x19", "#733@446,177:11x25", "#734@86,243:27x11", "#735@73,13:15x25", "#736@225,706:13x13", "#737@852,950:25x10", "#738@502,427:13x15", "#739@950,504:26x17", "#740@761,290:21x24", "#741@90,378:28x29", "#742@431,457:27x13", "#743@196,666:15x29", "#744@439,105:10x29", "#745@788,261:28x10", "#746@947,904:13x12", "#747@328,973:17x25", "#748@255,758:22x26", "#749@320,426:21x21", "#750@735,258:16x24", "#751@883,333:21x25", "#752@5,510:10x23", "#753@389,972:20x14", "#754@671,937:18x10", "#755@728,342:20x18", "#756@247,617:26x13", "#757@301,241:25x19", "#758@971,653:18x25", "#759@807,30:25x14", "#760@318,525:14x12", "#761@640,618:26x24", "#762@788,253:25x26", "#763@393,192:23x12", "#764@522,920:13x26", "#765@232,204:14x18", "#766@953,862:22x25", "#767@41,239:22x18", "#768@760,535:11x25", "#769@84,868:28x26", "#770@920,703:19x26", "#771@678,544:27x17", "#772@814,591:18x11", "#773@15,181:18x10", "#774@725,661:22x11", "#775@241,691:18x17", "#776@84,81:14x29", "#777@909,818:14x23", "#778@357,478:27x25", "#779@537,878:24x15", "#780@812,832:16x18", "#781@528,394:24x29", "#782@411,603:15x12", "#783@94,727:10x16", "#784@968,146:24x27", "#785@755,195:22x11", "#786@948,802:21x13", "#787@509,266:10x28", "#788@626,463:21x19", "#789@766,203:19x22", "#790@450,28:12x24", "#791@290,589:25x12", "#792@294,195:22x28", "#793@481,949:22x20", "#794@732,708:25x13", "#795@292,706:17x20", "#796@502,6:13x10", "#797@119,382:29x23", "#798@300,953:16x22", "#799@978,231:18x16", "#800@119,409:23x12", "#801@390,634:27x13", "#802@958,124:19x21", "#803@423,437:27x13", "#804@394,299:27x19", "#805@973,910:24x10", "#806@462,133:29x11", "#807@529,750:17x15", "#808@80,744:12x17", "#809@56,99:19x17", "#810@926,721:12x28", "#811@916,569:27x15", "#812@723,376:13x27", "#813@852,824:26x23", "#814@953,944:17x10", "#815@786,937:28x17", "#816@188,705:17x24", "#817@543,456:13x18", "#818@676,918:20x10", "#819@97,706:24x29", "#820@722,656:29x18", "#821@182,328:24x15", "#822@490,397:28x20", "#823@247,217:19x20", "#824@217,592:12x21", "#825@452,201:14x25", "#826@348,612:11x26", "#827@652,935:22x21", "#828@650,925:29x21", "#829@495,247:15x29", "#830@594,561:20x15", "#831@220,460:29x25", "#832@642,117:12x20", "#833@235,533:24x13", "#834@285,755:14x11", "#835@739,473:23x21", "#836@268,387:20x16", "#837@459,275:28x10", "#838@493,572:13x21", "#839@320,720:18x20", "#840@168,757:5x6", "#841@496,368:29x18", "#842@419,45:15x22", "#843@749,524:23x19", "#844@413,68:25x19", "#845@250,698:16x27", "#846@101,697:26x13", "#847@968,332:11x19", "#848@953,137:19x11", "#849@134,396:27x19", "#850@891,465:13x28", "#851@40,931:24x18", "#852@170,775:25x10", "#853@187,26:18x15", "#854@677,28:19x17", "#855@752,274:22x16", "#856@217,376:15x17", "#857@379,249:15x28", "#858@308,661:25x16", "#859@514,704:28x16", "#860@281,235:26x23", "#861@430,650:15x28", "#862@784,125:26x25", "#863@212,123:19x14", "#864@946,191:15x8", "#865@405,399:21x27", "#866@443,484:19x16", "#867@769,626:17x25", "#868@119,786:29x19", "#869@890,20:26x28", "#870@12,161:11x24", "#871@957,869:11x12", "#872@332,736:28x15", "#873@178,967:27x10", "#874@323,441:23x10", "#875@229,436:28x16", "#876@734,578:23x17", "#877@433,614:25x27", "#878@30,160:28x18", "#879@217,279:26x21", "#880@621,130:27x15", "#881@465,601:26x28", "#882@231,580:25x11", "#883@300,512:25x23", "#884@422,258:22x19", "#885@308,530:15x13", "#886@164,202:10x12", "#887@412,181:18x21", "#888@121,766:25x18", "#889@177,945:14x16", "#890@30,162:13x26", "#891@437,565:23x27", "#892@454,280:26x27", "#893@379,526:23x12", "#894@834,707:13x5", "#895@859,357:24x28", "#896@891,303:16x14", "#897@385,116:28x20", "#898@53,12:24x22", "#899@428,979:24x20", "#900@916,602:28x17", "#901@19,739:16x21", "#902@871,32:18x22", "#903@207,110:12x16", "#904@932,15:26x19", "#905@691,232:11x18", "#906@965,799:20x20", "#907@241,526:24x23", "#908@931,915:18x14", "#909@662,584:24x14", "#910@30,148:10x17", "#911@50,466:24x29", "#912@265,504:22x10", "#913@59,857:28x24", "#914@170,780:18x27", "#915@436,51:27x12", "#916@921,139:16x17", "#917@532,377:16x23", "#918@237,188:20x27", "#919@672,653:11x20", "#920@333,546:13x18", "#921@830,191:25x27", "#922@745,644:24x23", "#923@877,371:17x28", "#924@926,426:12x19", "#925@731,977:13x21", "#926@12,122:14x14", "#927@65,896:17x28", "#928@126,609:29x13", "#929@557,244:24x22", "#930@80,21:14x24", "#931@725,184:18x28", "#932@654,181:18x12", "#933@439,283:14x21", "#934@974,95:26x15", "#935@235,9:10x17", "#936@306,422:24x21", "#937@383,952:29x10", "#938@738,201:23x15", "#939@254,624:26x19", "#940@421,672:17x14", "#941@221,751:12x28", "#942@730,768:13x18", "#943@342,13:17x18", "#944@594,639:24x17", "#945@127,323:16x12", "#946@861,701:13x10", "#947@696,541:28x24", "#948@804,363:12x25", "#949@958,296:29x13", "#950@126,868:16x20", "#951@916,483:26x15", "#952@318,52:19x22", "#953@240,938:18x11", "#954@849,275:16x11", "#955@712,412:27x26", "#956@913,613:14x15", "#957@756,476:20x18", "#958@656,906:14x11", "#959@461,633:12x26", "#960@398,208:19x12", "#961@490,333:14x14", "#962@816,658:16x27", "#963@579,562:17x19", "#964@961,552:16x29", "#965@393,947:27x19", "#966@68,464:18x13", "#967@318,537:21x13", "#968@904,171:28x13", "#969@629,974:23x22", "#970@415,366:15x19", "#971@401,976:26x13", "#972@18,44:26x12", "#973@18,804:27x26", "#974@134,446:25x22", "#975@158,464:19x13", "#976@623,437:9x3", "#977@376,181:19x15", "#978@738,397:26x27", "#979@338,207:20x23", "#980@218,403:27x17", "#981@530,937:27x10", "#982@134,958:11x19", "#983@675,514:13x17", "#984@891,383:10x27", "#985@935,748:15x11", "#986@943,956:25x22", "#987@18,649:11x14", "#988@740,243:21x10", "#989@404,309:14x22", "#990@134,19:13x19", "#991@406,381:14x23", "#992@428,395:18x13", "#993@121,971:18x15", "#994@62,794:25x17", "#995@134,403:20x13", "#996@347,567:20x29", "#997@615,358:3x18", "#998@852,28:15x16", "#999@259,379:27x24", "#1000@268,617:20x20", "#1001@956,657:20x22", "#1002@924,876:26x18", "#1003@748,411:12x14", "#1004@882,249:29x10", "#1005@979,25:21x17", "#1006@559,126:25x28", "#1007@569,712:28x13", "#1008@623,781:25x16", "#1009@422,607:25x10", "#1010@613,904:11x26", "#1011@128,411:16x17", "#1012@9,195:22x12", "#1013@83,362:14x23", "#1014@617,149:26x18", "#1015@382,436:12x21", "#1016@613,855:23x16", "#1017@956,222:24x17", "#1018@400,977:12x15", "#1019@181,333:18x17", "#1020@610,174:25x14", "#1021@825,26:13x24", "#1022@296,778:26x14", "#1023@465,135:24x16", "#1024@638,807:10x14", "#1025@547,697:19x15", "#1026@103,663:15x21", "#1027@71,113:20x28", "#1028@325,498:27x28", "#1029@525,808:23x19", "#1030@828,949:15x27", "#1031@46,699:11x18", "#1032@676,396:29x29", "#1033@552,889:25x27", "#1034@943,865:15x22", "#1035@480,310:27x20", "#1036@714,270:29x17", "#1037@647,711:18x15", "#1038@590,431:24x16", "#1039@675,554:20x26", "#1040@287,13:17x20", "#1041@886,310:16x28", "#1042@219,353:15x22", "#1043@215,12:14x17", "#1044@307,541:29x22", "#1045@151,734:22x22", "#1046@517,785:14x24", "#1047@617,89:15x26", "#1048@726,978:13x22", "#1049@404,546:25x29", "#1050@395,372:23x15", "#1051@249,583:21x21", "#1052@941,455:23x15", "#1053@801,651:19x11", "#1054@186,120:10x22", "#1055@562,177:11x10", "#1056@504,441:14x29", "#1057@401,274:11x16", "#1058@69,463:24x28", "#1059@409,955:20x27", "#1060@856,263:26x20", "#1061@747,821:23x11", "#1062@243,158:20x22", "#1063@694,957:27x10", "#1064@370,666:29x23", "#1065@74,640:14x24", "#1066@330,223:11x21", "#1067@93,659:27x10", "#1068@916,571:20x24", "#1069@681,208:10x26", "#1070@62,125:27x28", "#1071@163,527:14x24", "#1072@353,71:23x22", "#1073@938,1:12x27", "#1074@561,956:20x26", "#1075@850,491:29x23", "#1076@762,231:16x28", "#1077@391,96:13x24", "#1078@359,435:14x17", "#1079@150,326:15x20", "#1080@615,695:29x17", "#1081@477,123:24x14", "#1082@851,99:12x26", "#1083@328,627:22x29", "#1084@925,616:14x23", "#1085@59,897:23x19", "#1086@152,379:23x15", "#1087@255,415:19x22", "#1088@921,476:19x24", "#1089@946,215:23x16", "#1090@384,725:23x11", "#1091@612,353:18x29", "#1092@443,193:22x20", "#1093@41,141:18x10", "#1094@288,10:24x19", "#1095@623,908:11x20", "#1096@424,159:27x19", "#1097@896,878:16x29", "#1098@466,334:27x18", "#1099@589,755:23x25", "#1100@341,592:13x27", "#1101@220,387:16x12", "#1102@958,510:15x9", "#1103@252,435:11x23", "#1104@143,853:15x10", "#1105@841,205:14x29", "#1106@439,456:11x19", "#1107@937,828:18x21", "#1108@725,650:24x26", "#1109@851,222:19x26", "#1110@248,423:5x4", "#1111@740,325:10x23", "#1112@474,960:20x22", "#1113@943,946:11x26", "#1114@590,580:18x25", "#1115@472,370:19x17", "#1116@804,427:29x16", "#1117@679,42:16x14", "#1118@318,272:12x28", "#1119@372,878:10x12", "#1120@685,223:16x26", "#1121@853,19:23x12", "#1122@532,63:27x18", "#1123@456,320:28x19", "#1124@888,828:25x24", "#1125@348,461:19x25", "#1126@873,395:15x13", "#1127@705,451:27x28", "#1128@730,589:11x26", "#1129@667,727:20x24", "#1130@101,130:24x23", "#1131@563,688:28x21", "#1132@5,143:26x19", "#1133@522,671:19x23", "#1134@481,350:19x23", "#1135@4,125:25x18", "#1136@118,943:26x24", "#1137@371,834:20x26", "#1138@523,751:22x10", "#1139@92,181:18x16", "#1140@904,145:20x17", "#1141@280,513:25x28", "#1142@43,61:17x19", "#1143@602,643:12x9", "#1144@499,293:12x10", "#1145@155,345:28x25", "#1146@572,503:17x21", "#1147@537,595:28x12", "#1148@256,841:18x25", "#1149@621,431:16x14", "#1150@657,258:23x12", "#1151@305,436:24x18", "#1152@907,820:12x15", "#1153@65,744:26x23", "#1154@230,861:18x17", "#1155@333,12:23x24", "#1156@248,418:23x27", "#1157@469,958:19x12", "#1158@35,931:11x14", "#1159@288,563:10x29", "#1160@43,378:14x11", "#1161@88,739:12x25", "#1162@804,900:21x29", "#1163@381,76:22x24", "#1164@30,502:16x14", "#1165@527,603:12x14", "#1166@956,209:15x19", "#1167@960,546:29x14", "#1168@188,744:10x19", "#1169@175,744:12x29", "#1170@133,778:22x21", "#1171@174,205:14x20", "#1172@690,959:21x12", "#1173@619,491:13x22", "#1174@813,594:18x12", "#1175@876,607:29x13", "#1176@900,6:19x18", "#1177@967,721:13x25", "#1178@189,232:19x26", "#1179@827,553:24x18", "#1180@402,245:28x17", "#1181@162,896:14x17", "#1182@914,1:22x27", "#1183@208,134:22x19", "#1184@526,331:29x22", "#1185@145,202:22x13", "#1186@409,861:25x13", "#1187@801,730:28x18", "#1188@624,487:20x15", "#1189@393,687:15x29", "#1190@279,958:15x29", "#1191@653,395:26x27", "#1192@179,26:10x19", "#1193@260,76:29x25", "#1194@859,406:18x10", "#1195@296,932:21x23", "#1196@301,974:16x26", "#1197@727,757:29x10", "#1198@657,397:17x20", "#1199@442,937:18x26", "#1200@29,508:19x15", "#1201@636,245:24x12", "#1202@960,402:28x12", "#1203@139,256:17x29", "#1204@168,117:23x15", "#1205@770,785:27x29", "#1206@752,276:21x21", "#1207@883,889:13x13", "#1208@62,918:21x10", "#1209@163,517:17x12", "#1210@470,613:19x11", "#1211@451,661:26x29", "#1212@211,38:19x13", "#1213@539,439:19x28", "#1214@339,229:23x21", "#1215@591,542:26x25", "#1216@41,643:29x21", "#1217@806,823:14x19", "#1218@628,245:11x18", "#1219@378,619:20x19", "#1220@250,444:14x22", "#1221@713,891:17x12", "#1222@144,430:27x21", "#1223@125,200:27x29", "#1224@525,664:15x22", "#1225@369,485:23x27", "#1226@868,564:29x20", "#1227@642,700:11x12", "#1228@951,6:14x25", "#1229@532,331:24x13", "#1230@937,480:15x12", "#1231@81,65:27x25", "#1232@153,263:11x26", "#1233@970,364:14x19", "#1234@143,454:26x27", "#1235@495,574:7x15", "#1236@850,209:20x17", "#1237@126,965:23x29", "#1238@870,675:23x28", "#1239@308,376:14x28", "#1240@578,755:14x24", "#1241@844,481:23x22", "#1242@734,769:25x16", "#1243@723,219:22x27", "#1244@159,695:23x18", "#1245@754,285:26x22", "#1246@345,974:26x23", "#1247@29,69:27x12", "#1248@181,784:15x12", "#1249@682,616:5x6", "#1250@208,28:27x28", "#1251@665,234:18x23", "#1252@961,288:11x22", "#1253@363,57:19x21", "#1254@662,137:25x24", "#1255@7,41:21x15", "#1256@693,784:12x28", "#1257@186,543:29x13", "#1258@596,354:13x10", "#1259@824,705:28x16", "#1260@468,614:25x20", "#1261@542,10:28x18", "#1262@231,942:18x29", "#1263@979,39:12x13", "#1264@345,77:16x25", "#1265@715,127:14x28", "#1266@618,560:16x16", "#1267@687,397:22x25", "#1268@880,229:16x18", "#1269@806,358:29x16", "#1270@106,846:23x29", "#1271@61,299:16x14", "#1272@644,818:19x22", "#1273@557,157:29x24", "#1274@29,710:25x28", "#1275@207,585:21x27", "#1276@83,715:26x14", "#1277@325,51:13x10", "#1278@717,97:16x12", "#1279@602,139:26x11", "#1280@26,933:29x12", "#1281@815,755:13x22", "#1282@786,950:23x21", "#1283@403,978:29x19" };
    //public string[] TestID = { "#1@179,662:16x27", "#2@609,961:25x21" };

    public int[,] grid = new int[1000, 1000];



    // Start is called before the first frame update
    void Start()
    {
        //use the .tostring and stuff like  "@"

        System.DateTime start = System.DateTime.Now;

        int overlappingSquares = 0;

        //this might be kinda too big

        for (int i = 0; i < ElfIDs.Length; i++)
        {
            int ID, xLoc, yLoc, xSize, ySize;
            ID = xLoc = yLoc = xSize = ySize = 0;

            char[] characters = ElfIDs[i].ToCharArray();

            for (int k = 0; k < characters.Length; k++)
            {
               /* if (characters[k].ToString() == "#")
                {
                    ID = NumberExcerpt(characters, k + 1);
                    continue;
                }*/

                if (characters[k].ToString() == "@")
                {
                    xLoc = NumberExcerpt(characters, k + 1);
                    continue;
                }

                if (characters[k].ToString() == ",")
                {
                    yLoc = NumberExcerpt(characters, k + 1);
                    continue;
                }

                if (characters[k].ToString() == ":")
                {
                    xSize = NumberExcerpt(characters, k + 1);
                    continue;
                }

                if (characters[k].ToString() == "x")
                {
                    ySize = NumberExcerpt(characters, k + 1);
                    continue;
                }
            }

            for (int X = 0; X < xSize; X++)
            {
                for (int Y = 0; Y < ySize; Y++)
                {
                    grid[xLoc + X, yLoc + Y]++;
                }
            }
        }

        foreach(int overlapInt in grid)
        {
            if (overlapInt > 1)
                overlappingSquares++;
        }


        System.TimeSpan duration = System.DateTime.Now - start;

        Debug.Log(string.Format("Time spent: {0} milliseconds", duration.TotalMilliseconds));

        Debug.Log("There are " + overlappingSquares + " overlapping squares");
    }

    public int NumberExcerpt(char[] charList, int index)
    {
        string numbersAsString = "";
        int asnumbers = 0;
        for (int i = index; i < charList.Length; i++)
        {
            if (char.IsDigit(charList[i]))
            {
                numbersAsString += charList[i].ToString();
            }

            else
            {
                break;
            }
        }

        asnumbers = System.Convert.ToInt32(numbersAsString);
        return asnumbers;
    }
}
