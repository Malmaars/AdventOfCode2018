﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Part2 : MonoBehaviour
{   
    public int[] frequency = {+1,+6,+6,+2,+1,-17,-16,+10,+9,+7,-13,+10,+14,+13,-8,+12,-18,+11,-8,-19,-6,-15,-6,-1,+13,-21,+14,+13,-3,-14,
        -21,-18,+17,+3,+14,+6,-18,-11,+8,-18,-14,-14,+12,-2,+3,-11,-7,+4,-5,-11,+2,+1,+19,-14,-1,-2,-14,+2,+4,+9,-14,-12,-7,+14,
        +7,-12,-17,-12,+5,+4,-2,-10,+7,+18,+1,+10,+12,+17,-19,-17,-8,-4,-4,-8,-19,+13,-8,+1,+17,+10,+12,+3,+11,+6,+13,-15,-9,+20,
        +3,+10,-19,-27,+12,-11,-27,-14,+15,+14,+4,+18,-20,-14,-16,+18,+5,-17,-1,-20,+12,-16,-19,-14,+8,-10,-14,+12,-8,-5,+3,+19,-12,
        -1,+17,-5,-1,+16,+22,-18,+3,-11,-8,+5,+15,+5,-15,-16,-14,-6,-5,+9,+12,+14,+10,+21,-2,+14,-23,+5,-7,-19,+12,+8,-10,-14,-24,-12,
        -6,+2,-16,+4,-10,-9,+5,-10,-15,-2,-15,+14,-5,+1,-17,+4,+7,-3,+18,+17,-12,+3,+4,-15,-4,-9,-18,-9,-14,+5,-12,+10,-13,-8,-7,-4,-4,
        +19,+20,+14,-18,+10,+14,-15,-19,-3,+6,-12,-9,-13,-8,-5,+12,-5,-14,-16,-13,+6,+19,+14,-5,-16,-14,+17,+17,+6,+14,-18,+11,+15,-19,
        +7,-9,+16,+4,-9,-3,+19,+4,-12,-18,-14,+18,+10,+13,-16,-20,-6,-3,+14,-25,+10,-12,-14,+1,+3,+9,-6,-13,-1,-18,+17,-18,+4,+10,+10,
        +13,+14,-19,-15,-20,-10,+1,-15,+8,-11,-15,+8,+14,+18,+3,+10,-6,-17,-14,-19,-14,-4,-5,+16,+13,+16,-8,-5,+18,-7,-18,-13,-2,+1,+20,
        -16,-1,+16,-3,-10,-10,-8,+20,-6,+9,-19,-8,-4,-10,+5,-19,+17,+12,-7,-18,+21,+10,+6,+28,+13,+18,+15,-12,-10,-14,-11,-11,-4,+8,+26,
        +8,-1,-14,-14,+18,+14,-1,+16,+13,-19,+18,-5,-11,+8,+2,+19,+1,+13,-3,-1,-16,-5,-17,-22,-17,-20,-20,+3,+20,-17,-19,-7,+10,-19,-4,+10,
        -13,-10,-16,+6,-19,+3,-8,+1,+6,+6,-10,+1,-12,-17,-5,+3,-5,+1,+13,-1,+4,-1,-12,+2,-13,-19,+9,+2,+5,+7,+15,+9,-10,-8,+5,-19,-3,+12,+20,
        +24,+13,-14,-18,+2,+9,-15,+3,-7,-16,-49,-21,-18,-1,-13,-8,+9,+1,-5,-19,-8,+23,-4,+9,+18,-28,-16,-19,-9,-16,+20,-22,-13,+9,-8,+7,+10,
        -21,-4,-14,+17,+14,+6,+4,+23,-22,+11,-26,-18,+2,-6,-7,+12,-16,-1,-8,+19,+9,-12,-18,-3,-7,-7,+12,+12,-2,+15,+12,+9,+9,-13,+3,+12,+16,
        -11,-21,-24,-13,-23,+6,-9,+15,-4,-17,+8,+4,-10,-5,-1,-6,+15,+13,+13,+27,-19,-50,-1,+13,-19,-3,-9,+1,-2,-10,+14,-7,-13,-2,+12,+22,+8,
        +1,-3,-23,-32,-36,+6,+13,-24,-26,-3,+5,-20,-6,-17,+13,-47,-32,+6,-19,-17,-1,-6,+12,+19,-22,-16,-14,-39,+116,-38,-8,+36,+14,+42,+90,
        +35,+35,-11,+28,-23,-1,+77,+18,-26,-13,-37,-91,+6,+243,+8,-28,+3,-15,+48,+36,-11,-91,+93,+83134,+14,+10,+4,+7,+15,+6,-19,+4,+11,+19,
        -18,+6,+4,-8,+19,-16,-7,+24,+4,-2,+3,+13,+4,-8,-5,+22,+4,-16,+18,+19,-8,-14,+12,+6,-1,+8,+23,+19,+3,+12,+3,-9,-10,-8,+11,+15,-13,-14
        ,-6,+11,-26,+11,+14,-20,-28,-22,-9,-1,-3,-14,-9,+1,-27,-18,+12,-21,+18,-12,+19,+7,-24,-17,-13,+4,+3,-6,-2,-9,+7,+13,+27,-21,-4,+12,-3,
        +11,-14,+2,+13,+3,+23,+22,-2,-8,+21,+11,-7,-7,+10,+13,+4,-1,+7,-16,+8,-20,-14,+79,-41,-8,+78,+15,+37,+2,+43,+4,+15,-1,+10,+15,+3,-2,
        +20,-13,+11,-5,+19,+10,-13,+29,-13,-19,-18,-5,+18,-17,+15,-14,+18,+16,-15,+24,-2,-2,-6,-24,-26,-11,-9,+10,-2,-10,+5,+9,-18,+19,+4,-15,
        -16,-8,+18,+23,-5,-3,+7,+11,+1,-31,-4,+33,-35,+8,+26,-2,+69,+15,-4,-3,-10,+12,+2,+4,+17,+9,-14,-10,-14,-9,-2,+13,-7,+8,+18,+14,-7,+6,
        +16,+9,+9,+1,+17,-19,-1,+10,-13,-19,-14,+1,-9,+1,-7,+1,+10,+9,+13,-2,+14,-19,+16,-4,-9,+12,+7,+1,+18,+13,+17,+12,+13,-14,-10,+19,+19,
        +19,-2,-11,-3,+19,-17,+19,-4,+15,+13,+18,+15,+19,-9,+5,-27,-2,-18,-18,+5,+21,+6,-4,+23,-8,+10,+13,-2,+22,+6,-15,-10,-8,+43,-15,-13,+7,
        -34,-33,-16,-11,-4,-1,-15,-14,-1,-13,+5,+10,-18,+12,-15,+14,-10,-17,-14,-14,+18,+4,+3,+6,+5,+1,+3,-8,+11,-17,+1,-3,-14,-4,+7,-16,+10,
        +12,-7,-14,+17,+1,+19,-6,+5,+20,-12,+22,-18,-16,-7,-18,+4,-22,+16,-7,-1,-22,-9,+4,-10,+23,+4,-9,+26,-22,-18,-19,+23,-1,+12,-20,+14,-21,
        -16,-12,+2,+16,+11,-41,+35,-7,-3,+9,+34,+26,-5,+18,+31,+9,+17,+4,-6,+4,-8,+2,-4,+18,+2,+1,+16,+7,+10,+12,-1,+31,-47,-22,-4,+11,+19,-8,-19,
        +12,+5,-24,-18,+6,+15,+17,-7,+4,-23,-20,-8,+18,+2,+10,-16,-45,-196,-12,-16,+15,-4,-48,+2,+47,+103,+122,+90,+67,+36,+10,+9,+11,-82543};

    public HashSet<int> reachedFrequencies;
    // Start is called before the first frame update
    void Start()
    {
        //we start with 0
        reachedFrequencies = new HashSet<int>();
        int solution = 0;

        bool twiceFreq = false;
        int loopCount = 0;

        System.DateTime start = System.DateTime.Now;
        while (twiceFreq == false)
        {
            for (int i = 0; i < frequency.Length; i++)
            {
                solution += frequency[i];

                if (reachedFrequencies.Contains(solution))
                {
                    Debug.Log(solution);
                    twiceFreq = true;
                    break;
                }

                reachedFrequencies.Add(solution);
            }
            loopCount++;
        }

        Debug.Log("Number of loops:" + loopCount);

        System.TimeSpan duration = System.DateTime.Now - start;

        Debug.Log(string.Format("Time spent: {0} milliseconds", duration.TotalMilliseconds));

        //Debug.Log(solution);
    }
}
