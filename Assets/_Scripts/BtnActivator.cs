using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnActivator : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private bool isActive = false;
    private Points pointScript;

    private void Start()
    {
        pointScript = GameObject.Find("Points").GetComponent<Points>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Note" && isActive) 
        {
            pointScript.AddPoints();
            pointScript.RefreshPoints();
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        isActive = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isActive = false;
    }
}
