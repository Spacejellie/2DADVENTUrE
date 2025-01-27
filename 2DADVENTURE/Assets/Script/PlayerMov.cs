using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    public GameOject player;
    public float speed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
command:workbench.trust.manage
    // Update is called once per frame
    void Update()
    {
        if (Input.Getkey(KeyCode.W))
        {
            Debug.Log("W Pressed")
        }

    }
}
