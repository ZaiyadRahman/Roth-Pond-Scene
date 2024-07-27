/*using UnityEngine;

public class moveVehicle : MonoBehaviour
{
    public GameObject veh;
    public Transform[] waypoints;
    public float speed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCart();
    }

    void MoveCart()
    {
        if (waypoints.Length > 0)
        {
            Transform targetWaypoint = waypoints[0];
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, step);

            if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
            {
                waypoints[0] = waypoints[waypoints.Length - 1];
                System.Array.Resize(ref waypoints, waypoints.Length - 1);
            }
        }
    }
}*/

using UnityEngine;

public class moveVehicle : MonoBehaviour
{
    public GameObject veh;
    public Transform[] waypoints;
    private int currentWaypointIndex;
    public float speed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCart();
    }

    void MoveCart()
    {
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, step);

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
