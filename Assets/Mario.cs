using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour, IMover
{
    public float speed = 3;

    public float DirectionX => horizontal;
    float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
            horizontal = 1;
        else if(horizontal < 0)
            horizontal = -1;
    }
}
