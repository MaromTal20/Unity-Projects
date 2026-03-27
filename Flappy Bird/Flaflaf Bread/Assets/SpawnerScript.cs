using JetBrains.Annotations;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 7;
    private float timer = 0;
    private float heightOffset = 11;
    private int pipeCount = 0;
    private int milestone = 2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
        pipeCount++;
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

            SpawnPipe();
            pipeCount++;
            timer = 0;
        }
        if ((pipeCount >= milestone) && (spawnRate != 3))
        {
            milestone += 3;
            spawnRate -= 1;
        }
    }
    void SpawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}
