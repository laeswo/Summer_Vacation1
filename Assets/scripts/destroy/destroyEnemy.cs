using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rock")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "cloud")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "item")
        {
            Destroy(collision.gameObject);
        }
    }
}
