using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour {
    //Attach Script to player head in hierarchy.

    public float mouseInputY;
    public float rotationSpeed;

    public float minHeadRotation;
    public float maxHeadRotation;

    private float currentHeadRotation = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        mouseInputY = Input.GetAxis("Mouse Y");

        currentHeadRotation += mouseInputY * rotationSpeed;

        currentHeadRotation = Mathf.Clamp(currentHeadRotation + mouseInputY * rotationSpeed, minHeadRotation, maxHeadRotation);

        //transform.Rotate(new Vector3(0, 0, 1), currentHeadRotation);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, currentHeadRotation);

    }
}
