using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rd;
    public Collider collide;
    private float ground;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ground = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, 5, rd.linearVelocity.z);
        }


        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, rd.linearVelocity.y, 5);
        }
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, rd.linearVelocity.y, -5);
        }
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(-5, rd.linearVelocity.y, rd.linearVelocity.z);
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(5, rd.linearVelocity.y, rd.linearVelocity.z);
        }
    }
}
