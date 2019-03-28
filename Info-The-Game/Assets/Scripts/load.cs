using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class load : MonoBehaviour
{


  
    public void speel()
    {
        SceneManager.LoadScene("Info-the-game", LoadSceneMode.Single);
    }


}
