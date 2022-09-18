using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : Brick
{
    public Sprite emptySprite;
    protected override void OnCrash()
    {
        isCrashable = false;
        // 기존에는 아이콘이 바뀌는 애니메이션 재생중이었음
        //-> 아이콘 바뀌는 애니메이션 중지하고 위로 움직이는 애니메이션 해야함.
        //GetComponentInChildren<Animator>().SetTrigger("Crash");
        StartCoroutine(ChangeEmptySpriteCo());
        // todo:[error]스프라이트를 바꿨는데 적용 안되고 있었음.
    }

    public float spriteChangetime = 1;
    private IEnumerator ChangeEmptySpriteCo()
    {
        yield return new WaitForSeconds(spriteChangetime);
        GetComponentInChildren<Animator>().enabled = false;
        GetComponentInChildren<SpriteRenderer>().sprite = emptySprite;
    }
}
