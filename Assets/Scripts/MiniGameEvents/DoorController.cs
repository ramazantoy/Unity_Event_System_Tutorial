using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class DoorController : MonoBehaviour
{
     [SerializeField]
    private int _id;
   
    void Start()
    {
        GameEvents.Instance.onDoorWayTriggerEnter += OnDoorWayOpen;
        
        GameEvents.Instance.onDoorWayTriggerExit += OnDoorWayExit;
    }

    private void OnDoorWayOpen(int id)
    {
        if(_id==id)
            transform.DOLocalMoveY(0f, 1f);
    }

    private void OnDoorWayExit(int id)
    {     
        if(_id==id) 
            transform.DOLocalMoveY(-3.16f, 1f);
    }
 
}
