using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderMove : MonoBehaviour
{
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject slider4;
    public GameObject slider5;
    public GameObject slider6;
    public GameObject player;
    private condition script;
    public Vector3 vector1 = new Vector3(-10.43f, -188.4f);
    public Vector3 vector2 = new Vector3(-0.43f, -188.4f);
    public Vector3 vector3 = new Vector3(9.43f, -188.4f);
    public int num = 1;
    float playerposY;
    float backgroundposY;
    private void moveBackground()
    {
        if (num % 2 == 1)
        {
            slider1.transform.position += new Vector3(0, 55.62f);
            slider2.transform.position += new Vector3(0, 55.62f);
            slider3.transform.position += new Vector3(0, 55.62f);
            num++;
        }
        else
        {
            slider4.transform.position += new Vector3(0, 55.62f);
            slider5.transform.position += new Vector3(0, 55.62f);
            slider6.transform.position += new Vector3(0, 55.62f);
            num++;
        }
    }
    void Start()
    {
        slider1.transform.position = vector1;
        slider2.transform.position = vector2;
        slider3.transform.position = vector3;
        slider4.transform.position = vector1 += new Vector3(0, 27.81f);
        slider5.transform.position = vector2 += new Vector3(0, 27.81f);
        slider6.transform.position = vector3 += new Vector3(0, 27.81f);
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }
    void Update()
    {
        playerposY = player.transform.position.y;
        if (script.isAlive == true)
        {
            if (playerposY+200 - 27.81f * num - 10 >= 0)
            {
                moveBackground();
            }
        }
    }
}