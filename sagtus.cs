using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class sagtus : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool sag;
    public void OnPointerDown(PointerEventData data)
    {
        sag = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        sag = false;
    }
}
