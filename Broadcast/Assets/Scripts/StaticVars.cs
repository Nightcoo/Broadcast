using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVars : MonoBehaviour
{

    public static bool Lighting;
    public static bool redClouds;
    public static bool tapeNotPlaying;
    public static int tapePlaying;
    public static int tapeHeld;

    public static void FogCloudUnprotected(){   // this should expose you to fog monsters (for a time?)

        // float t = Time.time;
        // float f;
        // do{                     // this loop may break everything and alos be too fast
        
        //     f = Time.time - t;

        //     RenderSettings.fogDensity = Mathf.Lerp(RenderSettings.fogDensity, .1f, t);
        
        // }while( f < 1); 

        RenderSettings.fogDensity = .1f;
    }

    public static void FogCloudUnprotectedExit(){

        RenderSettings.fogDensity = .01f;
    }

    public static void RedLightUnprotected(){       // this should deactivate your tracking hardware (for a time?)

        
        //this should have a pulse sound and a visual emp
    }

    public static void WindUnprotected(){   //this should disable communications (for a time?)


        //this should pay audio clip fo something breaking        
    }
}
