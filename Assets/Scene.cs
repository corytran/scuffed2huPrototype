﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    private int instance = 0;
    public GameObject canvas;
    public AudioSource audio;

    //check to see if player is alive, if not, call method for displaying buttons for quit and retry on player death
    public void Update()
    {
        if(GameObject.Find("Player") == false && instance == 0)
        {
            DisplayQuitAndRetry();
            instance = 1;
        }
    }

    //display buttons for quit and retry on player death
    public void DisplayQuitAndRetry()
    {
        if(GameObject.Find("Player") == false)
        {
            GameObject newCanvas = Instantiate(canvas) as GameObject;
        }
    }

    //play sound
    public void playSound()
    {
        Instantiate(audio);
    }

    //load first level
    public void StartGame()
    {
        if(audio.isPlaying != true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    //load current scene
    public void RestartGame()
    {
        if(audio.isPlaying != true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //load title scene
    public void Title()
    {
        if(audio.isPlaying != true)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
    
    //quit program
    public void QuitGame()
    {
        if(audio.isPlaying != true)
        {
            Application.Quit();
        }
    }
}
