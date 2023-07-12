using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonSceneLoader : MonoBehaviour
{
    // Scene to load when the button is pressed
    public string sceneToLoad;

    // Method to be called when the button is pressed
    public void LoadScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
