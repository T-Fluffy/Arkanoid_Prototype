using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100f;
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
    }
}
