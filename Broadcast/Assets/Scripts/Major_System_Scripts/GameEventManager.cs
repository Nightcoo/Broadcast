using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameEventManager : MonoBehaviour
{

    public GameObject skyLight;
    public VideoPlayer tapePlayer;
    public VideoClip[] clips;
    
    void Update(){
        
    }

    /*public void cueLightning(){

        //int lightningDist = Random.Range(0, 10);

        skyLight.GetComponent<Animation>().Play();

    }*/

    #region - Lightning -
    public void ButtonCueLightning(){

        StartCoroutine(cueLightning());
    }
    public IEnumerator cueLightning(){
        
        int lightningDist = Random.Range(0, 10);
        Debug.Log(lightningDist);
        
        
        skyLight.GetComponent<Animation>().Play();

        yield return new WaitForSeconds(lightningDist);
        skyLight.GetComponent<AudioSource>().Play(); 
    }

    #endregion

    #region - TapePlayer -

    public void PlayTape(){

        if(StaticVars.tapePlaying > 0) Debug.Log("Tape " + StaticVars.tapePlaying + " is playing");

        switch(StaticVars.tapePlaying){

            case 1:
            tapePlayer.clip = clips[1];
            break;

            case 2:
            tapePlayer.clip = clips[2];
            break;
        }

        tapePlayer.Play();
    }

    public void TapeFinish(){}

    #endregion
}