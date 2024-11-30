using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class height : MonoBehaviour
{
    public GameObject player;
    public Text playerHeight;
    private condition script;

    public int playerPosY;
    public int num;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }
    void Update()
    {
        if (script.isPlaying == true)
        {
            if (script.isAlive == true)
            {
                playerPosY = (int)player.transform.position.y;
                playerPosY += 200;
                playerPosY = playerPosY / 2;
                playerHeight.text = playerPosY.ToString() + "m";
            }
        }
    }
}