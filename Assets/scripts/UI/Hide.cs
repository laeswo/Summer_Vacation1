using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    private condition script;
    public GameObject hight;
    public GameObject time;
    public GameObject Panel;
    public GameObject deadPanel;
    public GameObject player_gameover;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
        Panel.SetActive(false);
        deadPanel.SetActive(false);
        player_gameover.SetActive(false);
    }
    void active()
    {
        Time.timeScale = 1;
    }
    void stop()
    {
        Time.timeScale = 0;
    }
    void panel()
    {
        deadPanel.SetActive(true);
    }
    void gameOver()
    {
        player_gameover.SetActive(true);
    }
    void Update()
    {
        if (script.isPlaying == false)
        {
            hight.SetActive(false);
            time.SetActive(false);  
        }
        else if (script.isPlaying == true)
        {
            hight.SetActive(true);
            time.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (script.isPaused == false)
            {
                Panel.SetActive(true);
                script.isPaused = true;
                stop();
            }
            else if (script.isPaused == true)
            {
                Panel.SetActive(false);
                script.isPaused = false;
                active();
            }
        }
        if(script.isAlive== false)
        {
            Invoke("panel", 1f);
            gameOver();
        }
    }
}
