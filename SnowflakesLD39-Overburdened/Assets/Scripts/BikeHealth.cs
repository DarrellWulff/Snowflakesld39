using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeHealth : MonoBehaviour
{

    public int bikeHealth = 4;

    public void damageBike()
    {
        bikeHealth -= 1;
    }
	
}
