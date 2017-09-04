using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickCombat : MonoBehaviour {

    //Set Mouse Texture
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public string raytest;

    public Vector3 cursorPosition;

    public ParticleSystem bulletShot;
    public GameObject emitPostion;
    public Vector3 mouseWorld;

    public Camera cam;

    public Ray ray;

    public CharacterState thePlayer;

    public bool targetHit;


    // Use this for initialization
    void Start ()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

        cam = Camera.main;

        thePlayer = GetComponent<CharacterState>();

        targetHit = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        cursorPosition = Input.mousePosition;

        mouseWorld = new Vector3(cam.ScreenToWorldPoint(cursorPosition).x, cam.ScreenToWorldPoint(cursorPosition).y, cam.ScreenToWorldPoint(cursorPosition).z + 3);
        bulletShot.transform.position = mouseWorld;

        ray = cam.ScreenPointToRay(cursorPosition);

        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);


        
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        if (hit != null && hit.collider != null)
        {
            if ((hit.collider.tag == "Body" || hit.collider.tag == "Rider" || hit.collider.tag == "Battery") && targetHit == false)
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                targetHit = true;
            }
            
            if (Input.GetButtonDown("Fire2"))
            {

                bulletShot.transform.position = mouseWorld;
                bulletShot.Emit(30);
                thePlayer.TakeDamage(4);
                if (hit.collider.name.Equals("AIPlayer"))
                {
                    hit.collider.gameObject.GetComponent<BikeHealth>().damageBike();
                }
                if (hit.collider.name.Equals("Rider"))
                {
                    hit.collider.gameObject.GetComponent<RiderHealth>().KillBiker();
                }
                if (hit.collider.name.Equals("Battery"))
                {
                    hit.collider.gameObject.GetComponent<BatteryHealth>().DamageBattery();
                }

                //bulletShot.transform.position = gameObject.transform.parent.position;
                //Instantiate(bulletShot, cursorPosition, Quaternion.identity);

            }
            if ((hit.collider.tag != "Body" || hit.collider.tag != "Rider" || hit.collider.tag != "Battery") &&  targetHit == true )
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                targetHit = false;
            }
        } 

       
    }

    
}
