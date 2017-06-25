using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class MyButton : MonoBehaviour
{
    public UnityEvent signalOnClick = new UnityEvent();

    void Start()
    {
    }

    public void _onClick()
    {
        this.signalOnClick.Invoke();
    }
}