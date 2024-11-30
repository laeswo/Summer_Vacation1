using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timeCount;
    private condition script;
    private height height;
    public int  num = 0;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
        height = GameObject.Find("height").GetComponent<height>();
 
    }
    void Update()
    {
        if (script.isPlaying == true)
        {
            if (script.isAlive == true)
            {
                timeCount.text = "Á¡¼ö:" + num.ToString();
            }
        }
    }
}