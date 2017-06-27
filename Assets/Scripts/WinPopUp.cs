using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPopUp : MonoBehaviour {

    public MyButton backgroundButton;
    public MyButton menuButton;
    public MyButton nextButton;

    public UILabel deaths;
    public UILabel bestDeaths;
    public UILabel time;
    public UILabel bestTime;

    void Start()
    {
        PlayerController.current.levelController.saveOnWin();
        //Time.timeScale = 0;
        backgroundButton.signalOnClick.AddListener(this.openMenu);
        menuButton.signalOnClick.AddListener(this.openMenu);
        nextButton.signalOnClick.AddListener(this.openNext);

        deaths.text += PlayerController.current.levelController.getDeaths();
        bestDeaths.text += PlayerController.current.levelController.getBestDeaths();
        time.text += PlayerController.current.levelController.getTime() + " s";
        bestTime.text += PlayerController.current.levelController.getBestTime() + " s";
    }

    void openMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    void openNext()
    {
        Time.timeScale = 1;
        int nextLevel = PlayerController.current.level + 1;
        if(nextLevel >= 3)
            SceneManager.LoadScene("Final");
        else
            SceneManager.LoadScene("Level" + nextLevel);
    }
}
