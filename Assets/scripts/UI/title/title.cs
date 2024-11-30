using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.UI;

public class title : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public Sprite sp;
    public Sprite sp2;
    Image im;
    public void Start()
    {
       im = GetComponent<Image>();  
    }
    public void onstartClick()
    {
        Debug.Log("sival");
        string title = "main scene";
        SceneManager.LoadScene(title);

       
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
       im.sprite = sp;
    }
   public void OnPointerExit(PointerEventData eventData)
    {
        im.sprite = sp2;
    }
}
