using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.color = new Color(0.7f, 0.7f, 0.7f, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SceneManager.LoadScene("game_scene");
    }
}
