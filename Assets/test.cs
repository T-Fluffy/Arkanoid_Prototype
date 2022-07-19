using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int JumpForce;
    [SerializeField]
    private  Rigidbody2D rb2D;
    [SerializeField]
    private int speed;
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = Vector2.right * speed * Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.right * speed * Time.deltaTime;

            rb2D.AddForce(Vector2.up * JumpForce);
        }
            
    }
}
