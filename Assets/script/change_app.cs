using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_app : MonoBehaviour
{
    private Sprite[] sprites;
    private SpriteRenderer change;
    private string path = "player";

    void Start()
    {
        change = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(path);
        Debug.Log(sprites);
        change.sprite = sprites[2];
    }

    void Update()
    {
        
    }
}
