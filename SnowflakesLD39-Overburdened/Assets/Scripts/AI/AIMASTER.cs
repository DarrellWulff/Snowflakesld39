using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMASTER : MonoBehaviour {

    public AI thisAI;
    public GameObject batteryPower;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (thisAI.bike.bikeHealth <= 0)
        {
            batteryPower.transform.position = thisAI.transform.position;
            thisAI.gameObject.SetActive(false);
            batteryPower.SetActive(true);
        }
	}
}
