using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 3;
    public float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
            horizontal = 1;
        else if(horizontal < 0)
            horizontal = -1;
        transform.Translate(horizontal * speed * Time.deltaTime, 0, 0);
    }
}
