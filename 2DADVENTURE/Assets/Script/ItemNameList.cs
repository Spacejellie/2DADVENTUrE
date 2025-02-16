using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNameList : MonoBehaviour
{

    public string itemName;
    public int itemIndex;

    public PlayerMov myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMov>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayer.addItem(itemName);
        Destroy(gameObject);
    }
}


