using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public GameObject Panel;
    private condition script;
    void Active()
    {
        Time.timeScale = 1;
    }
    void Start()
    {
        script = GameObject.Find("gameManager").GetComponent<condition>();
    }
    public void active()
    {
        Panel.SetActive(false);
        script.isPaused = false;
        Active();
    }
}
