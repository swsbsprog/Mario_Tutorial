using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour, IMover
{
    public float DirectionX => horizontal;
    float horizontal;
    public Rigidbody2D rb; // gravity:2.5
    public Vector2 jumpForce = new(0, 15);
    public Animator animator;

    public bool isJump = false;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
            horizontal = 1;
        else if(horizontal < 0)
            horizontal = -1;

        animator.SetBool("Move", horizontal != 0);
        if (isJump)
        {
            // 땅에 착지 했는지 확인
            if (IsGround()) //땅에착지 했다
            {
                isJump = false;
                animator.SetBool("Jump", false);
            }
        }
        else // 점프가 아닐때만 점프가 가능하도록
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 점프.
                rb.AddForce(jumpForce, ForceMode2D.Impulse);
                isJump = true;
                animator.SetBool("Jump", true);
            }
        }
    }

    public float groundCheckDistance = 0.52f;
    public LayerMask groundLayer;
    private bool IsGround()
    {
        // 밑으로 떨어지고 있있을때 혹은 위로 상승하는게 아닐때
        if (rb.velocity.y > 0)
            return false;

        // 땅으로 빛을 쏘자. 빛의 거리가 가까우면 땅이다.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down
            , groundCheckDistance, groundLayer);
        return hit.transform != null;

        //if (hit.transform != null)
        //{
        //    print("땅이다");
        //    return true;
        //}
        //return false;
    }
}
