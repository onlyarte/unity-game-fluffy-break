using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {

    public GameObject settingsPrefab;
    public MyButton pauseButton;

    void Start()
    {
        pauseButton.signalOnClick.AddListener(this.ShowSettings);
    }

    void ShowSettings()
    {
        GameObject parent = UICamera.first.transform.parent.gameObject;
        GameObject obj = NGUITools.AddChild(parent, settingsPrefab);
        SettingsPopUp popup = obj.GetComponent<SettingsPopUp>();
    }
}
