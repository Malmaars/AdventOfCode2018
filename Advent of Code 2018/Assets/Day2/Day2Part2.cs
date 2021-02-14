using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Part2 : MonoBehaviour
{
    public string[] boxIDs = {"xrysntkqrduheficajodiglvzw", "xzymntkqrbuhefmcajodiflvzw", "xpysetkyrbuhefmcajodiglvgw", "xtysnykqrbuhefmczjodiglvzw", "xpysntkqyvuhefmjajodiglvzw", "xpysntkqrbuqjfmcajodiglvzu", "xpysntkqrbuhefmvaoodimlvzw", "xplsntkqrbuhefmcajohimlvzw", "cpysntkqrbuhefmcajodiglpmw", "xpysndkqrbuhefmcajzdiglmzw", "xpysntkqrbuhsfmctjoqiglvzw", "xpysztkkrbuhewmcajodiglvzw", "xpysntkguzuhefmcajodiglvzw", "xpysnbkvrbuhyfmcajodiglvzw", "xpgsntkqrbphefmcajodzglvzw", "xpysntkqrbdhefmcajodvgqvzw", "xpmsntkqrbuhedmcajodiglvnw", "wpysntkqmbuheemcajodiglvzw", "xpysntdvrbuhdfmcajodiglvzw", "xpbsetkqrbuhefmcayodiglvzw", "xpasntkqrbuhefmcajydigovzw", "xpylntkqrbuhefmcajudiglnzw", "xpysqtkqrbuoefmcrjodiglvzw", "xlysntkqrbuhefmuejodiglvzw", "xpysntkqrzuhewmcajodaglvzw", "xpysotkqrbuhefmxajowiglvzw", "xpysntkqrbuhefmcajodinlyza", "xpysntkqrbuhemmmajofiglvzw", "xpysntkqcbuhezmcyjodiglvzw", "xpysntyqrbuhefmcajodiglvfn", "xpysntkqrbudefmcarodcglvzw", "xpysntkqrjuhefkcajodiglvzg", "xpysntkqrbuhefmcahooiglvow", "xpysntkqrqfhevmcajodiglvzw", "xpysntlqrbuhefmcajodivlvzu", "xpyjotkqrbuhefmcavodiglvzw", "xpysntqqrbuhebmcgjodiglvzw", "xpjsnikqbbuhefmcajodiglvzw", "xpysntkqrbuhefmcalodeflvzw", "xpysntktrbuhefmcaqoviglvzw", "xpysntkqrbuhefmcrjogiglvzk", "xpysntkqrjuhekmcajodixlvzw", "xpypntyqrbuhefmcajodigzvzw", "cpysnwkqrbuhefmcajodiglvww", "xpysntkqqbuqefmcajodiglvlw", "xpysntkqrbuhvfmcajldiglvzh", "xpysntkqrbuhefmzmjodislvzw", "xpysnnkqrbuhefmcajodjplyzw", "xpysntdqobuhefmcajbdiglvzw", "xpyzntknrbuhefmcajodigtvzw", "xpysntkqbbohefmcajodialvzw", "xpysntkqryuhefmcayoxiglvzw", "xxysntkqrbuhefmcajodiglgzl", "jzysntkqrbuhmfmcajodiglvzw", "xpysntocrbuhefmcakodiglvzw", "xpysntkqrbuheomrgjodiglvzw", "xpysntkerbuhefmxajoduglvzw", "xpysntkqobuhefpcajodiglvzd", "xpysntkqrbvhefmcajopislvzw", "xpysntkqrbuhefucqjodiglvqw", "xpysvtkqrbuhdfmcajokiglvzw", "xqysnjkqrbuhemmcajodiglvzw", "xpysnteqxbuhefmcajodiglvdw", "xpysntkqrbuhefzcajodignvzc", "xpysntkqrbuledmcajoyiglvzw", "xpysntkqrbuhofmcajkdigpvzw", "xpysmtkqrbuhefmcajodaglvze", "xlysntiqrbuhefmqajodiglvzw", "xpysntvqrbugefmcajodiglizw", "xpysntkqrbuhefmuwjndiglvzw", "ypysntkqrbuhefmbajodislvzw", "xpycntkqrbuhemmcaqodiglvzw", "xpysntkqrbuhefmcajobivdvzw", "xpysnfkprbuhefmcajodiglvkw", "xtysntkwrjuhefmcajodiglvzw", "xpysntkqrbqhefmcaxodiulvzw", "xpysntkqrbuhefmcajsdigkvkw", "xpysnekqrbugefmcajwdiglvzw", "xpysntkqjbuhefmcajoduglbzw", "xpysntkqrbohlfmcajodiggvzw", "xpysntkqrbfhefmcajodiglhnw", "xpmsntkirbusefmcajodiglvzw", "xpnsntkqrbehefmcajodigrvzw", "xpytntgqrbuhefmcajodigllzw", "xpysntkqrbuhefmcejodiglvvm", "xpyvntkqrbuhefmmajodiglmzw", "rpysntkirbuhefmcajodiglyzw", "xpysntkqrbuhefmcajoznglvzz", "xpysntkqrbmhefmcafodigwvzw", "xpysntkqrbuhetmcarodiglvzx", "xpysntnqrbuhefmcajogiglfzw", "xpysutkqjbuheomcajodiglvzw", "xpysnqkprbuhefkcajodiglvzw", "xpysntuqrbuhemmcajodyglvzw", "spysntkqrbupefmcajodigpvzw", "qpygntkqrbuhefmcajodqglvzw", "xpysnteqrbuhefmcatodiylvzw", "xpysntkqrbusefsckjodiglvzw", "xpysntkqrbubeflcajodiglvcw", "xpysntwqrbuhefmcajodigekzw", "xpysntkqrbuhefmcnjodiguvtw", "xpysntkqrbqhefmkasodiglvzw", "xmysntkqrbuhefmkcjodiglvzw", "xpysntkqrquhefmcajodiouvzw", "xpysnnkqrbuhefmcajodiplyzw", "xpysntkorbuhefaqajodiglvzw", "npysntkqobuhefmcajodiglvfw", "xlysntkqrbuhefmcazbdiglvzw", "xpysftkqrbihefmcajodiglezw", "xpysolqqrbuhefmcajodiglvzw", "xpysntkqrwuheixcajodiglvzw", "xoysntkqibuhefmcqjodiglvzw", "xpysntkqrbupefmcajodtulvzw", "xpyentkqrbuhvfmcajudiglvzw", "xpysntksrbuhefmgajodqglvzw", "xpysntkqrbuhcfmcvjodigldzw", "gpyrntdqrbuhefmcajodiglvzw", "vpysntvqrbuhefmcajndiglvzw", "xpvsntkqrbuhefvcajhdiglvzw", "xpysntkqrbubefmcajowiglvzl", "xpysndkqibuhefmcajodiblvzw", "xpysntkqrbuhefmldjodjglvzw", "xpysntzqrbuhefmcyjomiglvzw", "xpysntkqrbuhefmedjodiwlvzw", "xpysntklrbuhefmcyjodiglvjw", "xpypnlkqrbehefmcajodiglvzw", "xpysntkqrbuhefycacodiglvzz", "ypysntkqrbuhefmcajadiglvew", "xpysntkqobuhefmcajadiglhzw", "xpysbtxlrbuhefmcajodiglvzw", "xpysntkqrbuhefdcajoviglvww", "xpysntkqrbuhefmcaaodiblvzc", "wpysntkqrbuhefmcajddiglvbw", "wpysntmqrbuhefmcajodiglvza", "epysntkqrbuhemmcajoniglvzw", "vpysntkqrbuhejmcajodiglvzo", "xpysntkqrbuhebmmajodiglazw", "lpysntkqrguhtfmcajodiglvzw", "xpksndkqpbuhefmcajodiglvzw", "xpydnukqrbuhefmcajmdiglvzw", "xpysnmkqrbuhefioajodiglvzw", "xpysntkqruuhefmcajodyglvzx", "xpysntkqrmuhefmcmjidiglvzw", "xpysntksrbupefmcajodiplvzw", "xpykntkqrbuhefmmajodiglxzw", "xpssntkqrbuhefmzajodiglvgw", "xpysntkqrbuhefmcrjodigovzd", "xpysntkqrbuhefmpajodirlvqw", "xpysnskqrruhefmtajodiglvzw", "xpysnzkqrbuhezmcajodiglvzj", "xpysntkcrburefmckjodiglvzw", "xpysntkqrbuhefecpoodiglvzw", "xpysnjkqrbuhexmcajodigrvzw", "xpysztkqhbuhefmcanodiglvzw", "xpysntkqrbuhefmcajozyelvzw", "xpyuntkmrbuhefmcajodigcvzw", "xpysnykmrbuhefmaajodiglvzw", "jpysntkqrbuhefmcajodigumzw", "xtysntkqhbuhefmcajodiglvzz", "xpysntkqrbqhefmcxjouiglvzw", "xpysntkqreujefmmajodiglvzw", "xnysntzqrbuhefacajodiglvzw", "xpysntkqriuhefmcajkdiqlvzw", "xposntkqrbuheffcajodihlvzw", "xpysntkqpquhefmcajodrglvzw", "xpysjtkqrbudefmcajouiglvzw", "xpysnxkqrbulefmcacodiglvzw", "xpygntkqrbuhefmfajzdiglvzw", "xpysntkqrbuhefmuayodiglyzw", "xpysnbksrbuhefmcajediglvzw", "xkyzntkqrbuhefmcajodiglvzz", "xpysntkqrbehlxmcajodiglvzw", "xpysntkqryuhefmcaxodiklvzw", "xpysntdqrbuhefmcjjodiglvzt", "xpysntkqrbuhefmcauodigqvzy", "xpysftkqrbuhefmcajodrgvvzw", "xpysntkqrbuhefmczjodiglivw", "xpysatkorbuhefmcyjodiglvzw", "xhysntkqrbthefmcajodxglvzw", "xpysnpkqrbuhefmcajoqyglvzw", "xpyyntkqrbuhefmcjjodxglvzw", "xpysntkqrozhefhcajodiglvzw", "xpymftkqrbuhefmcajodiglvzo", "xpysntkqrbuhvfmcajodiyllzw", "xpysatsqrbuhefmcajodiglvzo", "cpysntkqqbuhefmcajodlglvzw", "xpysntkyrblhefmcajodiglvzz", "xpysntkfrbuhefbcajodiglbzw", "upysotkqrbuhpfmcajodiglvzw", "xpysdokqrbuheflcajodiglvzw", "xrysntkqrbuhefpcanodiglvzw", "xdysntkqrbuhefpcajodiglmzw", "xpyynteqrbjhefmcajodiglvzw", "xpysntkqrbuhefkcajodielvhw", "xplsktkqrbuhefmcajodtglvzw", "xpysrtkqrbuhefmcdjodiglvzx", "upysntkmrbuhefmcajodiglvzt", "xnysnpkqrbusefmcajodiglvzw", "xtysntnqrbuhexmcajodiglvzw", "xpysngkmrbfhefmcajodiglvzw", "xpysnhkhrbuhefmcajodiplvzw", "xpysntvqrbuhefmcaoodsglvzw", "xpyzntkqrbuhefmcajlviglvzw", "xpysndkqrbuievmcajodiglvzw", "xpysntkqrsuhcfzcajodiglvzw", "xpysntkqlbuhefmcajjdlglvzw", "xpysntkqrbuhifmcajoliylvzw", "xpysntkqxbphefmcajodialvzw", "bnyswtkqrbuhefmcajodiglvzw", "upysatkqrbuhefmcajodvglvzw", "xpysntkqqbuhefmcajodxglzzw", "xpysntkqryuhefmcafodinlvzw", "xpzsntkqrcuhefmcajokiglvzw", "xpynntkqrbuheimccjodiglvzw", "xpysnfkqduuhefmcajodiglvzw", "xpywntkqrbuhefmcajodigllzz", "xpysftkqrbahefmcajsdiglvzw", "xpysntkkrbutefmcljodiglvzw", "xfysntkqrbbhkfmcajodiglvzw", "xpysgtksrbuhefkcajodiglvzw", "xpysntyqrbuhefmcajodijlvzg", "xpysnpkqobuhefmcljodiglvzw", "xvysntkqrbuhefmcsjodiclvzw", "xpysntkqrtuhwfmcajodillvzw", "xpysntkprbuhejmcajouiglvzw", "apysntkqrbuhefmcaboviglvzw", "xpysqykqrbuhefmcajodirlvzw", "xpysntkqrluhefmcajowiglvzf", "dpysnokqrbuhefmcajoaiglvzw", "xppsntkqmbuheumcajodiglvzw", "xpysntkqrbuhlymcaoodiglvzw", "dpysntkqrbuhmfmcajodiglvzt", "xpysltbqrbuhefmcajoliglvzw", "xpysntpqrbuhefmcnjoniglvzw", "xpysntpqrbuhektcajodiglvzw", "xpysntkhrbshefmqajodiglvzw", "zpysntuqrbuhefmcajmdiglvzw", "xpysxtdqrbuhefmcajoyiglvzw", "xpysntkubbumefmcajodiglvzw", "xpysntkqzouhefmcajsdiglvzw", "xpysntkqrbuhefmcojoziglvyw", "jpysntkqrmuhefmcajodidlvzw", "xpmsttkqrhuhefmcajodiglvzw", "xpysntkqlbuhefmcajgdiflvzw", "xpysntxkrbuhefmcauodiglvzw", "xpysotkqubuhefscajodiglvzw", "xjysntkqrbvheemcajodiglvzw", "xpykntkqrbuhefmcpjodiglvow", "xplsntkqrbuvefmcajediglvzw", "upysntwqrbuhefmfajodiglvzw"
            };


    // Start is called before the first frame update
    void Start()
    {
        System.DateTime start = System.DateTime.Now;
        Debug.Log(checkCloseID());
        System.TimeSpan duration = System.DateTime.Now - start;

        Debug.Log(string.Format("Time spent: {0} milliseconds", duration.TotalMilliseconds));
    }

    private string checkCloseID()
    {

        for (int i = 0; i < boxIDs.Length; i++)
        {
            char[] firstCharacters = boxIDs[i].ToCharArray();
            for (int k = 0; k < boxIDs.Length; k++)
            {
                if (i != k)
                {
                    char[] secondCharacters = boxIDs[k].ToCharArray();

                    int differences = 0;
                    int wrongLetterLocation = 0;
                    for (int m = 0; m < firstCharacters.Length; m++)
                    {
                        if (firstCharacters[m] != secondCharacters[m])
                        {
                            wrongLetterLocation = m;
                            differences++;
                        }
                    }

                    if (differences == 1)
                    {
                        string answer = "";
                        for(int o = 0; o < firstCharacters.Length; o++)
                        {
                            if (o != wrongLetterLocation)
                                answer += firstCharacters[o];
                        }

                        return (answer);
                    }
                }
            }
        }

        return null;
    }
}
