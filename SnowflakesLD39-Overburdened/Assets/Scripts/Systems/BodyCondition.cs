using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCondition : MonoBehaviour {
    //This is going to be a train wreck
    //AS LONG AS IT WORKS
    //Code by Darrell Wulff Ludum Dare 39

    //Enumerator for runner body condition
    public enum Condition
    {

        Healthy,
        Stabbed,
        RightArmLost,
        LeftArmLost,
        BothArmsLost,
        RightLegLost,
        LeftLegLost,
        BothLegsLost,
        RightLegRightArmLost,
        RightLegLeftArmLost,
        LeftLegLeftArmLost,
        LeftLegRightArmLost,
        RightLegLeftLegRightArmLost,
        RightLegLeftLegLeftArmLost,
        AllLost,
        Dead

    }

    public Condition bodyCurrentCondition;

    // Use this for initialization
    void Start ()
    {

        //At start of game body condition is healthy
        bodyCurrentCondition = Condition.Healthy;


		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void changeBodyCondition(Condition newCondition)
    {
        switch (newCondition)
        {
            case Condition.Stabbed:
                break;
            case Condition.RightArmLost:
                break;
            case Condition.LeftArmLost:
                break;
            case Condition.BothArmsLost:
                break;
            case Condition.RightLegLost:
                break;
            case Condition.LeftLegLost:
                break;
            case Condition.BothLegsLost:
                break;
            case Condition.RightLegRightArmLost:
                break;
            case Condition.RightLegLeftArmLost:
                break;
            case Condition.LeftLegLeftArmLost:
                break;
            case Condition.LeftLegRightArmLost:
                break;
            case Condition.RightLegLeftLegRightArmLost:
                break;
            case Condition.RightLegLeftLegLeftArmLost:
                break;
            case Condition.AllLost:
                break;
            case Condition.Dead:
                break;
        }
    }
}


