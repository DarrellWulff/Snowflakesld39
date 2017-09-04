using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMASTER : MonoBehaviour {

    public AI thisAI;
    public GameObject batteryPower;

    public bool killed;

	// Use this for initialization
	void Start ()
    {
        killed = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (thisAI.bike.bikeHealth <= 0 && killed == false)
        {
            killed = true;
            Instantiate(batteryPower, thisAI.transform.position, Quaternion.identity);
            batteryPower.SetActive(true);
            //batteryPower.transform.position = new Vector3(thisAI.transform.position.x + 5, batteryPower.transform.position.y, batteryPower.transform.position.z);
            thisAI.gameObject.SetActive(false);
            batteryPower.SetActive(true);
        }
	}
}
