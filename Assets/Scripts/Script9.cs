using UnityEngine;

public class Script9  : MonoBehaviour
{
    public Transform[] waypoints;
    private int i = 0;

    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    public float accuracy = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] waypointsObjects = GameObject.FindGameObjectsWithTag("waypoint");
        if(waypointsObjects.Length == 0)
        {
            Debug.LogError("No se encontraron waypoints");
            return;
        }

        waypoints = new Transform[waypointsObjects.Length];
        for(int i = 0; i < waypointsObjects.Length; i++)
        {
            waypoints[i] = waypointsObjects[i].transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waypoints.Length == 0){
            Debug.Log("No se encontraron waypoints");
            return;
        }

        Transform waypointIndex = waypoints[i];

        Vector3 direction = waypointIndex.position - transform.position;
        float distance = direction.magnitude;

        if(direction != Vector3.zero){
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        transform.position = Vector3.MoveTowards(transform.position, waypointIndex.position, speed * Time.deltaTime);

        if(distance <= accuracy)
        {
            int index = i;
            i = (i + 1) % waypoints.Length;
            Debug.Log("Estoy en el waypoint: " + (index));
            Debug.Log("Llegué al waypoint: " + (index));

        }
        
    }
}
