using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
 public static GameEvents Instance;

 private void Awake()
 {
  Instance = this;
 }

 public event Action onDoorWayTriggerEnter;

 public void DoorWayEnter()
 {
     if (onDoorWayTriggerEnter != null)
     {
         onDoorWayTriggerEnter();
     }
 }
 
 public event Action onDoorWayTriggerExit;

 public void DoorWayExit()
 {
     if (onDoorWayTriggerExit != null)
     {
         onDoorWayTriggerExit();
     }
 }
}
