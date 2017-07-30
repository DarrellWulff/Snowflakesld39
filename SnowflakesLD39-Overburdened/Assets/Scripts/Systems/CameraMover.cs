using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    public PlayerCharacterController player;
    private float playerVelocityX;

    //Made Public for access 
    public bool isCameraFollowing;

    //Public to be able to be set in the inspector
    public float x1Offset;
    public float y1Offset;

    

	// Use this for initialization
	void Start ()
    {
        //Find the player's character when the scene starts;
        player = FindObjectOfType<PlayerCharacterController>();

        //Camera is following at start of level
        isCameraFollowing = true;
        

        //Set the Camera's Position at the start of the Scene
        transform.position = new Vector3(player.transform.position.x + x1Offset, player.transform.position.y + y1Offset, transform.position.z);

    }
	
	// Update is called once per frame
	void Update ()
    {
        //If our camera is set to follow (bool isCameraFolling = true)
        //Then continue updating our camera's offset plus the amount the player is moving!
        if (isCameraFollowing)
        {

            transform.position = new Vector3(player.transform.position.x + x1Offset, player.transform.position.y + y1Offset, transform.position.z);

        }
	}
}
