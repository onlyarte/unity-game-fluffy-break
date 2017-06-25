using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour {

    public string nextLevelName;

    void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(nextLevelName);
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        OnTriggerEnter2D(collider);
    }
}
