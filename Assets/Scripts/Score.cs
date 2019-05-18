using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMesh scoreText;
    public float score = 10;
    public PlayerMovement movement;

    void Update () {
        //scoreText.text = "Score : " + player.position.z.ToString("0");
        scoreText.text = score.ToString();

        if(score < 1)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
