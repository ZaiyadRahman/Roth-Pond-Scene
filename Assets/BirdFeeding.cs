using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFeeding : MonoBehaviour
{
    string trackerParent = "Inside Tracker";
    insideTracker tracker;
    private string box = "fruitbox2";
    public bool AppleBird;
    public bool PearBird;
    public bool OrangeBird;
    IncrementCounters incrementCounter;
    GameObject fruitBasket;
    List<Transform> fruits = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        incrementCounter = GameObject.Find("Checklist").GetComponent<IncrementCounters>();
        fruitBasket = GameObject.Find(box);
        tracker = GameObject.Find(trackerParent).GetComponent<insideTracker>();
    }

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        if (AppleBird)
        {
            if (tracker.GetInsideApple())
            {
                if (incrementCounter.GetApplesCollected() > 0)
                {
                    Debug.Log("Apples > 0");
                    incrementCounter.DecrementChecklist(AppleBird, PearBird, OrangeBird);
                    CountFruitsByType("Apples");
                    GameObject.Destroy(fruits[0].gameObject);
                } 
            }
        }

        if (PearBird)
        {
            if (tracker.GetInsidePear())
            {
                if (incrementCounter.GetPearssCollected() > 0)
                {
                    incrementCounter.DecrementChecklist(AppleBird, PearBird, OrangeBird);
                    CountFruitsByType("Pears");
                    GameObject.Destroy(fruits[0].gameObject);
                }
            }
        }

        if (OrangeBird)
        {
            if (tracker.GetInsideOrange())
            {
                if (incrementCounter.GetOrangesCollected() > 0)
                {
                    incrementCounter.DecrementChecklist(AppleBird, PearBird, OrangeBird);
                    CountFruitsByType("Oranges");
                    GameObject.Destroy(fruits[0].gameObject);
                }
            }
        }
    }

    void CountFruitsByType(string criterion)
    {
        if (fruits.Count >= 1)
        {
            fruits.Clear();
        }
        for (int i = 0; i < fruitBasket.transform.childCount; i++)
        {
            if(fruitBasket.transform.GetChild(i).CompareTag(criterion))
            {
                Transform transform = fruitBasket.transform.GetChild(i);
                fruits.Add(fruitBasket.transform.GetChild(i));
            }
        }
    }
}

