using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Push") || other.CompareTag("Player"))
        {
            Debug.Log("Plate Pressed. Door Opens.");
            Door.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Push") || other.CompareTag("Player"))
        {
            Debug.Log("Plate Released. Door Closes.");
            Door.SetActive(false);
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
