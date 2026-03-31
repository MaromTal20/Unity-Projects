using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    Rigidbody rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        gameOver();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("touch body");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "Enemy Head")
        {
            Debug.Log("touch head");
            Destroy(collision.gameObject.transform.parent.gameObject);
            jump();
        }
    }

    void gameOver()
    {
        if (transform.position.y < -4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void jump()
    {
        rd.linearVelocity = new Vector3(rd.linearVelocity.x, 5, rd.linearVelocity.z);
    }
}
