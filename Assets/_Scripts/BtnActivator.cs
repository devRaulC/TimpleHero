using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnActivator : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private bool isActive = false;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Note" && isActive)
        {
            gameManager.AddPoints();
            gameManager.RefreshPoints();

        }
        else if (col.gameObject.tag == "Note" && !isActive)
        {
            //StartCoroutine("LowerPitch");
        }
        else if (col.gameObject.tag == "GameOVer") {
            SceneManager.LoadScene(3);
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
