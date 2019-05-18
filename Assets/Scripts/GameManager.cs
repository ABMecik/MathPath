using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isGameOver = false;
    public float restartDelay = 1f;
    public GameObject uiStart;

    public Level level;


    public PlayerMovement movement;
    public Boolean started = false;

    public void GameOver()
    {
        if (!isGameOver)
        {
            uiStart.SetActive(true);
            started = false;
            isGameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    public void LevelUP()
    {
        movement.enabled = false;
        uiStart.SetActive(true);
        started = false;
        Invoke("NextLevel", restartDelay);

    }

    private void NextLevel()
    {
        string nextLN = "Level " + (level.level-1);
        SceneManager.LoadScene(nextLN);
    }


    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        movement.enabled = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!started)
            {
                uiStart.SetActive(false);
                started = true;
                movement.enabled = true;
            }
        }
    }
}
