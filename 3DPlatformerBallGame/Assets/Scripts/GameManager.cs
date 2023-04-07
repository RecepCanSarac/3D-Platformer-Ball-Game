using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private PlayerController controller;
    [SerializeField]
    private float respawnDelay = 2f;
    private bool isGameEnding = false;
    [SerializeField]
    private Text scoreTXT;
    private int score;
    void Start()
    {
        controller = FindObjectOfType<PlayerController>();
    }
    
    public void PlayerSpawner()
    {
        if(!isGameEnding)
            StartCoroutine("RespawnCoroutine");
            isGameEnding = true;
    }

    IEnumerator RespawnCoroutine()
    {
        controller.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        controller.transform.position = controller.respawnPoint;
        controller.gameObject.SetActive(true);
        isGameEnding = false;
    }

    public void AddScore(int numberOfScore)
    {
        score += numberOfScore;
        scoreTXT.text = score.ToString();
    }
}
