using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    public float speed = 150;
    private void FixedUpdate()
    {
        // Get Horizontal Input:
        float h = Input.GetAxisRaw("Horizontal");
        // Set Velocity (movement direction*Speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
