using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightCycle : MonoBehaviour
{
    Vector3 rot = Vector3.zero;
    float day_cycle = 6;

    // Update is called once per frame
    void Update()
    {
        rot.x = day_cycle * Time.deltaTime;
        transform.Rotate(rot, Space.World);

    }
}
