using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookDownTeleport : MonoBehaviour
{
    public Transform player;
    private Transform playerCam;
    public Transform originPos;
    private float lookTimer;
    public float lookDuration = 5f;
    public Image loadingImg;
    private CartController cartController;
    public Transform cartOriginPos;
    public Transform cart;
    // Start is called before the first frame update
    void Start()
    {
        loadingImg.fillAmount = 0;
        cartController = GetComponent("CartController") as CartController;
        playerCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.position, playerCam.forward, out hit))
        {
            if (hit.collider.CompareTag("Bottom"))
            {
                lookTimer += Time.deltaTime;
                loadingImg.fillAmount += Time.deltaTime / lookDuration;
                Debug.Log(loadingImg.fillAmount);
                if (lookTimer >= lookDuration)
                {
                    Debug.Log("Exiting.");
                    exitVehicle();
                }
            }
            else
            {
                lookTimer = 0f; // resets if not looking for longer than 5 seconds
            }
        }
    }
    void exitVehicle()
    {
        player.SetParent(null);
        player.position = originPos.position;
        lookTimer = 0;
        cartController.setIsInCart(false);
        loadingImg.fillAmount = 0;
        cart.transform.position = cartOriginPos.transform.position;
    }
}
