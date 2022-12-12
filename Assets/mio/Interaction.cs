using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Manager ScriptManager;
    Sprite startSprite;
    public ParticleSystem ps;
    public AudioSource au;
    private void Start()
    {
        startSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }
    private void OnMouseDown()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == startSprite && !ScriptManager.GetComponent<Manager>().GameOver)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = ScriptManager.GetComponent<Manager>().Paint(name);
            Instantiate(ps, transform);
            au.Play();
        }
 
    }

}
