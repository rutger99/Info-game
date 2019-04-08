



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntenscript : MonoBehaviour
{
    public Text timerText;
    private float startTijd;


    void Start()
    {
        startTijd = Time.time;

    }

   
    void Update()
	{
           float t = Time.time - startTijd;

        string minuten = ((int)t / 60).ToString();
			string secondes = (t % 60).ToString("f2");

        timerText.text = "Tijd" + ":" + "" + minuten +":"+ secondes;
    }
}
