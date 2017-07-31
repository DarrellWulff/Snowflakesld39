using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunsetMovement : MonoBehaviour
{

    public PlayerCharacterController player;

    public Camera theCam;
    public CameraMover mainCamera;

    public float moveSpeed;

    private float x1Offset;


    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerCharacterController>();
        mainCamera = theCam.GetComponent<CameraMover>();

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (mainCamera.isCameraFollowing)
        {
            //transform.Translate(Vector2.right * player.moveVelocityX * Time.deltaTime);
            transform.position = new Vector3(player.transform.position.x - 2.17f, transform.position.y, transform.position.z);

        }

    }
}
