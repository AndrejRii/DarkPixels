using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 50f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    // Used for input
    void Update() {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Time.timeScale == 1)
        {
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (Time.timeScale == 1 && crouch == false) { 
            jump = true;
            Invoke("JumpAnimation", 0.05f);
            } 

    }

        if (Input.GetButtonDown("Crouch") && jump == false)
        {
            crouch = true;

        } else if (Input.GetButtonUp("Crouch")) {

            crouch = false;
        }
    }

    void FixedUpdate() {

        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void JumpAnimation()
    {
        animator.SetBool("IsJumping", true);
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    
}
