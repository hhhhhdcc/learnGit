using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayContaint : MonoBehaviour
{
    public Score Score;
    public Level Level;
    public Input Input;
    public void Init()
    {
        Score.Init();
        Level.Init();
        Input.Init();   
    }

}
