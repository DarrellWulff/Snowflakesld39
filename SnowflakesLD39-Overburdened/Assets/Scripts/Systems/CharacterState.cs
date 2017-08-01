using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterState : MonoBehaviour
{

    //EnergyBar
    public Image playerEnergyBar;

    //Character's bike energy amount.
    private const float NORMALENERGY = 1;
    public float currentBikeEnergy;

    //Refrence our body condition class
    public BodyCondition body;

    //String to test if the bodycondition enum is working
    public string conCheck;

    public bool hasGameStarted;

    // Use this for initialization
    void Start()
    {
        currentBikeEnergy = 1;
        hasGameStarted = true;
        body = GetComponent<BodyCondition>();

    }

    // Update is called once per frame
    void Update()
    {
        if (hasGameStarted && currentBikeEnergy > 0)
        {
            currentBikeEnergy = currentBikeEnergy - (Time.deltaTime / 145f);
            playerEnergyBar.rectTransform.localScale = new Vector3(1, currentBikeEnergy, 1);
        }

    }

    public void TakeDamage(float damage)
    {
        currentBikeEnergy = currentBikeEnergy - damage / 100;
    }

    public void RestoreEnergy()
    {
        currentBikeEnergy = NORMALENERGY;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Battery")
        {
            RestoreEnergy();
        }
    }
}
