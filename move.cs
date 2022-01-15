using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform trf;
    public Rigidbody2D rg;
    int time = 0;
    public int maxTime;

    public void Update(){
        if (Input.GetKey(KeyCode.UpArrow) && time <= maxTime){
            trf.position += new Vector3(0,Input.GetAxis("Vertical") * 20f * Time.deltaTime,0);
            time++;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)){
            time = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow) && trf.position.x < -5){
            transform.position += Vector3.right * 0.02f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && trf.position.x > -5){
            transform.position += Vector3.left * 0.02f;
        }
    }
    
}
