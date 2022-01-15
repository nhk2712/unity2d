using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanim : MonoBehaviour
{
    public GameObject obj;
    int val=1;
    public float spd;

    void Start(){
        obj.transform.position += Vector3.up * spd * Time.deltaTime;
    }

    void Update()
    {
        if (obj.transform.position.y>-2.7){
            val=0;
        }
        else if (obj.transform.position.y<-3.02){
            val=1;
        }

        move();
    }

    void move(){
        if (val==0){
            obj.transform.position += Vector3.down * spd * Time.deltaTime;
        }
        else if (val==1){
            obj.transform.position += Vector3.up * spd * Time.deltaTime;
        }
    }
}
