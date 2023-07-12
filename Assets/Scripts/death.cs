using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    // Reference to the player object
    public GameObject player;

    // Scene to load when the player dies
    public string sceneToLoad;

    // Method to call when the player dies
    public void PlayerDied()
    {
        // Disable the player object
        player.SetActive(false);

        // Load Scene 3
        SceneManager.LoadScene(sceneToLoad);
    }
}