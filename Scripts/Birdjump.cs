using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Birdjump : MonoBehaviour
{
    Rigidbody2D bird;
    public static int score = 0;
    public Text scoreText;
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            bird.velocity = new Vector2(0, 5);
        }
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            score++;
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipes" || collision.gameObject.tag == "Bars")
        {

            Destroy(gameObject);
            score = 0;
            SceneManager.LoadScene(1);
        }
    }
}
