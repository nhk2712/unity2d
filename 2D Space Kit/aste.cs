using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aste : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Vector3.down * 5f * Time.deltaTime;
    }
}
