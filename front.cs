using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class front : MonoBehaviour
{
    
    void Update()
    {
        transform.position += Vector3.left * 200;
    }
}
