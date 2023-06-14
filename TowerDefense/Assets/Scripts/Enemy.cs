using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 30f;

    private Transform target;
    private int waveintIndex = 0;
    public float rotationSpeedMultiplier = 5f;


    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        Quaternion rotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeedMultiplier);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waveintIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        waveintIndex++;
        target = Waypoints.points[waveintIndex];
    }

}
