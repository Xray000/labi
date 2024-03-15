using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    RedKey, GreenKey, BlueKey
}

public class Key : PickUp
{
    public KeyColor ColorKey;

    private void Start()
    {
        if (ColorKey == KeyColor.RedKey)
            GetComponentInChildren<MeshRenderer>().material.color = Color.red;
        else if (ColorKey == KeyColor.BlueKey)
            GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
        else
            GetComponentInChildren<MeshRenderer>().material.color = Color.green;
    }

    public override void Picked()
    {
        GameManager.Instance.AddKey(ColorKey);

        base.Picked();
    }
}
