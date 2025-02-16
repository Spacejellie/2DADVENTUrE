using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;

public class ItemNameDic : MonoBehaviour

    //----------------Variables-----------------------

{
    public string itemName; //Name of the item
    public int itemNumber = 1; // Quatity of the Item (default is 1
    public int objectIndex; // Index used in the Dialogue Manager
    public PlayerMovDic myPlayer; //Reference to the player script
    public DialogueManager dialogueManager; // Reference to the dialogue system
    public GameObject pickUp; // UI indicator (e,g, "Press F to pick up")

    
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovDic>(); //Find and assign the PlayerMoveDic script
        dialogueManager = FindObjectOfType<DialogueManager>(); // Find and assign the DialogueManager script
        pickUp.SetActive(false); // Hide the pickup indicator at the start

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other) //Detect player in range
    {
 
        pickUp.SetActive(true); // Show pickup prompt
        if (Input.GetKeyDown(KeyCode.E))// If player presses "E"
        {
            Interact(); //Update dialogue manager
            AddItem(); // Add item to the inventory
            pickUp.SetActive(false); //Hide pickup prompt
            Destroy(gameObject); // Remove item from the world
        }
    }

    /// <summary>
    /// The method is triggered while the player stays inside the items collider
    /// It Enables the "Press F to pick up" UI (pickUP)
    /// If the player presses "F", the following happens:
    /// 
    ///     - Calls Interact() -> Updates the dialogue system
    ///     - Calls AddItem() -> Adds item to player's inventory
    ///     - Destroys the item object (removing it from the scene)
    ///     
    /// </summary>

    public void AddItem() //Handles Inventory Management
    {
        if (myPlayer.myInventoryDict.ContainsKey(itemName))
            {
            myPlayer.myInventoryDict[itemName] += itemNumber;
            
        }
        else
        {
            myPlayer.myInventoryDict.Add(itemName, itemNumber);
        }
        myPlayer.DisplayInventory();
    }

    public void Interact() //Updates Dialogue System
    {
        dialogueManager.currentIndex = objectIndex;
    }
}
