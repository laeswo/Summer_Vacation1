using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour
{
    private condition script;
    private move code;
    public SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    public Sprite spriteq;
    public Sprite spriteq2;
    private timer timer;
    private score score1;
    private height he;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
        code = GameObject.Find("gameManager").GetComponent <move>();
        spriteRenderer = GameObject.Find("player").GetComponent<SpriteRenderer>();
        rb = GameObject.Find("player").GetComponent<Rigidbody2D>();
        timer =GameObject.Find("time").GetComponent<timer>();
        score1 = GameObject.Find("score").GetComponent<score>();
        he = GameObject.Find("height").GetComponent<height>();
    }
    
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rock")
        {
            Destroy(collision.gameObject);
            spriteRenderer.sprite = spriteq;
            code.y += 5f;
            rb.gravityScale = 0.5f;
            GameObject.Find("player").GetComponent<Animator>().enabled = false;
            score1.num = timer.num;
            Invoke("delay", 2f);
            script.isAlive = false;

        }
        else if(collision.gameObject.tag == "item")
        {
            Destroy(collision.gameObject);
            timer.num += 15 + (he.playerPosY * 2);
            
        }
      
    }

    private void delay()
    {
        this.gameObject.SetActive(false);
    }
}
