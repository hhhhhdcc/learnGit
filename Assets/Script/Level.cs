using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Level : SerializedMonoBehaviour
{
    public LevelData currentLevel;
    public List<LevelData> levels = new List<LevelData>();
    public List<DataSprite> dataSprites = new List<DataSprite>();
    public int sum;

    public Block blockprefabs;
    public LevelData GetLevel(int id)
    {
        foreach (LevelData level in levels)
        {
            if (level.id == id)
            {
                return level;
            }
        }
        return null;
    }
    public Sprite GetSprite(int id)
    {
        foreach (DataSprite data in dataSprites)
        {
            if (data.id == id)
            {
                return data.sprite; 
            }
        }
        return null;
    }

    public void Init()
    {
        sum =0;
        var idLevel = PlayerPrefs.GetInt("currentLevel", 1);
        currentLevel = GetLevel(idLevel);
        for (int i = 0; i < currentLevel.height; i++)
        {
            for (int j = 0; j < currentLevel.width; j++)
            {
                var block = Instantiate(blockprefabs);
                block.transform.position = new Vector3(i, j, 0);
                block.Init(currentLevel.data[i, j], GetSprite(currentLevel.data[i, j]));
                sum++;
            }
        }
    }
    public void CheckWin()
    {
        if (sum <= 0)
        {
            Debug.Log("Win");
        }
        else
        {
            sum -= 2;
            if (sum <= 0)
            {
                Debug.Log("Win");
                GamePlayController.instance.gameSence.ShowWinBox();
            }
        }
    }
}
public class LevelData
{
    public int id;
    public float time;
    public int[,] data;
    public int height;
    public int width;
    [Button]
    private void OnShow() {
        data = new int[height, width];
    }    
}
public class DataSprite {
    public int id;
    public Sprite sprite;   
}
