using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float pushForce;
    public float speed;
    private float movement;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        rb.AddForce(0,0,pushForce * Time.fixedDeltaTime);
        rb.velocity = new Vector3(movement * speed ,rb.velocity.y,rb.velocity.z);
    }
}
