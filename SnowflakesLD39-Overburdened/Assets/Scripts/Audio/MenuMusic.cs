using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour {

    public AudioSource audioMusic;

    //Be able to tell when audio is on or off
    public static bool AudioBegin = false;

    private void Awake()
    {
        //if the audio is off then play the audio
        if (!AudioBegin)
        {

            audioMusic.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
           
         }
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {

            audioMusic.Stop();
            AudioBegin = false;

        }
	}
}
