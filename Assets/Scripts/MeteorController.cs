using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorController : MonoBehaviour
{

    public float speed = 8;

    private void Start()
    {
        speed = Random.Range(5, 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }else if (collision.gameObject.tag == "Laser")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;

        if (transform.position.y < -10) 
        {
            Destroy(gameObject);
        }
    }
}
