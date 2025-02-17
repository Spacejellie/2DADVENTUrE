using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName; // Set this in the Inspector

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName); // Load the scene set in the Inspector
    }
}
