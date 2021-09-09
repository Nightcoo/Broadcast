using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapeInventory : MonoBehaviour
{
    public GameObject tapeSprite;
    public void AddTapeInventory(){

        tapeSprite.SetActive(true);
        //tapeSprite.GetComponent<SpriteRenderer>().enabled = true;
        //tapeSprite.GetComponentInChildren<Text>().enabled = true;
        tapeSprite.GetComponentInChildren<Text>().text = ""+StaticVars.tapeHeld;
    }

    public void ReleaseTapeInventory(){

        StaticVars.tapeHeld = 0;
        tapeSprite.GetComponentInChildren<Text>().text = ""+StaticVars.tapeHeld;
        tapeSprite.SetActive(false);
    }

    public void SwapTapes(){

        int tapeBuffer;

        tapeBuffer = StaticVars.tapePlaying;
        StaticVars.tapePlaying = StaticVars.tapeHeld;
        StaticVars.tapeHeld = tapeBuffer;

        Debug.Log("Tape " + StaticVars.tapeHeld + " held");

        if(StaticVars.tapeHeld == 0) tapeSprite.SetActive(false);
        else tapeSprite.GetComponentInChildren<Text>().text = ""+StaticVars.tapeHeld;

        AddTapeInventory();
    }
}
