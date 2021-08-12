using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTape : MonoBehaviour
{
    public int whichTape;
    public void RecordTape(){

        StaticVars.tapeHeld = whichTape;
    }
}
