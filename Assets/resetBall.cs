using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBall : MonoBehaviour
{  
    public GameObject ball;
    public GameObject respawn;
    public GameObject shadow;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            ball.SetActive(false);
            ball.transform.position = respawn.transform.position;
            shadow.SetActive(true);
            shadow.transform.position = respawn.transform.position;
        }
    }
}
