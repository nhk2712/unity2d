using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frmove : MonoBehaviour
{
    public GameObject fr;
    public float maxTime;

    float timer=0;

    private void Update(){
        if (timer > maxTime){
            GameObject tmp = Instantiate(fr, transform.position, Quaternion.identity);
            Destroy(tmp,1f);
            
            timer = 0;
        }
        
        timer += Time.deltaTime;
    }
}
