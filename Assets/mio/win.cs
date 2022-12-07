using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    [SerializeField] Sprite circleWin;
    [SerializeField] Sprite xWin;

    public void Win(string Winner)
    {
        Sprite winner;

        if (Winner == "Circle")
        {
            winner = circleWin;
        }
        else
        {
            winner = xWin;
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = winner;
    }

}
