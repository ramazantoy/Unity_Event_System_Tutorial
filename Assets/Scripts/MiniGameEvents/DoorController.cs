using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DoorController : MonoBehaviour
{
   
    void Start()
    {
        GameEvents.Instance.onDoorWayTriggerEnter += OnDoorWayOpen;
        
        GameEvents.Instance.onDoorWayTriggerExit += OnDoorWayExit;
    }

    private void OnDoorWayOpen()
    {
        transform.DOLocalMoveY(0f, 1f);
    }

    private void OnDoorWayExit()
    {
        transform.DOLocalMoveY(-3.16f, 1f);
    }
 
}
