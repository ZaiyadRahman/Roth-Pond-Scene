using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerInside : MonoBehaviour
{
    public bool AppleBase;
    public bool PearBase;
    public bool OrangeBase;
    insideTracker tracker;
    string birdfeedScript = "BirdFeeding";
    BirdFeeding script;
    // Start is called before the first frame update
    private void Start()
    {
        tracker = GameObject.Find("Inside Tracker").GetComponent<insideTracker>();
    }
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MainCamera")){
            Debug.Log("Main Cam Collision Detected");
            if (AppleBase)
            {
                tracker.SetInsideApple(true);
            }
            
            if (PearBase)
            {
                tracker.SetInsidePear(true);
            }
            
            if (OrangeBase)
            {
                tracker.SetInsideOrange(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("Main Camera Escape Detected.");
            if (AppleBase)
            {
                tracker.SetInsideApple(false);
            }

            if (PearBase)
            {
                tracker.SetInsidePear(false);
            }

            if (OrangeBase)
            {
                tracker.SetInsideOrange(false);
            }
        }
    }
}
