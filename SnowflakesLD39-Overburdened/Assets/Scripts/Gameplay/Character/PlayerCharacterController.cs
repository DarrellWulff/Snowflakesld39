using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {
    //Script by Darrell Wulff Ludum Dare 39

    //Variables for horizontal movement this is fto use the rigidbody component.
    public float moveSpeed;
    public bool isCharacterMoving;
    //This variable is the rigidbody horizontal move velocity
    public float moveVelocityX;

    //Variables for vertical movement
    public float jumpHeight;

    //Three raycasts for precise ground dectection
    public Transform RightRayOrigin;
    public Transform LeftRayOrigin;
    public Transform MiddleRayOrigin;

    public bool grounded;

    

    //Animate based on input/Movement
    private Animator anim;


    // Use this for initialization
    void Start ()
    {
        //Enhable Movement
        isCharacterMoving = true;

        grounded = true;

        //Access the animator to change variables on what input is being pressed.
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        //Use update for input since there may be a frame where unity doesn't pick up a user input!
        //Have the Player Jump
        if (grounded == true && Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Grounded", grounded);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, jumpHeight);
            //grounded = false;
        }

    }

    private void FixedUpdate()
    {
        //Raycast2D Logic goes here
        //Raycast hits let use get information about the objects that each ont hit.
        //Here I create three raycast hits by creating three raycasts.
        //These are for ground checking so thier distance is short and made them on collide with the ground layers.
        //Bitshifting  for the raycast layerMask using 8th layer which is the ground layer.
        //It would look like this (using 16bits) pre shift layer 0000 0000 0000 0000 0001 to shift to 8th position 0000 0000 1000 0000  
        RaycastHit2D hitRight = Physics2D.Raycast(RightRayOrigin.position, Vector2.down * 1, .07f , 1 << 8);
        RaycastHit2D hitLeft = Physics2D.Raycast(LeftRayOrigin.position, Vector2.down * 1, .07f, 1 << 8);
        RaycastHit2D hitMid = Physics2D.Raycast(MiddleRayOrigin.position, Vector2.down * 1, .07f, 1 << 8);

        //TURN OFF FOR BUILD DEBUG ONLY
        //Unity these so they appear "slower" than the real raycasts.
        Debug.DrawRay(RightRayOrigin.position, Vector2.down * .07f, Color.red);
        Debug.DrawRay(LeftRayOrigin.position, Vector2.down * .07f, Color.green);
        Debug.DrawRay(MiddleRayOrigin.position, Vector2.down * .07f, Color.cyan);

        //The only time the colliders won't be not null is when they are touching the gorund layer
        if (hitRight.collider != null || hitMid.collider != null || hitLeft.collider != null)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        anim.SetBool("Grounded", grounded);
        anim.SetBool("Running", isCharacterMoving);

        //Horizontal Player movement, Calculate Move Velocity, Allow the Rigidbody component to use the timed velocity.
        //if movement is enhabled then character will continue moving
        if (isCharacterMoving)
        {

            anim.SetBool("Running", isCharacterMoving);
            moveVelocityX = moveSpeed * Time.deltaTime;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, GetComponent<Rigidbody2D>().velocity.y);

        }

        

    }
}
