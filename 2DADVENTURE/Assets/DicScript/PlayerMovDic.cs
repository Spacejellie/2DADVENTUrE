using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovDic : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.2f;
    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();
    public TextMeshProUGUI inventoryDisplay;
    public bool newScene = false;

    public static PlayerMovDic Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
   
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inventoryDisplay = GameObject.FindGameObjectWithTag("INV").GetComponent<TextMeshProUGUI>();
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
        }

    }

    public void DisplayInventory()
    {
        if (inventoryDisplay == null)
        {
            Debug.LogError("Display UI not assigned");
            return;
        }
    
        inventoryDisplay.text = "Inventory:\n";
        foreach(var item in myInventoryDict)
        {
            inventoryDisplay.text += $"Item: {item.Key}, Quantity: {item.Value}\n";
        }
    }
}