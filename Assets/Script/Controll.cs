/******************************************************************************
Author: Chin Wai Lun

Name of Class: Controll

Description of Class: This class will control the main progress on the game.

Date Created: 16/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    public bool phaseOne;

    public bool phaseTwo;

    public bool phaseThree;

    public GameObject pauseMenu;

    void Start()
    {
        PauseGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            PauseGame();
        }


    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void upgradeOne()
    {
        phaseOne = true;
    }
    public void upgradeTwo()
    {
        phaseTwo = true;
    }
    public void upgradeThree()
    {
        phaseThree = true;
    }
}
