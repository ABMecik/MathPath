using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public GameObject player;
    public GameManager gameManager;
    public Level level;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            level.level = level.level + 1;
            gameManager.LevelUP();
        }
    }
}