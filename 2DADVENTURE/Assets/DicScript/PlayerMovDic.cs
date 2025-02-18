using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovDic : MonoBehaviour
{
    public GameObject player;
    public float speed = 2.5f;
    public Dictionary<string, int> myInventoryDict = new Dictionary<string, int>();
    public TextMeshProUGUI inventoryDisplay;

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
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

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

        transform.position += move * speed * Time.deltaTime;
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
            inventoryDisplay.text += $"Item: {item.Key}, Quantity: {item.Value}e\n";
        }
    }
}