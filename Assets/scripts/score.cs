using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text Score;
    public int num;
    private condition script;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }

    void Update()
    {
        if(script.isAlive==false)
        {
            Score.text = "Á¡¼ö:" + num.ToString();
        }
    }
}
