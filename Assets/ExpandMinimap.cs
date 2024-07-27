using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExpandMinimap : MonoBehaviour
{
    string mapObj = "Minimap Image";
    public GameObject UIElement;
    public InputActionProperty MinimapToggle;
    bool IsMinimized = false;

    private void Start()
    {

    }
    void Update()
    {
        if(MinimapToggle.action.triggered)
        {
            Debug.Log("Main IF loop trigger");
            if (!IsMinimized)
            {
                MinimizeMinimap();
            }

            else
            {
                MaximizeMiniMap();
            }
        }
    }

    void MinimizeMinimap()
    {
        Debug.Log("Button Pressed!");
        UIElement.SetActive(false);
        IsMinimized = true;
    }

    void MaximizeMiniMap()
    {
        Debug.Log("Button disable Pressed!");
        UIElement.SetActive(true);
        IsMinimized = false;
    }
}
