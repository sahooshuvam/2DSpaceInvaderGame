using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
