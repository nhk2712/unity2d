using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator anima;
    const int idle = 0;
    const int run = 1;
    const int jump = 2;

    public SpriteRenderer spr;
    public Transform trf;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            spr.flipX = false;
            anima.SetInteger("state",run);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            spr.flipX = true;
            anima.SetInteger("state",run);
        }
        else if (Input.GetKey(KeyCode.UpArrow)){
            anima.SetInteger("state",jump);
        }
        else{
            anima.SetInteger("state",idle);
        }
    }
}
