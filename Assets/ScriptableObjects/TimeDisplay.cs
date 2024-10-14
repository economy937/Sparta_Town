using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeDiplay : MonoBehaviour
{
    public Text Time;

    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm:ss"));
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.text = GetCurrentTime();
    }
}
