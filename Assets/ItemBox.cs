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
        GetComponentInChildren<Animator>().SetTrigger("Crash");
        GetComponentInChildren<SpriteRenderer>().sprite = emptySprite;
    }
}
