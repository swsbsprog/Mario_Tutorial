using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Animator animator;
    public GameObject itemGo;

    protected bool isCrashable = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isCrashable == false)
            return;
        if(collision.collider.CompareTag("Player"))
        {
            foreach (var c in collision.contacts)
            {
                if (c.collider.transform.name != "Mario")
                    continue;
                if (c.normal.y == 1)
                {
                    print("마리오가 밑에서 부딪힘");
                    // 들썩이는 애니메이션 재생.
                    animator.SetTrigger("Crash");

                    // 동전 혹은 아이템 생성.
                    if (itemGo != null)
                    {
                        var newItem = Instantiate(itemGo);
                        newItem.transform.position = transform.position + new Vector3(0, 1, 0);
                    }

                    OnCrash();
                }
            }
        }
    }

    protected virtual void OnCrash(){}
}
