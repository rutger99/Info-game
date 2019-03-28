using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Terugbutton : MonoBehaviour
{


  
    public void terug()
    {
        SceneManager.LoadScene("main menu", LoadSceneMode.Single);
    }


}
