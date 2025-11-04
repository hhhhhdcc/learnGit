using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  
public class GameSence : MonoBehaviour
{
    public WinBox winBox;   
    public Button btnRetry;
    public void Init()
    {
        winBox.Init();
        btnRetry.onClick.AddListener(OnclickRetry);
    }
    public void OnclickRetry()
    {
        SceneManager.LoadScene("GamePLay"); 
    }
    public void ShowWinBox()
    {
        winBox.gameObject.SetActive(true);
    }   
}
