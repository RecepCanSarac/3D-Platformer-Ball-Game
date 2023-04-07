using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerController controller;
    [SerializeField]
    private float respawnDelay = 2f;
    private bool isGameEnding = false;
    [SerializeField]
    private Text scoreTXT;
    private int score;
    [SerializeField]
    private GameObject NextLevelPanel;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameEnding = false;
    }

    public void AddScore(int numberOfScore)
    {
        score += numberOfScore;
        scoreTXT.text = score.ToString();
    }
    public void LevelUp()
    {
        NextLevelPanel.SetActive(true);
        Invoke("NextLevel",2f);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
