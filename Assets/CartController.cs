using UnityEngine;
using UnityEngine.UI;
public class CartController : MonoBehaviour
{
    public Transform playerParentTransform;
    public Transform player;
    public Transform originPos;
    public Image image;
    public float lookDuration;
    private float lookTimer;
    private bool isLooking;
    public bool isInCart = false;
    public Transform[] waypoints;
    public float speed = 50;
    private int currentWaypointIndex;
    private Transform cartOriginPos;

    void Start()
    {
        Debug.Log("Starting CartController Script");
        image.fillAmount = 0;

    }

    void Update()
    {
        if (isLooking)
        {
            lookTimer = lookTimer + Mathf.Abs(Time.deltaTime);
            image.fillAmount = lookTimer / lookDuration;
        }

        if (lookTimer >= lookDuration)
        {
            teleportToObj();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCart();
    }

    //void MoveCart()
    //{
    //    if (isInCart)
    //    {
    //        if (waypoints.Length > 0)
    //        {
    //            Debug.Log("Waypoint length > 0");
    //            Transform targetWaypoint = waypoints[0];
    //            float step = speed * Time.deltaTime;

    //            playerParentTransform.transform.position = Vector3.MoveTowards(playerParentTransform.transform.position, targetWaypoint.position, step);

    //            if (Vector3.Distance(playerParentTransform.transform.position, targetWaypoint.position) < 3f)
    //            {
    //                Debug.Log("Distance is > 0.01f");
    //                waypoints[0] = waypoints[waypoints.Length - 1];
    //                System.Array.Resize(ref waypoints, waypoints.Length - 1);
    //            }
    //        }
    //    }

    void MoveCart()
    {
        if (isInCart)
        {
            Transform targetWaypoint = waypoints[currentWaypointIndex];
            float step = speed * Time.deltaTime;

            transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, targetWaypoint.position, step), Quaternion.AngleAxis(step, new Vector3(0, 0, 1)));

            if (Vector3.Distance(transform.position, targetWaypoint.position) < 3f)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
        }
    }

    public void Looking()
    {
        Debug.Log("Looking");
        isLooking = true;
    }

    public void notLooking()
    {
        Debug.Log("Not Looking");
        isLooking = false;
        lookTimer = 0;
        image.fillAmount = 0;
    }

    public void teleportToObj()
    {
        // Perform teleportation logic (e.g., move player inside the cart)
        Debug.Log("Teleporting to cart!");

        // Teleport player to the calculated local position inside the cart
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);

        // Calculate the local position of the player relative to the cart's local coordinates
        /* Vector3 localPlayerPosition = playerParentTransform.InverseTransformPoint(player.position);

         player.localPosition = localPlayerPosition;*/

        // Set the player as a child of the cart
        player.SetParent(playerParentTransform);
        lookTimer = 0;
        isInCart = true;
    }

    void exitVehicle()
    {
        player.SetParent(null);
        player.position = originPos.position;
        playerParentTransform.transform.position = cartOriginPos.position;
        currentWaypointIndex = 0;
        lookTimer = 0;
        isInCart = false;
    }

    public void setIsInCart(bool boolean) {
        isInCart = boolean;
    }
}


    // Version 2:
    //using UnityEngine;
    //using UnityEngine.UI;
    //public class CartController : MonoBehaviour
    //{
    //    public float lookAtCartDuration = 5;
    //    public float lookDownDuration = 5;
    //    public float lookDownThreshold = 0.9f;
    //    public Transform playerParentTransform;

    //    private Transform player;
    //    public bool isInCart;
    //    private Vector3 originalPlayerPosition;
    //    public float speed = 5;
    //    public Image image;
    //    private float lookTimer;

    //    void Start()
    //    {
    //        player = Camera.main.transform;
    //        originalPlayerPosition = player.position;
    //        image.fillAmount = 0;
    //    }

    //    void Update()
    //    {
    //RaycastHit hit;
    //if (Physics.Raycast(player.position, player.forward, out hit))
    //{
    //    if (hit.collider.CompareTag("Cart"))
    //    {
    //        lookTimer += Time.deltaTime;
    //        image.fillAmount += Time.deltaTime;
    //        if (lookTimer >= lookAtCartDuration)
    //        {
    //            isInCart = true;
    //            //Teleport player method
    //            lookTimer = 0f; // resets looktimer to 0
    //        }
    //    }
    //    else
    //    {
    //        lookTimer = 0f; // resets if not looking for longer than 5 seconds
    //    }
    //}
    //Vector3 playerLookDirection = player.forward;
    //float lookDownDot = Vector3.Dot(playerLookDirection, Vector3.down);
    //if (lookDownDot > Mathf.Abs(lookDownThreshold))
    //{
    //    Debug.Log("Player looking down");
    //    ExitCart();
    //}
    //}

    //void teleportToObj()
    //{
    //    // Perform teleportation logic (e.g., move player inside the cart)
    //    Debug.Log("Teleporting to cart!");
    //    isInCart = true;

    //    // Set the player as a child of the cart
    //    player.SetParent(playerParentTransform);

    //    // Calculate the local position of the player relative to the cart's local coordinates
    //    /* Vector3 localPlayerPosition = playerParentTransform.InverseTransformPoint(player.position);

    //     // Teleport player to the calculated local position inside the cart
    //     player.localPosition = localPlayerPosition;*/

    //    player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    //}



//Version 1:
//using UnityEngine;

//public class CartController : MonoBehaviour
//{

//    public float speed = 5f;
//    public float timeToTeleport = 5f;

//    private Transform player;
//    private bool isTeleporting = false;

//    private void Start()
//    {
//        player = GameObject.FindGameObjectWithTag("Player").transform;
//    }

//    private void Update()
//    {
//        if (isTeleporting)
//        {
//            timeToTeleport -= Time.deltaTime;

//            if (timeToTeleport <= 0f)
//            {
//                TeleportPlayer();
//            }
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            isTeleporting = true;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            isTeleporting = false;
//            timeToTeleport = 5f; // Reset timer when player leaves the trigger
//        }
//    }

//    private void TeleportPlayer()
//    {
//        player.position = transform.position;
//        isTeleporting = false;
//        timeToTeleport = 5f; // Reset timer after teleporting
//    }


