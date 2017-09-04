using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryHealth : MonoBehaviour {

    private Animator anim;
    public bool curHightlighted;

    public int batteryHealth = 2;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamageBattery()
    {
        batteryHealth -= 1;
    }
}
