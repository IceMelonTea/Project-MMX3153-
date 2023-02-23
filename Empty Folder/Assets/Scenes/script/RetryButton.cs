using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void LoadGame()
    {
        //masukkan level berapa yang nak direstart sekiranya nak...
        SceneManager.LoadScene("MainMenu");

    }
 
 }
