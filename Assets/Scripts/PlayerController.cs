using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float Speed = 10f;
    float startSpeed = 0;

    CharacterController characterController;

    public Transform groundCheck;
    public LayerMask groundMask;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        RaycastHit hit; // elementy wykryte przez raycast

        if (Physics.Raycast(groundCheck.position, transform.TransformDirection(Vector3.down), out hit, 1f, groundMask))
        {
            switch (hit.collider.gameObject.tag)
            {
                default:
                    Speed = startSpeed;
                    break;
                case "LowSpeed":
                    Speed = startSpeed / 2;
                    break;
                case "HighSpeed":
                    Speed = startSpeed * 2;
                    break;
            }
        }


        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * Speed * Time.deltaTime);
    }
}