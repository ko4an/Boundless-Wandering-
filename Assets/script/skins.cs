using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class skins : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private int NumSkins;
    private Sprite[] sprites;
    private SpriteRenderer change;
    private string path = "player";
    private Image image;

    public GameObject player;

    private void Start()
    {
        image = GetComponent<Image>();
        change = player.GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(path);
        change.sprite = sprites[PlayerPrefs.GetInt("skins")];
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.color = new Color(0, 0, 0, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (gameObject.name != PlayerPrefs.GetString("skins"))
        {
            NumSkins = int.Parse(PlayerPrefs.GetString("skins", gameObject.name));
            PlayerPrefs.SetInt("skins", NumSkins);
            ChangeSkins();
        }
        image.color = new Color(1, 1, 1, 1);
    }

    public void ChangeSkins()
    {

        change.sprite = sprites[NumSkins];
    }

}

