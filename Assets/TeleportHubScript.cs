using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHubScript : MonoBehaviour
{
    public Transform player;
    public Transform TeleportHub;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teleport()
    {
        player.transform.position = new Vector3(TeleportHub.position.x, TeleportHub.position.y + 1.5f, TeleportHub.position.z);
    }


}
