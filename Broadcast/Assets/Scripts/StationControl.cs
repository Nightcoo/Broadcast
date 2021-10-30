using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationControl : MonoBehaviour
{
    [SerializeField] private int stationNo = 2;
    public Camera stationCam;
    private Animator stationCamAnimator;
    //private int rememberStation;

    void Start(){

        stationCamAnimator = stationCam.GetComponentInParent<Animator>(); //Line Changed for the new model scene
        stationCamAnimator.SetInteger("Station", stationNo);
        Debug.Log("Start");
    }
 
    void Update()
    {
        //stationCamAnimator.SetInteger("Station", stationNo);
        stationNo = Mathf.Clamp(stationNo, 1, 3);
 
        if(Input.GetKeyDown(KeyCode.E)) LookBack();
        if(Input.GetKeyUp(KeyCode.E)) ReturnFromLookBack();
    }

    public void SwitchStation(int swapTo){

        stationNo += swapTo;
        stationCamAnimator.SetInteger("Station", stationNo);
    }

    void LookBack(){

       // rememberStation = stationNo;
        //stationCamAnimator.SetInteger("Station", 0);

        stationCamAnimator.SetBool("lookBack", true);
    }

    void ReturnFromLookBack(){

        //stationNo = rememberStation;
        //stationCamAnimator.SetInteger("Station", stationNo);

        stationCamAnimator.SetBool("lookBack", false);
    }
}
