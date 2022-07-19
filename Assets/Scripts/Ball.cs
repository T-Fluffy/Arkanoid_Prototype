using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    public float speed = 100f;
    private int score;
    public Text scoreUI;
    private EventButtons menu;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    float hitFactor(Vector2 ballPos,Vector2 racketPos,float racketWifth)
    {
        return (ballPos.x - racketPos.x) / racketWifth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Player")
        {
            // Calculate hit factor
            float x = hitFactor(transform.position,
                                collision.transform.position, 
                                collision.collider.bounds.size.x);
            // Calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;
            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        /*
         * A methode that initialize the ball position to the  midile of the screen :
            if (collision.gameObject.name=="blocker")
            {
                transform.position = new Vector3(0, (float)-0.95, 0);
            }
        */
        if (collision.gameObject.tag=="block")
        {
            score++;
            scoreUI.text = score.ToString();
        }
        if (collision.gameObject.tag == "restart")
        {
            SceneManager.LoadScene("main");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("UI");
        }
    }
}
