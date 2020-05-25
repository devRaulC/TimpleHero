using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    private int points = 0;
    private Text pointsText;

    void Start()
    {
        pointsText = GameObject.Find("Points").GetComponent<Text>();
    }

    public void AddPoints() {
        points += 100;
    }

    public void RefreshPoints() {
        pointsText.text = "Points: " + points;
    }
}
