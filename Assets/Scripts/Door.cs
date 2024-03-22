using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    public Transform ClosePosition;
    public Transform OpenPosition;
    public Transform door;

    public bool Open = false;
    public float Speed = 5;

    void Start()
    {
        door.position = ClosePosition.position;
    }

    void Update()
    {
        if (Open && Vector3.Distance(door.position, OpenPosition.position) > 0.001f)
        {
            door.position = Vector3.MoveTowards(door.position, OpenPosition.position, Speed * Time.deltaTime);
        }
    }

    public void OpenDoor()
    {
        Open = true;
    }
}
