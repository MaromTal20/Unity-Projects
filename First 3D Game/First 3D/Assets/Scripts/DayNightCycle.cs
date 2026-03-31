using UnityEngine;
using UnityEngine.UIElements;

public class DayNightCycle : MonoBehaviour
{
    public new Light light;
    public float speed;

    // Update is called once per frame
    private void Update()
    {
        light.transform.Rotate(Vector3.right, speed * Time.deltaTime); 
    }
}
