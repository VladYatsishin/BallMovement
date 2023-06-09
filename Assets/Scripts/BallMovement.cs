using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    void Start()
    {
       rb = GetComponent<Rigidbody> ();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(hor * speed, rb.velocity.y, ver * speed);
        rb.AddForce (movement);
    }
}
