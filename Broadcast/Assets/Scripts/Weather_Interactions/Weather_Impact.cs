using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather_Impact : MonoBehaviour
{

    public int weatherEventType;
    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "ControlRoom"){

            
            switch (weatherEventType){

                case 1:

                    StaticVars.FogCloudUnprotected();

                break;

                case 2:

                   StaticVars.RedLightUnprotected(); 

                   gameObject.GetComponent<AudioSource>().Play();

                break;

                case 3:

                    StaticVars.WindUnprotected();

                break;
            }
            
            
            
        }
    }
}
