﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public void LoadGame() {
        SceneManager.LoadScene(1);
    }

    public void CloseGame() {
        Application.Quit();
    }
}
