using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animship : MonoBehaviour
{
    public GameObject obj;
    int val=1;
    public float spd;

    public AudioSource aud;

    void Start(){
        Time.timeScale=1;
        obj.transform.position += Vector3.up * spd * Time.deltaTime;
    }

    void Update()
    {
        if (obj.transform.position.y>1.12){
            val=0;
        }
        else if (obj.transform.position.y<0.16){
            val=1;
        }

        move();

        setMusic();
    }

    void move(){
        if (val==0){
            obj.transform.position += Vector3.down * spd * Time.deltaTime;
        }
        else if (val==1){
            obj.transform.position += Vector3.up * spd * Time.deltaTime;
        }
    }

    void setMusic(){
        if (settings.getMsc()==0){
            aud.mute = true;
        }
        else if (settings.getMsc()==1){
            aud.mute = false;
        }
    }

}
