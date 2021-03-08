using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;
	public LayerMask whatIsGround;
	private Rigidbody2D rb;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	int playerObject, collideObject;

    private void Start()
    {
		rb = GetComponent<Rigidbody2D>();
		playerObject = LayerMask.NameToLayer("Player");
		collideObject = LayerMask.NameToLayer("Collide");
    }

    // Update is called once per frame
    void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		if(rb.velocity.y>0)
        {
			Physics2D.IgnoreLayerCollision(playerObject, collideObject, true);
        }
		else
        {
			Physics2D.IgnoreLayerCollision(playerObject, collideObject, false); ;
		}
	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
