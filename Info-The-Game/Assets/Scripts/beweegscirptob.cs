 using UnityEngine;
 using System.Collections;
 
 public class beweegscirptob : MonoBehaviour {
 
     public float delta = 1.5f;  
     public float speed = 2.0f; 
     private Vector3 startPos;
 
     void Start () {
         startPos = transform.position;
     }
     
     void Update () {
         Vector3 v = startPos;
         v.z += delta * Mathf.Sin (Time.time * speed);
         transform.position = v;
     }
 }
