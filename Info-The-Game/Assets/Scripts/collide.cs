using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collide : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.name == "player")
        {

            SceneManager.LoadScene(2);
        }
    }
}