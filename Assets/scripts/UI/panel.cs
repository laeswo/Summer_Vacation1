using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panel : MonoBehaviour
{
    private condition script;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }

    // Update is called once per frame
    void stop()
    {
        Time.timeScale = 0;
    }
    void active()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (script.isPaused == false)
            {
                stop();
            }
            else if (script.isPaused == true)
            {
                active();
            }
        }
    }
}
