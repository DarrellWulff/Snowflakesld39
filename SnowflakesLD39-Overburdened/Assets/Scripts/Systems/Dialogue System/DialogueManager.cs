using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{

    public GameObject dialogueBox;
    public Text nameText;
    public Text dialogueText;

    private Queue<string> sentences;


    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
        //dialogueBox.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        dialogueBox.SetActive(true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();


    }

    public void DisplayNextSentence()
    {

        //If no more sentences in dialogue structure then end converstation.
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        //be able to stop any incoming sentences
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    //Make the string into a character array the appends onto the text element
    //This gives the appearance of the letters one after the other.
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        dialogueBox.SetActive(false);
        //TAKE THIS OUT FOR FINAL BUILDS, SAVE Dialogue TREES HERE MAYBE
        Debug.Log("conversation over");
    }

}
