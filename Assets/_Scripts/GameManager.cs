using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int points;
    private Text pointsText;

    //
    public AudioSource audioSource;
    public const float startPitch = 1;

    void Start()
    {
        pointsText = GameObject.Find("Points").GetComponent<Text>();
        PlayerPrefs.SetInt("points", points);

        //
        audioSource = GameObject.Find("AudioSource").GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }


    public void AddPoints()
    {
        PlayerPrefs.GetInt("points", points += 100);
    }


    public void RefreshPoints()
    {
        pointsText.text = "Points: " + points;
    }

    //
    IEnumerator LowerPitch() {
        audioSource.pitch -= 5f * Time.deltaTime;

        yield return new WaitForSeconds(0.25f);
        audioSource.pitch = 1;
    }

    public void GameOver() {
        SceneManager.LoadScene(2);
    }


}
