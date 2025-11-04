using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  
public class WinBox : MonoBehaviour
{
    public Button btnNextLevel;
    public void Init()
    {
        btnNextLevel.onClick.AddListener(OnClickNextLevel);
    }
    public void OnClickNextLevel()
    {
        var idLevel = PlayerPrefs.GetInt("currentLevel", 1);
        idLevel++;  
        PlayerPrefs.SetInt("currentLevel", idLevel);
        SceneManager.LoadScene("GamePLay");
    }
}
