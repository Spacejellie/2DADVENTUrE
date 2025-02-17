using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovDic : MonoBehaviour
{
    public GameObject player;
    public float speed = 6f;

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
        inventoryDisplay.text = "";
        foreach(var item in myInventoryDict)
        {
            inventoryDisplay.text += "Item: " + item.Key + ", Quantity: " + item.Value + "\n";
        }
    }
}