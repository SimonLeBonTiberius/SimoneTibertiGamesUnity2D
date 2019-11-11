using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool crouch = false;

    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(Input.GetButtonDown("Crouch").ToString() + "Getbottondown crouch:");
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            Debug.Log(Input.GetButtonDown("Crouch").ToString() + "Getbottondown:");
            Debug.Log(crouch +"crouch");
           crouch = true;
        }else if (Input.GetButtonUp("Crouch")) {
            Debug.Log(Input.GetButtonUp("Crouch").ToString() + "Getbottonup:");
            crouch = false;
        }
    }
    public void OnLanding()
    {
        animator.SetBool("isJumping",false);
    }
    public void onCrouch(bool isCrouch)
    {
        animator.SetBool("isCrouch", isCrouch);
    }
     private void FixedUpdate()
    {
        //Move our player
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
