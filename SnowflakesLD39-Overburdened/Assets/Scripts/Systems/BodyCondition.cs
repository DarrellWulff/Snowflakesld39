using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCondition : MonoBehaviour {
    //This is going to be a train wreck
    //AS LONG AS IT WORKS
    //Code by Darrell Wulff Ludum Dare 39

    //Enumerator for runner body condition
    /*public enum Condition
    {

        FrontBroken,
        RiderBroken,
        BodyBroken,
        RearBroken,
        BatteryStolen,
        Dead
      

    }*/

    //Used Bools instead of enums just to get done faster!
    public bool frontBroken;
    public bool RiderBroken;
    public bool BodyBroken;
    public bool RearBroken;
    public bool BatteryStolen;
    public bool Dead;


    

    // Use this for initialization
    void Start ()
    {

        //At start of game body condition is healthy
        


		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    
}


