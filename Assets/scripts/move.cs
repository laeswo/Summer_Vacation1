using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private condition script;
    private float x = 0f;
    public float y = -200f;
    public GameObject player;
    public GameObject box;
    Rigidbody2D rigid1;
    double timer;
    Rigidbody2D rigid2;
    public Animator ani;
    destroyPlayer destroy;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        ani.SetBool("stop", true);
        rigid1 = player.GetComponent<Rigidbody2D>();
        rigid2 = box.GetComponent<Rigidbody2D>();
        script = GameObject.Find("gameManager").GetComponent<condition>();
        destroy = GameObject.Find("player").GetComponent<destroyPlayer>();
    }
        
    // Update is called once per frame
    void Update()
    {
        
           
        
        if(script.isPlaying==true)
        {
            if (script.isAlive == true)
            {
                destroy.spriteRenderer.sprite = sprite;
                ani.SetBool("stop", false) ;
                timer += Time.deltaTime;
               
                if(timer> 5f)
                {
                  
                    ani.SetBool("start", false);
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    if (x <= -10)
                    {

                    }
                    else
                    {
                        x = x - (float)10;
                    }
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    if (x >= 10)
                    {

                    }
                    else
                    {
                        x = x + (float)10;
                    }
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    ani.SetBool("start", true);
                    y = y + (float)2;
                   
                   

                }
                Vector2 vector1 = new Vector2(x, y);
                Vector2 vector2 = new Vector2(x, y - 20);
                rigid1.MovePosition(vector1);
                rigid2.MovePosition(vector2);
                
            }
        }
    }
}
