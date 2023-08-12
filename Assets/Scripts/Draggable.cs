using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;




public class Draggable : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public RectTransform rectTransform;
    public Canvas myCanvas;
    public string obj_name;
    private CanvasGroup CanvasGroup;

    void Start()
    {
    rectTransform = GetComponent<RectTransform>();
    CanvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
       // Debug.Log("OnBeginDrag");
        CanvasGroup.blocksRaycasts = false;
        CanvasGroup.interactable = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
       // Debug.Log("OnEndDrag");
        CanvasGroup.blocksRaycasts = true;
        CanvasGroup.interactable = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / myCanvas.scaleFactor;

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }







}