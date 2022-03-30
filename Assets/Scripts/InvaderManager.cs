using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderManager : MonoBehaviour
{
    public GameObject[] invaderPrefabs;
    public Vector3 initialPosition;
    public Vector3 nextPosition;
    public int rows = 3;
    public int columns = 4;
    public GameObject enemyBullet;
    float time;

    private void Awake()
    {
        // Form the grid of invaders
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Create an invader and parent it to this transform
                GameObject invader = Instantiate(invaderPrefabs[i],initialPosition,Quaternion.identity);
                invader.name = "Enemy" + i + j;
                invader.transform.parent = gameObject.transform;
                initialPosition = invader.transform.position + nextPosition ;
            }
            initialPosition.x -= 4f;
            initialPosition.y -= 1f;
        }
    }

    private void Update()
    {
        int i = Random.Range(0, 3);
        int j = Random.Range(0, 4);

        GameObject enemy = GameObject.Find("Enemy" + i + j);
        time = time + Time.deltaTime;
        if (time >= 2f && enemy != null)
        {
            Vector3 enemyPosition = enemy.transform.position;
            Instantiate(enemyBullet, enemyPosition + new Vector3(0f, -0.5f, 0f), Quaternion.identity);
            //Debug.Log("Bullet launching from"+enemy.name);
            time = 0f;

        }
    }
} 