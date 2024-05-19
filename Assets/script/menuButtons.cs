using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
    public void firstScene(){
        SceneManager.LoadSceneAsync(0);
    }
    public void menu(){
        SceneManager.LoadSceneAsync(1);
    }
    public void easy()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void normal()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void hard()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
