using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class change_app : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RectTransform skins;
    public RectTransform buttons;

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.color = new Color(0.7f, 0.7f, 0.7f, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        image.color = new Color(1,1,1,1);
        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {
            case "shop":
                skins.transform.Translate(-5.5f,0,0);
                buttons.transform.Translate(8,0,0);
                break;
            case "start":
                SceneManager.LoadScene("game_scene");
                break;
            case "back":
                buttons.transform.Translate(-8,0,0);
                skins.transform.Translate(5.5f, 0, 0);
                break;
        }
    }


}
