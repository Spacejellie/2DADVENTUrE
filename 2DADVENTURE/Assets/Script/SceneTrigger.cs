using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LevelDun1")
        {
            SceneManager.LoadScene(2);
        }
        
        if (other.tag == "LevelDun2")
        {
            SceneManager.LoadScene(3);
        }

        if (other.tag == "Intro")
        {
            SceneManager.LoadScene(1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per framey
    void Update()
    {
        
    }
}
