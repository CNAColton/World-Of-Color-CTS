﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{

    public void GameOver()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
}