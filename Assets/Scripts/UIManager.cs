using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI LevelText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial level text
        SetLevelText(1);
    }

    // Method to set the level text
    void SetLevelText(int level)
    {
        LevelText.text = "Level " + level.ToString();
    }

    // Example of how to call the method when you want to change the level
    void ExampleLevelChange()
    {
        // Change the level to 2 (or any other level)
        int newLevel = 2;
        SetLevelText(newLevel);
    }
}
