using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int level = 1;

    public static Level Instance
    {
        get;
        set;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
    }

}
