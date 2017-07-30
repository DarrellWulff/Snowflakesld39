using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {

    //Variables for horizontal movement this is fto use the rigidbody component.
    public float moveSpeed;
    //This variable is the rigidbody horizontal move velocity
    public float moveVelocityX;

    //Variables for vertical movement
    public float jumpHeight;



    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        //Horizontal Player movement, Calculate Move Velocity, Allow the Rigidbody component to use the timed velocity.
        moveVelocityX = moveSpeed * Time.deltaTime;
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, GetComponent<Rigidbody2D>().velocity.y);
    }
}
