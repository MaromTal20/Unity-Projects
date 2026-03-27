using UnityEngine;
using static UnityEngine.Audio.ProcessorInstance;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    private float spawnRate = 13;
    private float timer = 0;
    private float heightOffset = 14;
    private bool cloudHigh = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCloud();
        Destroy(Cloud, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {

            SpawnCloud();
            Destroy(Cloud, 10f);
            timer = 0;
        }
    }

    void SpawnCloud()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        if (cloudHigh == true)
        {
            Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, 0), transform.position.z), transform.rotation);
            cloudHigh = false;
        }
        else    
        {
            Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(0, highestPoint), transform.position.z), transform.rotation);
            cloudHigh = true;
        }
        
    }
}
