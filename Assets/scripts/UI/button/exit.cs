using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("title scene");
    }
}
