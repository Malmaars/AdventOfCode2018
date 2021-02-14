using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Day5Part2 : MonoBehaviour
{
    List<char> characters;
    // Start is called before the first frame update
    void Start()
    {
        //This is the text file with the information
        string path = "Assets/Resources/Day5Polymer.txt";

        //I'm going to read it with a streamreader. This way I don't have to
        //copy paste everything here.
        System.IO.StreamReader reader = new System.IO.StreamReader(path);

        string hugePolymer = reader.ReadToEnd();

        int shortestPolymer = 0;
        //26 cuz that's how many letters are in the alphabet
        for (int j = 0; j < 26; j++)
        {
            characters = new List<char>(hugePolymer.ToCharArray());

            bool finished = false;

            while (finished == false)
            {
                for (int i = 1; i < characters.Count; i++)
                {
                    int hexaDecimal = Convert.ToInt32(characters[i]);

                    if (hexaDecimal == j + 65 || hexaDecimal == j + 97)
                    {
                        characters.RemoveAt(i);
                        break;
                    }

                    if (i == characters.Count - 1)
                    {
                        finished = true;
                    }
                }
            }

            finished = false;

            while (finished == false)
            {
                for (int i = 1; i < characters.Count; i++)
                {
                    int hexaDecimal = Convert.ToInt32(characters[i]);
                    int prevHexaDecimal = Convert.ToInt32(characters[i - 1]);

                    if (hexaDecimal - prevHexaDecimal == 32 || hexaDecimal - prevHexaDecimal == -32)
                    {
                        characters.RemoveAt(i - 1);
                        characters.RemoveAt(i - 1);
                        break;
                    }

                    if (i == characters.Count - 1)
                    {
                        finished = true;
                    }
                }
            }

            int letterHexa = j + 97;
            char letter = (char)letterHexa;

            //Debug.Log(letter + "," + characters.Count);

            if(shortestPolymer == 0 || characters.Count < shortestPolymer)
            {
                shortestPolymer = characters.Count;
            }
        }
        Debug.Log(shortestPolymer);
    }
}
