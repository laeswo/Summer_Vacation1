using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour
{
    public bool isAlive;
    public bool isPlaying;
    public bool isPaused;
    void Start()
    {
        isAlive = true;
        isPlaying = false;
        isPaused = false;
    }
}
