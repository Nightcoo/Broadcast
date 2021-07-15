using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealNextButton : MonoBehaviour
{
    public Animator nextButton;
    public bool startRevealed = false;
    //private Vector3 startPosition;

    void Start(){

        if(startRevealed) gameObject.GetComponent<Animator>().SetBool("Reveal", true);
    }

    public void RevealButton(){

        Invoke("UnpressButton", 1);

        //startPosition = transform.position;
        gameObject.GetComponent<Animator>().SetBool("Pressed", true);
        nextButton.SetBool("Reveal", true);

        
    }
    
    public void UnpressButton(){

        gameObject.GetComponent<Animator>().SetBool("Pressed", false);
    }
   /* void LateUpdate(){

        transform.localPosition += startPosition;
    }*/
}
