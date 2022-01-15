using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausegame : MonoBehaviour
{
    AudioSource aud;
    public GameObject obj;

    void Start(){
        aud = GetComponent<AudioSource>();
    }

    public void pause(){
        aud.Pause();
        Time.timeScale = 0;
        obj.SetActive(true);
    }
}
