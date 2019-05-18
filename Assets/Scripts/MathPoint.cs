using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MathPoint : MonoBehaviour {

    public List<string> operations = new List<string>{"+","-","x","/"};
    public string operation;
    public int value;
    public int max = 10;
    public GameObject mPoint;
    public TextMesh mathText;



    // Use this for initialization
    void Start () {
        var rndX = new System.Random();
        int xyzVal = (int)(transform.position.z + transform.position.y + transform.position.x)*rndX.Next();
        var rnd = new System.Random(xyzVal);

        int index = rnd.Next(operations.Count);

        if(operation == null || operation == "")
        {
            operation = operations[index];
        }
        

        //string sceneName = SceneManager.GetActiveScene().name;
        //string[] lname = sceneName.Split(' ');
        //int level = int.Parse(lname[1]);
        //max = level * 10;

        if(value == null || value == 0)
        {
            value = rnd.Next(1, max);
        }

        


        Color color = new Color();

        switch (operation)
        {
            case "+":
                color = Color.green;
                break;
            case "x":
                color = Color.green;
                break;
            case "/":
                color = Color.red;
                break;
            case "-":
                color = Color.red;
                break;
            default:
                color = Color.green;
                break;
        }
        color.a = 0.5f;
        mPoint.GetComponent<Renderer>().material.color = color;

        string text = operation + value;
        mathText.text = text;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
