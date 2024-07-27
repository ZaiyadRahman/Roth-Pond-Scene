using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform playerParentTransform;
    private Transform player;
    public bool isInCart;
    private Vector3 originalPlayerPosition;
    public float lookDownThreshold = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        player = Camera.main.transform;
        originalPlayerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInCart)
        {
            Vector3 playerLookDirection = player.forward;
            float lookDownDot = Vector3.Dot(playerLookDirection, Vector3.down);
            if (lookDownDot > Mathf.Abs(lookDownThreshold))
            {
                Debug.Log("Player looking down");
                exitVehicle();
            }
        }
    }

    public void teleportToObj()
    {
        // Perform teleportation logic (e.g., move player inside the cart)
        Debug.Log("Teleporting to cart!");
        isInCart = true;

        // Teleport player to the calculated local position inside the cart
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);

        // Calculate the local position of the player relative to the cart's local coordinates
        /* Vector3 localPlayerPosition = playerParentTransform.InverseTransformPoint(player.position);

         player.localPosition = localPlayerPosition;*/

        // Set the player as a child of the cart
        player.SetParent(playerParentTransform);
    }

    void exitVehicle()
    {
        player.SetParent(null);
        player.position = originalPlayerPosition;
        isInCart = false;

    }
}
