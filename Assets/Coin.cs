using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float destroyTime = 0.333f;
    void Start()
    {
        print("점수 증가 시키자");
        Destroy(gameObject, destroyTime);
    }
}
