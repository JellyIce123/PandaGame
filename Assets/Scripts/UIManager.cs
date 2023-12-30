using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI PointsText;

    int LevelCount = 1;
    int PointCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial level text
        SetLevelText(LevelCount);
        SetPointText(PointCount);
    }

    // Method to set the level text
    void SetLevelText(int level)
    {
        LevelText.text = "Level " + LevelCount.ToString();
    }

    void SetPointText(int level)
    {
        PointsText.text = "Points " + PointCount.ToString() + " ! ";
    }

    public void IncreasePoints()
    {
        PointCount++;
        PointsText.text = "Points " + PointCount.ToString() + " ! ";
    }

    public void SceneSwitcher()
    {
        SceneManager.LoadScene("DeathScene");
    }

    public void WinningSwitcher()
    {
        SceneManager.LoadScene("WinningScene");
    }
}
