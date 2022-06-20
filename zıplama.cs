using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class zıplama : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool zıpla;
    public void OnPointerDown(PointerEventData data)
    {
        zıpla = true;
        Invoke("zıplakapat",0.1f);
    }
    public void OnPointerUp(PointerEventData data)
    {
        zıpla = false;
    }

     public void zıplakapat()
    {
        zıpla = false;
        
    }
}
