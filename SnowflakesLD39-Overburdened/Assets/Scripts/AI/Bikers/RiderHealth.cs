using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderHealth : MonoBehaviour
{

    private Animator anim;
    public bool curHightlighted;

    public int riderHealth = 1;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KillBiker()
    {
        riderHealth -= 1;
    }

}
