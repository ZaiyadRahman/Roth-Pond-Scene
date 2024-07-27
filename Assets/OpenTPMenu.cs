using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenTPMenu : MonoBehaviour
{
    public InputActionProperty userInput;
    bool isLooking;
    Transform curPlayerPos;
    public GameObject MapCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking == false && userInput.action.WasPressedThisFrame())
        {
            CloseMenu();
        }
        
    }

    public void OpenMenu()
    {
        MapCanvas.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    }

    public void CloseMenu()
    {
        MapCanvas.transform.position = new Vector3(transform.position.x, transform.position.y + 1000f, transform.position.z);
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
