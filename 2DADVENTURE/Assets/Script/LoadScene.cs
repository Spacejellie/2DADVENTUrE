using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneToLoad;
    public PlayerMovDic myPlayer;

    void Start()
    {
        myPlayer = FindObjectOfType<PlayerMovDic>(); //Find and assign the PlayerMoveDic script
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            myPlayer.newScene = true;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
