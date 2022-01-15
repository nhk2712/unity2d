using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class control : MonoBehaviour
{
    public GameObject obj;
    public AudioSource aud;

    public void quit(){
        SceneManager.LoadScene(0);
    }

    public void replay(){
        SceneManager.LoadScene(1);
    }

    public void play(){
        obj.SetActive(false);
        //Thread.Sleep(3000);
        Time.timeScale = 1;
        aud.Play();
    }
}
