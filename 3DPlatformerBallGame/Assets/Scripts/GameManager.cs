using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerController controller;
    void Start()
    {
        controller = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerSpawner()
    {
        controller.transform.position = controller.respawnPoint;
    }
}
