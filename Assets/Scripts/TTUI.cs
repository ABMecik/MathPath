using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TTUI : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject GStart;
    public Text gameLevel;

    // Start is called before the first frame update
    void Start()
    {
        GStart.SetActive(true);


        gameLevel.text = SceneManager.GetActiveScene().name;
    }

    private void Reset()
    {
        
    }
}
