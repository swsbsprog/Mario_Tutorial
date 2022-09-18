using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByDirectionX : MonoBehaviour
{
    IMover mover;
    public float speed = 3;

    void Start()
    {
        mover = GetComponent<IMover>();
    }

    void Update()
    {
        //transform.Translate(horizontal * speed 
        //    * Time.deltaTime, 0, 0);
        var pos = transform.position;
        pos.x += mover.DirectionX * speed * Time.deltaTime;
        transform.position = pos;
    }
}
