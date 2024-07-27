using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PickupFruit : MonoBehaviour
{
    public bool IsApple;
    public bool banan;
    public bool orange;
    public GameObject box;
    IncrementCounters IncrementScript;
    bool isLooking;
    public InputActionProperty userInput;
    // Start is called before the first frame update
    void Start(){
        IncrementScript = GameObject.Find("Checklist").GetComponent<IncrementCounters>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking && userInput.action.WasPressedThisFrame())
        {
            if(IsApple) {
                Teleport(0, (float).1, 0);
                IncrementScript.IncrementChecklist(true, false, false);
            }

            if (banan)
            {
                Teleport(0, (float).1, (float).25);
                IncrementScript.IncrementChecklist(false, true, false);
            }

            if (orange)
            {
                Teleport(0, (float).1, (float)-.25);
                IncrementScript.IncrementChecklist(false, false, true);
            }
        }
    }

    public void isLookingTrue()
    {
        isLooking = true;
    }

    public void isLookingFalse()
    {
        isLooking = false;
    }

        void Teleport(float x, float y, float z)
    {
        transform.position = new Vector3(box.transform.position.x + x, box.transform.position.y + y, box.transform.position.z + z); //add an offset based  on paramaters x, y, and z. Pray that the code understands the difference between the parameter and var.
        transform.SetParent(box.transform);
    }
}
