using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmove : MonoBehaviour
{
    public GameObject obj;
    
    void Update()
    {
        if ( Input.GetKey(KeyCode.RightArrow) && obj.transform.position.x <2.6 ){
            obj.transform.position += Vector3.right * 10f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && obj.transform.position.x >-2.4){
            obj.transform.position += Vector3.left * 10f * Time.deltaTime;
        }
    }
/*
    public void left(){
        if (obj.transform.position.x >-2.4){
            obj.transform.position += Vector3.left * 10f * Time.deltaTime;
        }
    }

    public void right(){ 
        if (obj.transform.position.x <2.6){
            obj.transform.position += Vector3.right * 10f * Time.deltaTime;
        }
    }
*/
}
