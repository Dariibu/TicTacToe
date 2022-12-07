using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Manager : MonoBehaviour
{
    List<string> Circles = new List<string>();
    List<string> X = new List<string>();
    [SerializeField] List<Sprite> images = new List<Sprite>();
    public bool GameOver = false;
    Sprite return_;

    public UnityEvent <string> OnWin;

    public Sprite Paint(string posicion)
    {
        if (Circles.Count > X.Count)
        {
            X.Add(posicion);
            return_ = images[0];
        }
        else
        {
            Circles.Add(posicion);
            return_ = images[1];
        }
        if (Circles.Count >= 3 || X.Count >= 3)
        {
            Comprobar();
        }

        return return_;
        //Comprobar();
    }

    public void Comprobar()
    {
        Debug.Log("cIRCLES  " + Circles.Count);
        Debug.Log("x  " + X.Count);

        if (Circles.Contains("1") && Circles.Contains("2") && Circles.Contains("3")||
            Circles.Contains("1") && Circles.Contains("4") && Circles.Contains("7")||
            Circles.Contains("1") && Circles.Contains("5") && Circles.Contains("9")||
            Circles.Contains("3") && Circles.Contains("5") && Circles.Contains("7")||
            Circles.Contains("3") && Circles.Contains("6") && Circles.Contains("9")||
            Circles.Contains("7") && Circles.Contains("8") && Circles.Contains("9")||
            Circles.Contains("2") && Circles.Contains("5") && Circles.Contains("8")||
            Circles.Contains("4") && Circles.Contains("5") && Circles.Contains("6"))
        {
            Debug.Log("Circle wins");
            GameOver = true;
            OnWin?.Invoke((string)"Circle");
        }
        else if (X.Contains("1") && X.Contains("2") && X.Contains("3") ||
                X.Contains("1") && X.Contains("4") && X.Contains("7") ||
                X.Contains("1") && X.Contains("5") && X.Contains("9") ||
                X.Contains("3") && X.Contains("5") && X.Contains("7") ||
                X.Contains("3") && X.Contains("6") && X.Contains("9") ||
                X.Contains("7") && X.Contains("8") && X.Contains("9") ||
                X.Contains("2") && X.Contains("5") && X.Contains("8") ||
                X.Contains("4") && X.Contains("5") && X.Contains("6"))
        {
            Debug.Log("X wins");
            GameOver = true;
            OnWin?.Invoke((string)"X");
        }
    }

}
