using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Door;
    public bool isPressed=false;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Push"))
        {
            Debug.Log("Plate Pressed. Door Opens.");
            isPressed = true;
            Door.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Push"))
        {
            Debug.Log("Plate Released. Door Closes.");
            isPressed = false;
            Door.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
