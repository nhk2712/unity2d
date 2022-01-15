using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class keepship : MonoBehaviour
{
    public Rigidbody2D rg;

    void Update()
    {
        rg.AddForce(Vector2.up * 0.2f);
        Thread.Sleep(100);
        rg.AddForce(Vector2.down * 0.2f);
    }
}
