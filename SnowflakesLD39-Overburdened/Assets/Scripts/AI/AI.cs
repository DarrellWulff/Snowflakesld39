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

    //AI rigidbody based movement;
    public Rigidbody2D aiMovement;

    public float moveSpeed;
    public float moveVelocityX;

    public BodyCondition aiBody;
    public string bodCheck;

    private Animator anim;

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
        bodCheck = aiBody.bodyCurrentCondition.ToString();

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        if (hasGameStarted)
        {
            moveVelocityX = moveSpeed * Time.deltaTime;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocityX, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
