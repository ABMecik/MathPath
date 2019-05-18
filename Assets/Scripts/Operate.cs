using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operate : MonoBehaviour
{

    public GameObject player;
    public TextMesh Score;
    public GameObject mathPoint;
    public Score score;
    public MathPoint operation;

    private void OnTriggerEnter(Collider other)
    {
        if (this.enabled)
        {
            if (other.tag == "Player")
            {

                Debug.Log(score.score + " " + operation.operation + " " + operation.value);

                switch (operation.operation)
                {
                    case "+":
                        score.score = (int)(score.score + operation.value);
                        break;
                    case "x":
                        score.score = (int)(score.score * operation.value);
                        break;
                    case "/":
                        score.score = (int)(score.score / operation.value);
                        break;
                    case "-":
                        score.score = (int)(score.score - operation.value);
                        break;
                    default:
                        break;
                }

                this.enabled = false;
                Destroy(mathPoint);
            }
        }
        
    }

}
