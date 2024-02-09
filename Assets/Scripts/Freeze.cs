using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : PickUp
{
    public int FreezeTime = 20;

    public override void Picked()
    {
        GameManager.Instance.FreezeTime(FreezeTime);

        base.Picked();
    }
}
