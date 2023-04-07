using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerController controller;
    [SerializeField]
    private float respawnDelay = 2f;
    void Start()
    {
        controller = FindObjectOfType<PlayerController>();
    }
    
    public void PlayerSpawner()
    {
        StartCoroutine("RespawnCoroutine");
    }

    IEnumerator RespawnCoroutine()
    {
        controller.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        controller.transform.position = controller.respawnPoint;
        controller.gameObject.SetActive(true);
    }
}
