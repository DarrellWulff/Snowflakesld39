using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    //Player Cursor
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public string nextScene;
    public int secondTransition;

    public NPC enterGameText;
    

	// Use this for initialization
	void Start ()
    {

        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

        gameObject.GetComponent<Fading>().Fade(false, 1f);

        StartCoroutine(sceneChanger());

        
        //enterGameText.triggerDialogue();


    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (!gameObject.GetComponent<Fading>().isInTransition)
        {
            //enterGameText.triggerDialogue();
        }
    }

    public void playGame()
    {

        if (!gameObject.GetComponent<Fading>().isInTransition && secondTransition == 2)
        {
            SceneManager.LoadScene(nextScene);
        }

    }

    public void exitGame()
    {

        Application.Quit();

    }

    IEnumerator sceneChanger()
    {

        yield return new WaitForSeconds(0);
        
        secondTransition = 2;



        //yield return new WaitForSeconds(0);

    }
}
