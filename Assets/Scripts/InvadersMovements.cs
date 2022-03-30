using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersMovements : MonoBehaviour
{
    public float enemySpeed =2f;
    public int enemyPoint = 0;
    public Vector3 offset;
    public float time;
    ScoreManager score;

    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void Update()
    {
        if (enemyPoint == 0)
        {
           LeftMovement();
        }
        else if (enemyPoint == 1)
        {
           RightMovement();
        }
    }
    void RightMovement()
    {
        transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
    }
    void LeftMovement()
    {
        transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "RightCollider")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            enemyPoint = 1;
        }
        if (collision.transform.tag == "LeftCollider")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            enemyPoint = 0;
        }

        if (collision.gameObject.tag == "Player")
        {
            score.LifeCalculator(1);
        }
        else if (collision.gameObject.tag == "Bunker")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
