using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;
    float maxTime = 0.75f;
    float time;

    public float pos;
    public AudioSource aud;

    void Start(){
        time = maxTime;
    }

    void Update()
    {
        if (time > maxTime)
        {
            GameObject tmp = Instantiate(obj, new Vector3(transform.position.x + Random.Range(-pos, pos), transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(tmp, 5f);

            time = 0;
            setTime();
        }
        time += Time.deltaTime;
        
        setMusic();
    }

    public void setTime(){
        maxTime-=0.01f;
    }

    void setMusic() {
        if (settings.getMsc()==0){
            aud.mute = true;
        }
        else if (settings.getMsc()==1){
            aud.mute = false;
        }
    }
}
