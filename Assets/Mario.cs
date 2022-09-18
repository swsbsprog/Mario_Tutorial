using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour, IMover
{
    public float speed = 3;
    public float DirectionX => horizontal;
    float horizontal;
    public Rigidbody2D rb; // gravity:2.5
    public Vector2 jumpForce = new(0, 15);
    public Animator animator;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
            horizontal = 1;
        else if(horizontal < 0)
            horizontal = -1;

        animator.SetBool("Move", horizontal != 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 점프.
            rb.AddForce(jumpForce, ForceMode2D.Impulse);
        }
    }
}
