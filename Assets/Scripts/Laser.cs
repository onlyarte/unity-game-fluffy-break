using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    public bool isLaserOn = true;

    Sprite laserSprite = null;
    SpriteRenderer sr = null;

    Vector3 position = new Vector3(0, 0, 0);

    void Awake()
    {
        position = transform.position;

        sr = GetComponent<SpriteRenderer>();
        laserSprite = sr.sprite;
        if (!isLaserOn)
        {
            sr.sprite = null;
        }
    }

	public void LaserOn()
    {
        transform.position = position;
        transform.localScale += new Vector3(0, 0.6F, 0);

    }

    public void LaserOff()
    {
        transform.localScale = new Vector3(transform.localScale.x, 0, transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerController.current.Death();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        OnTriggerEnter2D(collider);
    }
}
