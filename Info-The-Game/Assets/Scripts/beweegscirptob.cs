 using UnityEngine;
 using System.Collections;
 
 public class beweegscirptob : MonoBehaviour {
 
     public float afstand = 1.5f;  
     public float snelheid = 2.0f; 
     private Vector3 startPos;
 
     void Start () {
         startPos = transform.position;
     }
     
     void Update () {
         Vector3 v = startPos;
         v.z += afstand * Mathf.Sin (Time.time * snelheid);
         transform.position = v;
     }
 }
