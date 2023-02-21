using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationNo : MonoBehaviour
{
    public int Station;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Weather"){

            // col.gameObject.GetComponent<MoveWeather>().WeatherType;

            Debug.Log(col.gameObject.GetComponent<MoveWeather>().WeatherType + " incoming from Tower " +Station);
        }
    }

}
