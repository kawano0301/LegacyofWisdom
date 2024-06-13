using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragButton : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    RectTransform _rectTransform;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
       _rectTransform.anchoredPosition  = Input.mousePosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.anchoredPosition = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

}
