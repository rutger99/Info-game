using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collidecube : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.name == "player")
        {

            SceneManager.LoadScene(3);
        }
    }
}