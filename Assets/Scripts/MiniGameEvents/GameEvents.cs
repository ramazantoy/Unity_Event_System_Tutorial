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

 public event Action <int> onDoorWayTriggerEnter;

 public void DoorWayEnter(int id)
 {
     if (onDoorWayTriggerEnter != null)
     {
         onDoorWayTriggerEnter(id);
     }
 }
 
 public event Action <int> onDoorWayTriggerExit;

 public void DoorWayExit(int id)
 {
     if (onDoorWayTriggerExit != null)
     {
         onDoorWayTriggerExit(id);
     }
 }
}
