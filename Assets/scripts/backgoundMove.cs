using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgoundMove : MonoBehaviour
{
    public GameObject backgound1;
    public GameObject backgound2;
    public GameObject player;
    private condition script;
    Vector3 vector1=new Vector3(0f, 28f);
    Vector3 vector2 = new Vector3(0f, 28f + 58.87621f);
    int num=1;
    float playerposY;
    float backgroundposY;
    private void moveBackground()
    {
        if(num%2==1)
        {
            backgound1.transform.position += new Vector3(0, 117.75242f);
            num++;
        }
        else
        {
            backgound2.transform.position += new Vector3(0, 117.75242f);
            num++;
        }
    }
    void Start()
    {
        backgound1.transform.position=vector1;
        backgound2.transform.position =vector2;
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }
    void Update()
    {
        playerposY = player.transform.position.y;
        if (script.isAlive == true)
        {
            if (playerposY - 58.87621f * num - 10>= 0)
            {
                moveBackground();
            }
        }
    }
}
