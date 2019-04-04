



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntenscript : MonoBehaviour
{
    public Text timerText;
    private float startTime;


    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
	{
           float t = Time.time - startTime;

        string minuten = ((int)t / 60).ToString();
			string secondes = (t % 60).ToString("f2");

        timerText.text = "Tijd" + ":" + "" + minuten +":"+ secondes;
    }
}
