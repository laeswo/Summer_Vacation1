using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class start : MonoBehaviour
{
    private condition script;
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }
    void active()
    {
        script.isPlaying= true;
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            active();
        }
    }
}
