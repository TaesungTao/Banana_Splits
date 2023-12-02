using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

    private Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.attachedRigidbody)
        {
            rigidBody2D.velocity = new Vector2(Manager.Instance.moveFactor * 5, rigidBody2D.velocity.y);
        }


        
    }
}
