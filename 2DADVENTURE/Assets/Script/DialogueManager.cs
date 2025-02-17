using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
    /// DialogueManager is a Mono behavior. It's a script that can be 
    /// attached to a game object in Unity.
{
    //VARIABLES

    public TextMeshProUGUI dialogueDisplay;
    public string[] dialogue = new string[5]; 
    public int currentIndex = 0;
    private bool isPlayerNear = false;


    /// <summary>
    /// dialogue is an array of strings to hold dialogue.
    ///  It's set to 5 elements in brackets
    /// dialogueDisplay references the TextMeshProUGUI component,
    /// Its used to display dialogue ont the UI
    /// </summary>


    // Start is called before the first frame update
    void Start()
    /// sets the initial text of the dialogueDisplay to the 
    /// first element in the array.
    {
        dialogueDisplay.text = dialogue[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.F))
        {
            if (currentIndex < dialogue.Length)
            {
                dialogueDisplay.text = dialogue[currentIndex];
                currentIndex++;
            }

            else
            {
                dialogueDisplay.text = "";
                currentIndex = 0;
            }
        
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;   
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            isPlayerNear = false;
            dialogueDisplay.text = "";
            currentIndex = 0;
        }
    }
}
