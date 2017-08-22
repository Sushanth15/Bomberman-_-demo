using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{

    void butt()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Application.LoadLevel(0);
        }
    }
    void exitgame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
// Use this for initialization
void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        butt();
        exitgame();

    }

}
