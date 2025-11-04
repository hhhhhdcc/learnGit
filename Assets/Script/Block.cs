using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int id;
    public SpriteRenderer icon;
    public SpriteRenderer bg;
    public void Init(int id, Sprite sprite)
    {
        this.id = id;
        icon.sprite = sprite;
    }   
    public void OnMouseDown()
    {
        if(GamePlayController.instance.playContaint.Input.blockCurrent == null)
        {
            GamePlayController.instance.playContaint.Input.blockCurrent = this;
            ChangeColor(1);
        }
        else
        {
            if (GamePlayController.instance.playContaint.Input.blockCurrent == this)
            {
                GamePlayController.instance.playContaint.Input.blockCurrent = null;
                ChangeColor(0);
            }
            else
            {
                if (GamePlayController.instance.playContaint.Input.blockCurrent.id == this.id)
                {
                    Destroy(GamePlayController.instance.playContaint.Input.blockCurrent.gameObject);
                    Destroy(this.gameObject);
                    GamePlayController.instance.playContaint.Level.CheckWin();
                }
                else
                {
                    GamePlayController.instance.playContaint.Input.blockCurrent.ChangeColor(0);
                    ChangeColor(0);
                    GamePlayController.instance.playContaint.Input.blockCurrent = null;
                }
            }

        }

    }
    public void ChangeColor(int k)
    {
        if (k == 1)
        {
            bg.color = Color.red;
        }
        else
        {
            bg.color = Color.white;
        }
    }
}
