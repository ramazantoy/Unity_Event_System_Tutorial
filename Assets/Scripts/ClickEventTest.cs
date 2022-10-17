using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventTest : MonoBehaviour
{
   public delegate void OnClicked();

   public static event OnClicked onRightClicked;

   public static event OnClicked onLeftClicked;

   private void Start()
   {
      onRightClicked += PrintOnRight;
      onLeftClicked += (() => //Lambda
      {
         Debug.Log("Left Clicked");
      });
   }

   private void PrintOnRight()
   {
      Debug.Log("Right Clicked");
   }
   
   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         onLeftClicked();
      }
      else if (Input.GetMouseButtonDown(1))
      {
         onRightClicked();
      }
   }
}
