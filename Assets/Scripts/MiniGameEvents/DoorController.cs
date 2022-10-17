using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
   
    void Start()
    {
        GameEvents.Instance.onDoorWayTriggerEnter += OnDoorWayOpen;
    }

    private void OnDoorWayOpen()
    {
        
    }
 
}
