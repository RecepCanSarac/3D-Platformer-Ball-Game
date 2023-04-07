using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float pushForce;
    public float speed;
    private float movement;
    public  Vector3 respawnPoint;
    private GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
        gameManager  = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        rb.AddForce(0,0,pushForce * Time.fixedDeltaTime);
        rb.velocity = new Vector3(movement * speed ,rb.velocity.y,rb.velocity.z);
        FallDetector();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("barier"))
        {
            gameManager.PlayerSpawner();
        }
    }


    private void FallDetector()
    {
        if (rb.position.y < -2f)
        {
            gameManager.PlayerSpawner();
        }
    }
}
