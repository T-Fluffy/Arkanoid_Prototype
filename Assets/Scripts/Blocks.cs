using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Blocks : MonoBehaviour
{
    public int hp = 1;
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
