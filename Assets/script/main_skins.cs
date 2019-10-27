using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_skins : MonoBehaviour
{
    private Sprite[] sprites;
    private SpriteRenderer change;
    private string path = "player";

    void Start()
    {
        change = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(path);
        change.sprite = sprites[PlayerPrefs.GetInt("skins")];
    }
}
