using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float pushForce;
    public float speed;
    private float movement;
    private Vector3 respawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
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


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("barier"))
        {
            transform.position = respawnPoint;
        }
    }
}
