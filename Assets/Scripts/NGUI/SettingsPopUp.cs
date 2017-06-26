using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsPopUp : MonoBehaviour {
    public MyButton backgroundButton;
    public MyButton resumeButton;
    public MyButton respawnButton;
    public MyButton menuButton;



    void Start () {
        Time.timeScale = 0;
        resumeButton.signalOnClick.AddListener(this.CloseSettings);
        backgroundButton.signalOnClick.AddListener(this.CloseSettings);
        respawnButton.signalOnClick.AddListener(this.Respawn);
        menuButton.signalOnClick.AddListener(this.Menu);
	}
	
	void CloseSettings()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
    }

    void Respawn()
    {
        CloseSettings();
        PlayerController.current.Death();
    }

    void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
