using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetData : MonoBehaviour
{
    public TMP_Text accelerometerText;


    void Start()
    {
        //check if we have a accelerometer
        if(SystemInfo.supportsAccelerometer)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
