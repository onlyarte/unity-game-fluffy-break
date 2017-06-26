using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour {
    
    public GameObject winPrefab;

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject parent = UICamera.first.transform.parent.gameObject;
        GameObject obj = NGUITools.AddChild(parent, winPrefab);
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        OnTriggerEnter2D(collider);
    }
}
