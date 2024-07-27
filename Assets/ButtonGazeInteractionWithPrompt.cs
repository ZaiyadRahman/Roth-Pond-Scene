using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class ButtonGazeInteractionWithPrompt : MonoBehaviour
{
    bool isLooking;
    public InputActionProperty userInput;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(isLooking && userInput.action.WasPressedThisFrame())
        {
            SendMessage("Teleport");
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
}
