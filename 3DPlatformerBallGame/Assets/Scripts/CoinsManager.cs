using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinsManager : MonoBehaviour
{
    private GameManager gameManager;
    public int scoreValue;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        transform.Rotate(0, 0, 180 * Time.deltaTime);
    }
                                                                        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.AddScore(scoreValue);
            Destroy(this.gameObject);
        }
    }

}
