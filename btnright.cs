using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnright : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject obj;
    bool isTouch = false;
    public GameObject tuto;

    void Update(){
        if (obj.transform.position.x <2.6 && isTouch==true){
            obj.transform.position += Vector3.right * 10f * Time.deltaTime;
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData){
        tuto.SetActive(false);
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData){
        isTouch = false;
    }
}
