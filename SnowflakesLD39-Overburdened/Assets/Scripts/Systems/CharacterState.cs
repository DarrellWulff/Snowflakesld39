using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterState : MonoBehaviour {

    //Character's blood amount.
    private int normalHealth;
    public int characterHealth;

    //Refrence our body condition class
    public BodyCondition body;

    //String to test if the bodycondition enum is working
    public string conCheck;

	// Use this for initialization
	void Start ()
    {
        characterHealth = 100;

        body = GetComponent<BodyCondition>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        conCheck = body.bodyCurrentCondition.ToString();
	}
}
