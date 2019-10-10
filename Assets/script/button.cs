using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private Vector2 origin;

    private int pointerID;
    private bool touched;

    private int moving;

    public void Awake()
    {
        touched = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!touched)
        {
            origin = eventData.position;
            touched = true;
            pointerID = eventData.pointerId;
            if (eventData.pointerId == pointerID)
            {
                if (origin.x < Screen.width / 2)
                {
                    moving = -1;
                    GetMoving();
                }
                else
                {
                    moving = 1;
                    GetMoving();
                }
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.pointerId == pointerID)
        {
            touched = false;
            moving = 0;
            origin = Vector2.zero;
        }
    }

    public int GetMoving()
    {
        return moving;
    }
}