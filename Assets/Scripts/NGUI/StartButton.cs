using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public MyButton startButton;

    // Use this for initialization
    void Start()
    {
        startButton.signalOnClick.AddListener(this.ShowLevel);
    }

    void ShowLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}