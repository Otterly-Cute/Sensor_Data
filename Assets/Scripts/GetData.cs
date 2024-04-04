using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetData : MonoBehaviour
{
    public TextMeshProUGUI accelerometerText;


    void Start()
    {
        //check if we have a accelerometer
        if (SystemInfo.supportsAccelerometer)
        {
            accelerometerText.text = "Accelerometer Supported";
        }
        else
        {
            accelerometerText.text = "Accelerometer Not Supported";
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
