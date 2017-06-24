using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool isDoorClosed = true;
    public float scale = 0.65f;
    public bool isAutoStart = false;
    public float autoStartTime;

    Sprite doorSprite = null;
    SpriteRenderer sr = null;

    Vector3 position = new Vector3(0, 0, 0);

    void Awake()
    {
        position = transform.position;

        sr = GetComponent<SpriteRenderer>();
        doorSprite = sr.sprite;
        if (!isDoorClosed)
        {
            sr.sprite = null;
        }
    }

    void Start()
    {
        if (isAutoStart)
        {
            StartCoroutine(AutoOpen(autoStartTime));
        }
    }

    IEnumerator AutoOpen(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        DoorOpen();
    }

    public void DoorClose()
    {
        transform.position = position;
        transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);

    }

    public void DoorOpen()
    {
        transform.localScale = new Vector3(transform.localScale.x, 0, transform.localScale.z);
    }
}
