



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
        float t = (Time.time - startTime) * 15;

        string punten1 = (t).ToString("f0");
        

        timerText.text = "Score" + ":" + " " + punten1;
    }
}
