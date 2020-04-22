using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update()
    {
        horizMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
           
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
