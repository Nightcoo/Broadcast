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
}
