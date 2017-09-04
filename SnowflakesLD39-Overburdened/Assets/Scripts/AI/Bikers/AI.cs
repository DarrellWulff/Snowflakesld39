using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    //Base AI Class logic for the NPC Runners
    //This is going to be a train wreck
    //AS LONG AS IT WORKS
    //Code by Darrell Wulff Ludum Dare 39

    //Check if the game has started will be accessed by other scripts
    public bool hasGameStarted;
    public bool startRunning;
    public bool inCombat;
    public bool isDestroyed;

    //AI rigidbody based movement;
    public Rigidbody2D aiMovement;

    public float moveSpeed;
    public float moveVelocityX;

    public BodyCondition aiBody;
    public string bodCheck;

    private Animator anim;

    public BikeHealth bike;

    //Check if player is in range of enemy bike
    public PlyCheck checkForPlayer;
    public bool inRangeCheck;

    //Enumerator for the AI state machine
    public enum AIBaseState
    {
        Paused,
        Running,
        Attacking,
        Defending,

    }

    

	// Use this for initialization
	void Start ()
    {
        hasGameStarted = true;

        aiMovement = GetComponent<Rigidbody2D>();

        aiBody = GetComponent<BodyCondition>();
        

        anim = GetComponent<Animator>();

        bike = GetComponent<BikeHealth>();

        inRangeCheck = checkForPlayer.playCheck;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        
	}

    private void FixedUpdate()
    {
        inRangeCheck = checkForPlayer.playCheck;

        if (hasGameStarted && bike.bikeHealth >= 0)
        {
            moveVelocityX = moveSpeed * Time.deltaTime;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (inRangeCheck && bike.bikeHealth >= 0)
        {
            hasGameStarted = false;
            moveVelocityX = 72 * Time.deltaTime;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }

    /*private void OnMouseOver()
    {
        Debug.Log(gameObject.name);
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        bike.bikeHealth -= 1;
    }*/
}
