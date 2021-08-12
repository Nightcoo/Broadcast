using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{

    public GameObject skyLight;
    
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

    public void PlayTape(){}

    public void TapeFinish(){}

    #endregion
}