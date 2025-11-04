using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;
    public GameSence gameSence;
    public PlayContaint playContaint;

    private void Awake()
    {
        instance = this;    
    }
    public void Start()
    {
        playContaint.Init();
        gameSence.Init();   
    }
}
    