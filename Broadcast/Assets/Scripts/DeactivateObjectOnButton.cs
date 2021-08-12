using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjectOnButton : MonoBehaviour
{
    GrabTape grabTape;
    void Start(){

       grabTape = gameObject.GetComponent<GrabTape>();
    }
   
    void Update(){

       if(StaticVars.tapeHeld != grabTape.whichTape) ActivateThis();
    }
   
    public void DeactivateThis(){

        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void ActivateThis(){
        
        gameObject.GetComponent<Collider>().enabled = true;
        gameObject.GetComponent<Renderer>().enabled = true;
    }
}
