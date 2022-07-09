using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public float speed = 500f;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {


        // set random trajectory
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;
        rigidbody.AddForce(force.normalized * speed);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OutOfBounds"))
        {
            PlayerController.isActive = false;
            Destroy(gameObject);
            Debug.Log("out of bounds");
        }
    }


}