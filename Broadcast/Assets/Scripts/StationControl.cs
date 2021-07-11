using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationControl : MonoBehaviour
{
    [SerializeField] private int stationNo = 2;
    public Camera stationCam;
    private Animator stationCamAnimator;
    private int rememberStation;

    void Start(){

        stationCamAnimator = stationCam.GetComponent<Animator>();
        stationCamAnimator.SetInteger("Station", stationNo);
    }
 

    // Update is called once per frame
    void Update()
    {
        //stationCamAnimator.SetInteger("Station", stationNo);

        
        if(Input.GetButtonDown("Jump")) LookBack();

        if(Input.GetButtonUp("Jump")) ReturnFromLookBack();
    }

    public void SwitchStation(int switchTo){

        stationNo += switchTo;
        stationCamAnimator.SetInteger("Station", stationNo);
    }

    void LookBack(){

        rememberStation = stationNo;
        stationCamAnimator.SetInteger("Station", 0);
    }

    void ReturnFromLookBack(){

        stationNo = rememberStation;
        stationCamAnimator.SetInteger("Station", stationNo);
    }
}
