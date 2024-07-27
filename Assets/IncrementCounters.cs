using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementCounters : MonoBehaviour
{
    int applesCollected;
    int pearsCollected;
    int orangesCollected;
    int appleFed;
    int pearFed;
    int orangeFed;
    public Text counter;
    // Start is called before the first frame update
    void Start()
    {
        applesCollected = 0;
        pearsCollected = 0;
        orangesCollected = 0;
    }


    public void IncrementChecklist(bool apple, bool banan, bool orange) //increments the UI checklist by 1 for whatever fruit was collected
    {
        string[] counterText = counter.text.Split('\n'); //splits the checklist lines for each fruit type
        if (apple)
        {
            applesCollected++; //Since the Collected variable tracks all fruit collected irrespective of what the UI says, it adds before checking if it's over the fruit requirement
            if (applesCollected < 3) //if it's over the requirement of fruit
            { 
                counterText[1] = "Collect Apples: " + applesCollected + "/3"; //overwrites the chosen line
            }
        }

        if (banan)
        {
            pearsCollected++;
            if (pearsCollected < 3) {
                counterText[2] = "Collect Pears: " + pearsCollected + "/3";
            }
        }

        if (orange)
        {
            orangesCollected++;
            if (orangesCollected < 3)
            {
                counterText[3] = "Collect Oranges: " + orangesCollected + "/3";
            }
        }
        string x = string.Join("\n", counterText); //combines the lines back into 1 string
        counter.text = x; //overwrites the UI with new information.
    }

    public void DecrementChecklist(bool apple, bool banan, bool orange) //increments the UI checklist by 1 for whatever fruit was collected
    {
        string[] counterText = counter.text.Split('\n'); //splits the checklist lines for each fruit type
        if (apple && applesCollected > 0) //checks which case this is for and if it's over the requirement of fruit
        {
            applesCollected--;
            appleFed++;
            if (applesCollected <= 3)
            {
                counterText[1] = "Collect Apples: " + applesCollected + "/3"; //overwrites the collected line
            }

            if(appleFed <= 3)
            {
                counterText[4] = "Feed Cardinal: " + appleFed + "/3"; //overwrites the fed bird line
            }
        }

        if (banan && pearsCollected > 0)
        {
            pearsCollected--;
            pearFed++;
            if (pearsCollected <= 3)
            {
                counterText[2] = "Collect Pears: " + pearsCollected + "/3";
            }
            if (pearFed <= 3)
            {
                counterText[5] = "Feed Finch: " + pearFed + "/3"; //overwrites the fed bird line
            }
        }

        if (orange && orangesCollected > 0)
        {
            orangesCollected--;
            orangeFed++;
            if (orangesCollected <= 3)
            {
                counterText[3] = "Collect Oranges: " + orangesCollected + "/3";
            }
            if (orangeFed <= 3)
            {
                counterText[6] = "Feed Robin: " + orangeFed + "/3"; //overwrites the fed bird line
            }
        }
        string x = string.Join("\n", counterText); //combines the lines back into 1 string
        counter.text = x; //overwrites the UI with new information.
    }

    public void SetApplesCollected(int apples)
    {
        applesCollected = apples;
    }

    public int GetApplesCollected()
    {
        return applesCollected;
    }
    public void SetPearsCollected(int pears)
    {
        pearsCollected = pears;
    }

    public int GetPearssCollected()
    {
        return pearsCollected;
    }
    public void SetOrangesCollected(int apples)
    {
        orangesCollected = apples;
    }

    public int GetOrangesCollected()
    {
        return orangesCollected;
    }
}
