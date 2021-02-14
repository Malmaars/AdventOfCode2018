using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Day5Part1 : MonoBehaviour
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

        characters = new List<char>(hugePolymer.ToCharArray());

        bool finished = false;
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

        string solution = StringExcerpt(characters, 0);
        Debug.Log(characters.Count);
    }

    public string StringExcerpt(List<char> charList, int index)
    {
        string lettersToString = "";
        for (int i = index; i < charList.Count; i++)
        {
            lettersToString += charList[i].ToString();
        }

        return lettersToString;
    }
}
