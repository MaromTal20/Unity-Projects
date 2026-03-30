using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] GameObject[] wayPoints;
    int currentWaypointIndex = 0;
    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, wayPoints[currentWaypointIndex].transform.position) < .1f)
        {
            if (currentWaypointIndex < wayPoints.Length -1)
            {
                currentWaypointIndex++;
            }
            else
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
