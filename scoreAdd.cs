using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreAdd : MonoBehaviour
{
    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D cls){
        if (settings.getSfx()==1){
            aud.Play();
        }
        
        FindObjectOfType<score>().addScore();
    }
}
