using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
 public  float speed;
 public Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            rb.AddForce (-Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.AddForce (Vector3.forward * speed * Time.deltaTime);
        }

        
    }
}