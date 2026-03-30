using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rd;
    float ground;
    [SerializeField] Transform grounded;
    [SerializeField] LayerMask Ground;
    [SerializeField] float movingSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        ground = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded())
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, 5, rd.linearVelocity.z);
        }


        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, rd.linearVelocity.y, movingSpeed);
        }
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(rd.linearVelocity.x, rd.linearVelocity.y, -movingSpeed);
        }
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(-movingSpeed, rd.linearVelocity.y, rd.linearVelocity.z);
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            rd.linearVelocity = new Vector3(movingSpeed, rd.linearVelocity.y, rd.linearVelocity.z);
        }

        gameOver();
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(grounded.position, 0.1f, Ground);
    }

    void gameOver()
    {
        if (transform.position.y < -4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
