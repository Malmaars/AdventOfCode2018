using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day4Part2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This is the text file with the information
        string path = "Assets/Resources/Day4IDs.txt";

        //I'm going to read it with a streamreader. This way I don't have to
        //copy paste everything here.
        System.IO.StreamReader reader = new System.IO.StreamReader(path);

        //I'm going to add each line in a List<string>, so every ID entry is in a seperate part of the list, easily accessible
        List<string> sortedLines = new List<string>();

        //here I can read every line without the need of putting them in an array.
        //Now I just need to sort them.

        //I read the line with the streamreader
        string line = reader.ReadLine();

        //As long as there is a line, I'll keep going. Once we reach the bottom of the page, the streamreader
        //will return null and the while loop stops
        while (line != null)
        {
            //I can use string.contains to check for certain words.

            //I add the line to the List
            sortedLines.Add(line);

            //I read the next line
            line = reader.ReadLine();
        }

        //This is going to make an array of the months
        //int[] months = new int[sortedLines.Count];

        //This is an array of the days
        //int[] days = new int[sortedLines.Count];

        ID[] allIDS = new ID[sortedLines.Count];

        for (int i = 0; i < allIDS.Length; i++)
        {
            allIDS[i] = new ID();
        }


        //I'm going through the entire List of strings. i.e. every ID
        for (int k = 0; k < sortedLines.Count; k++)
        {
            char[] characters = sortedLines[k].ToCharArray();
            int month = 0;
            int day = 0;
            int hour = 0;
            int minute = 0;
            string afterText = "";
            bool monthOrDay = false;
            bool dayChecked = false;
            for (int i = 0; i < characters.Length; i++)
            {
                //I'm checking the month and day with the - seperation in the string
                if (characters[i].ToString() == "-")
                {
                    //at the first - we take the month
                    if (!monthOrDay)
                    {
                        month = NumberExcerpt(characters, i + 1);
                        monthOrDay = true;
                        continue;
                    }

                    //at the second - we take the day
                    if (monthOrDay)
                    {
                        day = NumberExcerpt(characters, i + 1);
                        dayChecked = true;
                    }
                }

                if (dayChecked && characters[i].ToString() == " ")
                {
                    hour = NumberExcerpt(characters, i + 1);
                    dayChecked = false;
                }

                if (characters[i].ToString() == ":")
                {
                    minute = NumberExcerpt(characters, i + 1);
                }

                if (characters[i].ToString() == "]")
                {
                    afterText = StringExcerpt(characters, i + 1);
                }
            }

            //I could make this a lot easier by making one array that contains all the data of an ID
            allIDS[k].month = month;
            allIDS[k].day = day;
            allIDS[k].hour = hour;
            allIDS[k].minute = minute;
            allIDS[k].afterText = afterText;
        }

        //Sort the months by shifting the index by looking if it's bigger than the next one
        for (int j = 1; j < allIDS.Length; j++)
        {
            int i = j - 1;
            ID keysave = allIDS[j];

            while (i >= 0 && allIDS[i].month > keysave.month)
            {
                allIDS[i + 1] = allIDS[i];
                i -= 1;
            }
            allIDS[i + 1] = keysave;
        }

        //the same but with the days
        for (int j = 1; j < allIDS.Length; j++)
        {
            int i = j - 1;
            ID keysave = allIDS[j];

            while (i >= 0 && allIDS[i].month == keysave.month && allIDS[i].day > keysave.day)
            {
                allIDS[i + 1] = allIDS[i];
                i -= 1;
            }
            allIDS[i + 1] = keysave;
        }

        //then the hours (FUCK YOU 23)
        for (int j = 1; j < allIDS.Length; j++)
        {
            int i = j - 1;
            ID keysave = allIDS[j];

            while (i >= 0 && allIDS[i].month == keysave.month && allIDS[i].day == keysave.day && allIDS[i].hour > keysave.hour)
            {
                allIDS[i + 1] = allIDS[i];
                i -= 1;
            }
            allIDS[i + 1] = keysave;
        }

        //now with the minutes
        for (int j = 1; j < allIDS.Length; j++)
        {
            int i = j - 1;
            ID keysave = allIDS[j];

            while (i >= 0 && allIDS[i].month == keysave.month && allIDS[i].day == keysave.day && allIDS[i].hour == keysave.hour && allIDS[i].minute > keysave.minute)
            {
                allIDS[i + 1] = allIDS[i];
                i -= 1;
            }
            allIDS[i + 1] = keysave;
        }

        List<workerSleeping> workers = new List<workerSleeping>();
        List<int> checkedIDs = new List<int>();

        for(int i = 0; i < allIDS.Length; i++)
        {
            if (allIDS[i].afterText.Contains("#"))
            {
                char[] characters = allIDS[i].afterText.ToCharArray();
                for (int k = 0; k < characters.Length; k++)
                {
                    if (characters[k].ToString() == "#")
                    {
                        int newIdentification = NumberExcerpt(characters, k + 1);

                        if (!checkedIDs.Contains(newIdentification))
                        {
                            workers.Add(new workerSleeping
                            {
                                identification = newIdentification,
                                minutesAndSleepTime = new int[59]

                            });

                            checkedIDs.Add(newIdentification);
                        }
                    }
                }
            }
        }

        foreach (workerSleeping werkertje in workers)
        {
            int workerNumber = 0;
            int SleepMinute = 0;
            int WakeMinute = 0;
            bool isAsleep = false;

            for (int i = 0; i < allIDS.Length; i++)
            {
                if (allIDS[i].afterText.Contains("#"))
                {
                    char[] characters = allIDS[i].afterText.ToCharArray();
                    for (int k = 0; k < characters.Length; k++)
                    {
                        if (characters[k].ToString() == "#")
                        {
                            workerNumber = NumberExcerpt(characters, k + 1);
                        }
                    }
                }

                if (workerNumber == werkertje.identification)
                {
                    if (allIDS[i].afterText.Contains("asleep"))
                    {
                        isAsleep = true;
                        SleepMinute = allIDS[i].minute;
                    }

                    if (allIDS[i].afterText.Contains("wakes") && isAsleep == true)
                    {
                        WakeMinute = allIDS[i].minute;

                        for (int j = SleepMinute; j < WakeMinute; j++)
                        {
                            werkertje.minutesAndSleepTime[j]++;
                        }
                    }
                }
            }

            int longestMinute = 0;
            for (int i = 0; i < werkertje.minutesAndSleepTime.Length; i++)
            {
                if (werkertje.minutesAndSleepTime[i] > longestMinute)
                {
                    longestMinute = werkertje.minutesAndSleepTime[i];
                    werkertje.longestMinute = i;
                }
            }
        }

        int resultNumber = 0;
        int recordTime = 0;
        int workerIDResult = 0;
        foreach (workerSleeping werkertje in workers)
        {
            if(werkertje.minutesAndSleepTime[werkertje.longestMinute] > recordTime)
            {
                resultNumber = werkertje.longestMinute;
                recordTime = werkertje.minutesAndSleepTime[werkertje.longestMinute];
                workerIDResult = werkertje.identification;
            }
        }

        Debug.Log(resultNumber + "," + workerIDResult);
    }

    public int NumberExcerpt(char[] charList, int index)
    {
        string numbersAsString = "";
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

        int asnumbers = System.Convert.ToInt32(numbersAsString);
        return asnumbers;
    }

    public string StringExcerpt(char[] charList, int index)
    {
        string lettersToString = "";
        for (int i = index; i < charList.Length; i++)
        {
            lettersToString += charList[i].ToString();
        }

        return lettersToString;
    }

    public class ID
    {
        public int month;
        public int day;
        public int hour;
        public int minute;
        public string afterText;
    }

    public class workerSleeping
    {
        public int identification;
        public int[] minutesAndSleepTime;
        public int longestMinute;
    }
}
