using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class drop : MonoBehaviour, IDropHandler
{

    public Cake cake;

    private void Start()
    {
    }
    void checkObjectDropped(string object_name)
    {
        if (object_name == "cherry")
        {
            cake.has_Cherry = true;
        }
        if (object_name == "name")
        {
            cake.has_birthdayname = true;
        }
        if (object_name == "strawberry")
        {
            cake.has_strawberry = true;
        }
        if (object_name == "chocolate")
        {
            cake.has_chocolate = true;
        }
        if (object_name == "cake")
        {
            cake.cakeLayer += 1;
        }
        if (object_name == "cream")
        {
            cake.has_Cream = true;
        }
        
    }

    public void OnDrop(PointerEventData eventData)
    {

        Debug.Log("Dropped "+eventData.pointerDrag.gameObject.GetComponent<Draggable>().obj_name);
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        checkObjectDropped(eventData.pointerDrag.gameObject.GetComponent<Draggable>().obj_name);
        Destroy(eventData.pointerDrag.gameObject);

    }


}
