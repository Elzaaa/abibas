using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("speed",Math.Abs( horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			
			jump = true;
			animator.SetBool("isJumping", true);
			
		}
	
		if (Input.GetButtonDown("Crouch"))
		{
			Debug.Log("Crouch button were pressed");
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
			animator.SetBool("isCrouching", true);
		}

	}
	public void OnLanding()
    {
		animator.SetBool("isJumping", false);
    }
	public void OnCrouching(bool isCrouching)
    {
		animator.SetBool("isCrouching", isCrouching);
    }

	void FixedUpdate ()
	{

		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
