﻿ using UnityEngine;
 using System.Collections;
  
 public class PlayerController : MonoBehaviour
  
 {
         void Update ()
         {
                 if (Input.GetKeyDown(KeyCode.RightArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.z--;
                         this.transform.position = position;
                 }
                 
                 if (Input.GetKeyDown(KeyCode.LeftArrow))
                 {
                         Vector3 position = this.transform.position;
                         position.z++;
                         this.transform.position = position;
                 }
                 
 }
 }
