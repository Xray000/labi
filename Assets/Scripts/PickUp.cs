using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 250 * Time.deltaTime));
    }

    public virtual void Picked()
    {
        print("Parent: Picked");
        Destroy(gameObject);
    }
}
