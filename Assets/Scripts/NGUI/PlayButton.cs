using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public MyButton playButton;

    // Use this for initialization
    void Start()
    {
        playButton.signalOnClick.AddListener(this.ShowLevel);
    }

    void ShowLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
