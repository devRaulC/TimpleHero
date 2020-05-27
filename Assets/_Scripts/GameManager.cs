using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int points;
    private Text pointsText;


    void Start()
    {
        pointsText = GameObject.Find("Points").GetComponent<Text>();
        PlayerPrefs.SetInt("points", points);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }


    public void AddPoints()
    {
        PlayerPrefs.GetInt("points", points+=100);
    }


    public void RefreshPoints()
    {
        pointsText.text = "Points: " + points;
    }
}
