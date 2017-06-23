using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAbstract : MonoBehaviour {

    public Sprite buttonPressed;
    public Sprite buttonUnpressed;

    private new SpriteRenderer renderer = null;

    protected virtual void ButtonEnterAction()
    {
    }

    protected virtual void ButtonExitAction()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PressButton();
        this.ButtonEnterAction();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        OnTriggerEnter2D(collider);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        UnpressButton();
        this.ButtonExitAction();
    }

    void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void PressButton()
    {
        renderer.sprite = buttonPressed;
    }

    void UnpressButton()
    {
        renderer.sprite = buttonUnpressed;
    }
}
