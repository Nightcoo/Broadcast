using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeatherTest : MonoBehaviour
{
    public int oncomingDirection = 0;   // N=1 E=2 S=3 W=4
    public Transform[] cardinals;
    public GameObject[] weatherEvent;

    public static bool eventAvoided;

    void Start()
    {
        StartCoroutine(DelayBeforeNextEvent());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){

            SetPositionAndSpawn();
        }
    }

    void SetPositionAndSpawn(){

        oncomingDirection = Random.Range(1, 5);

        int n = Random.Range(1, weatherEvent.Length);

        switch (oncomingDirection){

            case 1:
                Instantiate(weatherEvent[n], cardinals[1].transform.position, cardinals[1].rotation); 
                //transform.SetPositionAndRotation(cardinals[1].transform.position, cardinals[1].rotation);
                break;
                
            case 2:
                Instantiate(weatherEvent[n], cardinals[2].transform.position, cardinals[2].rotation); 
                //transform.SetPositionAndRotation(cardinals[2].transform.position, cardinals[2].rotation);
                break;

            case 3:
                Instantiate(weatherEvent[n], cardinals[3].transform.position, cardinals[3].rotation); 
                //transform.SetPositionAndRotation(cardinals[3].transform.position, cardinals[3].rotation);
                break;

            case 4:
                Instantiate(weatherEvent[n], cardinals[4].transform.position, cardinals[4].rotation); 
                //transform.SetPositionAndRotation(cardinals[4].transform.position, cardinals[4].rotation);
                break;    
        }

        StartCoroutine(DelayBeforeNextEvent());
    }


    IEnumerator DelayBeforeNextEvent(){

        int t = Random.Range(5, 10);

        yield return new WaitForSeconds(t);
        Debug.Log("Starting Next event");
        SetPositionAndSpawn();
    }

}
