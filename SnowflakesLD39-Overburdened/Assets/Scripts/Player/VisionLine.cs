using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionLine : MonoBehaviour {

    public LineRenderer line;

    public Camera cam;

    //public TrailRenderer trail;

    public Transform line2;
    //public Transform line3;

    public Vector3 cursorPosition;
    public Vector3 mouseWorld;
	// Use this for initialization
	void Start ()
    {
        cam = Camera.main;
        line = GetComponent<LineRenderer>();
        
        
        //cursorPosition = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update ()
    {
        cursorPosition = Input.mousePosition;
        mouseWorld = cam.ScreenToWorldPoint(cursorPosition);
        line.SetPosition(0, gameObject.transform.position);
        line.SetPosition(1, line2.position);
        
        line.SetPosition(2, mouseWorld);

    }
}
