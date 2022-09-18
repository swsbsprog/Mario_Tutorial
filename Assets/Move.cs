using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3;
    public Vector2 direction = Vector2.right;
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var normal = collision.contacts[0].normal;
        if (normal.x < normal.y)
            return;
        direction = normal;
    }
}
