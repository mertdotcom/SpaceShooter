using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -22.5)
        {
            transform.position = StartPosition;
        }
    }
}
