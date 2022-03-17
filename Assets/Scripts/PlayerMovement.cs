using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * inputX * Time.deltaTime);

        if (transform.position.x > 2.15f)
        {
            transform.position = new Vector3(2.15f, transform.position.y, 0);

        }
        else if (transform.position.x < -2.15f)
        {
            transform.position = new Vector3(-2.15f, transform.position.y, 0);
        }

    }

    
}
