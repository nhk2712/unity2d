using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebg : MonoBehaviour
{
    bool play = true;

    void Update(){
        if (play==true){
            transform.position += Vector3.down * 10f * Time.deltaTime;
        }
    }

    public void on(){
        play = true;
    }

    public void off(){
        play = false;
    }
}
