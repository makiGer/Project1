using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject objectToShow;
    public Star star;
    public star2 star2;
    
    public void Update()
    {
        if (star.st)
        {
            if(star2.st2)
            {
                objectToShow.SetActive(true);
                Debug.Log("show");
            }
        }
    }
}
