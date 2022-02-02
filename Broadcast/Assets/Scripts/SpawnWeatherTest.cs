using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeatherTest : MonoBehaviour
{
    public int oncomingDirection = 0;   // N=1 E=2 S=3 W=4
    public Transform[] cardinals;
    public GameObject weatherEvent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){

            SetPositionAndSpawn();
        }
    }

    void SetPositionAndSpawn(){

        switch (oncomingDirection){

            case 1:
                Instantiate(weatherEvent, cardinals[1].transform.position, cardinals[1].rotation); 
                //transform.SetPositionAndRotation(cardinals[1].transform.position, cardinals[1].rotation);
                break;
                
            case 2:
                Instantiate(weatherEvent, cardinals[2].transform.position, cardinals[2].rotation); 
                //transform.SetPositionAndRotation(cardinals[2].transform.position, cardinals[2].rotation);
                break;

            case 3:
                Instantiate(weatherEvent, cardinals[3].transform.position, cardinals[3].rotation); 
                //transform.SetPositionAndRotation(cardinals[3].transform.position, cardinals[3].rotation);
                break;

            case 4:
                Instantiate(weatherEvent, cardinals[4].transform.position, cardinals[4].rotation); 
                //transform.SetPositionAndRotation(cardinals[4].transform.position, cardinals[4].rotation);
                break;    
        }
    }

}
