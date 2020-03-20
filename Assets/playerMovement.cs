using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
 

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        Debug.Log(Input.GetAxisRaw("Horizontal") * runSpeed);
        

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("salto");
            jump = true;
        }
    }


    void FixedUpdate()
    {
        //move character
        //controller.Move(horizontalMove, false, false);
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,jump);

        jump = false;
    }
}
