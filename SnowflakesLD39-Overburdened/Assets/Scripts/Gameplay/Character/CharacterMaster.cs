using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterMaster : MonoBehaviour {

    public CharacterState thePlayer;

    public Image GameOver;
    public Image YouWon;

    public float gameTime;
    public Text gameTimeText;
    public Text timeUpdate;

	// Use this for initialization
	void Start ()
    {

        Time.timeScale = 1;
        

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //gameTime = Time.time;
        //gameTimeText.text = "Time To Survive: ";
        //timeUpdate.text = "" + gameTime;

        if (thePlayer.currentBikeEnergy <= 0)
        {
            thePlayer.gameObject.SetActive(false);
            GameOver.enabled = true;
            Time.timeScale = 0;
        }

        if (thePlayer.transform.position.x >= 88)
        {
            YouWon.enabled = true;
            Time.timeScale = 0;
        }
	}

    public void yes()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    public void no()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
