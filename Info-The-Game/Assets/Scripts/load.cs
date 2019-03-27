

 using System.Collections; 
 using System.Collections.Generic; 
 using UnityEngine; 
 using UnityEngine.SceneManagement; 

 
 public class load : MonoBehaviour 
 { 
 
 
    public void Terug() 
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

 
 } 
