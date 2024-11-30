using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class spawner : MonoBehaviour
{
    double timer;
    double item_timer;
    int num;
    float time;
    float item_time;
    float posY;
    float item_posY;
    float item_num;
    public double spawntime;
    double item_spawntime;
    public GameObject enemy;
    public GameObject item;
    public GameObject cloud;
    private condition script;
    private Vector2 randPosition()
    {
        num = Random.Range(1, 4);
        posY = this.gameObject.transform.position.y + Random.Range(20f, 30f);
        float posX;
        if (num == 1)
        {
            posX = -10f;
        }
        else if (num == 2)
        {
            posX = 0f;
        }
        else
        {
            posX = 10f;
        }
        Vector2 spawnPos = new Vector2(posX, posY);
        return spawnPos;
    }
    private Vector2 item_RandomPosition() {
        item_posY = this.gameObject.transform.position.y + Random.Range(15f, 25f);
        item_num = Random.Range(1, 4);
        float item_posX;
        if (item_num == 1)
        {
            item_posX = -10f;
        }
        else if (item_num == 2)
        {
            item_posX = 0f;
        }
        else
        {
            item_posX = 10f;
        }
        Vector2 item_spawnPos = new Vector2(item_posX, item_posY);
        return item_spawnPos;
    }
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
                if (this.gameObject.transform.position.y >= 0) time = Random.Range(1.5f, 2.5f);
                else time = Random.Range(2.5f, 3.5f);
                spawntime = time;
                timer += Time.deltaTime;
                Vector2 spawnPos = randPosition();
                if (timer > spawntime)
                {
                    Instantiate(enemy, spawnPos, Quaternion.identity);
                    spawntime = 0;
                    timer = 0;
                }
                if (this.gameObject.transform.position.y >= 0) item_time = Random.Range(2f, 3f);
                else item_time = Random.Range(2f, 3.5f);
                item_spawntime = item_time;
                item_timer += Time.deltaTime;
                Vector2 item_spawnPos = item_RandomPosition();
                if (item_timer > item_spawntime)
                {
                    Instantiate(item, item_spawnPos, Quaternion.identity);
                    item_spawntime = 0;
                    item_timer = 0;
                }
            }
        }
    }
}

