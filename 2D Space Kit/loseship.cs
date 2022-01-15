using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseship : MonoBehaviour
{
    public GameObject obj;
    public GameObject ctrl;
    public GameObject tuto;
    public GameObject pause;

    AudioSource lose_aud;

    public AudioSource aud;

    void Start(){
        Time.timeScale = 1;
        lose_aud = GetComponent<AudioSource>();
    }

    void Update(){
        if (settings.getSfx()==0){
            lose_aud.mute = true;
        }
        else if (settings.getSfx()==1){
            lose_aud.mute = false;
        }
    }

    public void restart(){
        SceneManager.LoadScene(1);
    }

    public void quit(){
        SceneManager.LoadScene(0);
    }

    void GameOver(){
        pause.SetActive(false);
        aud.Stop();
        lose_aud.Play();
        tuto.SetActive(false);
        ctrl.SetActive(false);
        obj.SetActive(true);
        Time.timeScale = 0;
    }

    void OnCollisionEnter2D(Collision2D cls){
        GameOver();
    }
}
