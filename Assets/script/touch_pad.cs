using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class touch_pad : MonoBehaviour,IPointerUpHandler,IPointerDownHandler,IDragHandler
{
    private Vector2 origin;
    private Vector2 direction;
    private Vector2 smoothDirection;

    public float smoothing;

    private int pointerID;
    private bool touched;

    public void Awake()
    {
        direction = Vector2.zero;
        touched = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!touched)
        {
            origin = eventData.position;
            Debug.Log(origin);
            touched = true;
            pointerID = eventData.pointerId;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerId == pointerID)
        {
            Vector2 currentPosition = eventData.position;
            Vector2 directionRaw = currentPosition - origin;
            direction = directionRaw.normalized;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.pointerId == pointerID)
        {
            touched = false;
            direction = Vector2.zero;
        }
    }

    public Vector2 GetDirection()
    {
        smoothDirection = Vector2.MoveTowards(smoothDirection, direction, smoothing);
        return smoothDirection;
    }
}
