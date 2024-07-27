using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideTracker : MonoBehaviour
{
    bool InsideApple;
    bool InsidePear;
    bool InsideOrange;

    public void SetInsideApple(bool TrueorFalse)
    {
        InsideApple = TrueorFalse;
    }

    public bool GetInsideApple()
    {
        return InsideApple;
    }
    public void SetInsidePear(bool TrueorFalse)
    {
        InsidePear = TrueorFalse;
    }

    public bool GetInsidePear()
    {
        return InsidePear;
    }
    public void SetInsideOrange(bool TrueorFalse)
    {
        InsideOrange = TrueorFalse;
    }

    public bool GetInsideOrange()
    {
        return InsideOrange;
    }
}
