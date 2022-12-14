using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    private float horizontalMove = 0f;
    bool jumping = false;
    bool interacting = false;
    public UnityEvent meowSound;
    //float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        animator.SetBool("interacting", interacting);

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jumping = true;
            animator.SetTrigger("jumpingTrigger");
        }

        if (Input.GetButtonDown("Interact"))
        {
            interacting = true;
            meowSound.Invoke();
        }
        else if (Input.GetButtonUp("Interact"))
        {
            interacting = false;
        }
    }

    void FixedUpdate()
    {
        // we multiply Time.fixedDeltaTime so the speed stays consistent regardless 
        // of how many times the FixedUpdate function is called.
        controller.Move(horizontalMove * Time.fixedDeltaTime, interacting, jumping);
        jumping = false;
    }

}
