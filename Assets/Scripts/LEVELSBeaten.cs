using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LEVELSBeaten : MonoBehaviour
{

    public Text levelText; // Reference to the UI Text component

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EventManager.instance.IncrementLevels();
            UpdateLevelText();
        }
    }

    private void UpdateLevelText()
    {
        // Update the text component with the current levels beaten count
        int levelsbeaten = EventManager.instance.GetLevelsBeaten();
        levelText.text = "Levels Beaten: " + (levelsbeaten).ToString();
    }


}