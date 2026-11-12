using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject laserPrefab;
    

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 75;
    }



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject laser = Instantiate(laserPrefab);
            laser.transform.position = transform.position + new Vector3(0, 1, 0);
        }



    }
}
