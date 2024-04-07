using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Windows.Devices.Sensors;

public class Get_Data : MonoBehaviour
{
    public TextMeshProUGUI accelerometerText;
    public TextMeshProUGUI dataPointsCollected;
    public int number;
    public Array dataPoints = new int[arraySize];
    private static int arraySize = 200;

    private Altimeter



    // Start is called before the first frame update
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
        number = 0;
        dataPointsCollected.text = "Nr." + number;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NumberOfDataPoints()
    {
        number += 1;
        dataPointsCollected.text = "Nr." + number;
    }

    public void AddDataPointToArray()
    {

    }

    private void ScenarioGetData(object sender, RoutedEventArgs e)
    {
        if (null != sensor)
        {
            AltimeterReading reading = sensor.GetCurrentReading();
            if (null != reading)
            {
                ScenarioOutput_M.Text = String.Format("{0,5:0.00}", reading.AltitudeChangeInMeters);
            }
        }
    }
}