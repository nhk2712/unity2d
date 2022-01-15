using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class play : MonoBehaviour
{
    public GameObject obj;
    public GameObject canv;
    bool move = false;

    void Update(){
        if (move==true && obj.transform.position.y>=-2.86){
            obj.transform.position += Vector3.down * 10f * Time.deltaTime;
        }
    }

    public void trans(){
        canv.SetActive(false);
        move = true;
        go();
    }

    void go(){
        //Thread.Sleep(1000);
        SceneManager.LoadScene(1);
    }
}
