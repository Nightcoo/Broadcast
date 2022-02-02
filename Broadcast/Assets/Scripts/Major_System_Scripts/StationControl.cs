using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationControl : MonoBehaviour
{
    [SerializeField] private int stationNo = 2;
    public Camera stationCam;
    private Animator stationCamAnimator;
    //private int rememberStation;

    public GameObject upButton;
    public GameObject downButton;

    void Start(){

        stationCamAnimator = stationCam.GetComponentInParent<Animator>(); //Line Changed for the new model scene
        stationCamAnimator.SetInteger("Station", stationNo);
        Debug.Log("Start");
    }
 
    void Update()
    {
        //stationCamAnimator.SetInteger("Station", stationNo);
        stationNo = Mathf.Clamp(stationNo, 1, 3);
 
        if(Input.GetKeyDown(KeyCode.X)) LookBack();
        if(Input.GetKeyUp(KeyCode.X)) ReturnFromLookBack();

        if(InputKeyboard.usingKeyboard == false) stationCamAnimator.SetBool("usingKeyboard", false);
    }

    public void SwitchStation(int swapTo){

        stationNo += swapTo;
        stationCamAnimator.SetInteger("Station", stationNo);

        if(stationNo == 3) downButton.SetActive(true);
        else downButton.SetActive(false);
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

    public void RevealUpButton(){

        stationCamAnimator.SetBool("lookDown", true);
        downButton.SetActive(false);
        upButton.SetActive(true);
    }

    public void RevealDownButton(){

        stationCamAnimator.SetBool("lookDown", false);
        downButton.SetActive(true);
        upButton.SetActive(false);
    }

    public void LookatScreen(){

        stationCamAnimator.SetBool("usingKeyboard", true);
    }
}

