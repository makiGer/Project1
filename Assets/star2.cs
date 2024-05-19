using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star2 : MonoBehaviour
{
    public bool st2 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            st2 = true;
            Debug.Log("hit star2");
        }
    }
}
