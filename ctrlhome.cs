using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrlhome : MonoBehaviour
{
    public GameObject canv;
    public AudioSource aud;
    public GameObject ctr;
    public GameObject plbt;

    public GameObject mn;

    //exit btn
    public void exit(){
        aud.Pause();
        Time.timeScale = 0;
        canv.SetActive(true);
        ctr.SetActive(false);
        plbt.SetActive(false);
    }

    public void play(){
        aud.Play();
        Time.timeScale = 1;
        canv.SetActive(false);
        ctr.SetActive(true);
        plbt.SetActive(true);
    }

    public void quit(){
        Application.Quit();
    }

    //menu btn
    public void menu(){
        Time.timeScale = 0;
        mn.SetActive(true);
        ctr.SetActive(false);
        plbt.SetActive(false);
    }

    public void done(){
        Time.timeScale = 1;
        mn.SetActive(false);
        ctr.SetActive(true);
        plbt.SetActive(true);
    }
}
