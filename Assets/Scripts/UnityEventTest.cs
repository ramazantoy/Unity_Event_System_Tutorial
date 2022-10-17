using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTest : MonoBehaviour
{
 [System.Serializable]
    public class  OnClicked : UnityEvent
    {
        
    }

    [SerializeField]
    private OnClicked leftClicked;

    [SerializeField]
    private OnClicked rightClicked;

    private void Start()
    {
        rightClicked.AddListener(PrintOnRight);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            leftClicked.Invoke();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rightClicked.Invoke();
        }
    }
    public void PrintOnRight()
    {
        Debug.Log("Right Clicked");
    }
    public void PrintOnLeft()
    {
        Debug.Log("Left Clicked");
    }
}
