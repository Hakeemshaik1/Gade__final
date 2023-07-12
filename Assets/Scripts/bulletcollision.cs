using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletcollision : MonoBehaviour
{
    // Reference to the player's animation component
    public Animator playerAnimator;

    // Scene to load when the player's animation finishes
    public string sceneToLoad;

    // Name of the animation to check for completion
    public string animationName;

    // Method to call when the player's animation finishes
    public void AnimationFinished()
    {
        // Load Scene 3
        SceneManager.LoadScene(sceneToLoad);
    }

    private void Update()
    {
        // Check if the specified animation has finished playing
        if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(animationName) &&
            playerAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            // Call the AnimationFinished() method
            AnimationFinished();
        }
    }
}