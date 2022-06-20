using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class sol : MonoBehaviour , IPointerDownHandler , IPointerUpHandler
{
    public bool Sol;
    public void OnPointerDown(PointerEventData data)
    {
        Sol = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        Sol = false;
    }
}
