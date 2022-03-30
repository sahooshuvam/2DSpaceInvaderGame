using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderBulletsMovement : MonoBehaviour
{
    ScoreManager score;
    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 3f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score.LifeCalculator(1);
            Destroy(gameObject);
        }
    }



}
