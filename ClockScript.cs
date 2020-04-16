using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;

public class ClockScript : MonoBehaviour
{
    public Text textClock; 

    void Awake ()
    { 
        textClock = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
       // textClock.text = hour + ":" + minute + ":" + second;
    }
}
