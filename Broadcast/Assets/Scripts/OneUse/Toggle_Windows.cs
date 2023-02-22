using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Animator))]
public class Toggle_Windows : MonoBehaviour
{
    bool pull;    
    Animator anim;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        pull = false;
    }

    public void Toggle(){

        if(pull == false){

            pull = true;
            anim.SetBool("Pull", pull);
          
        }

        else if(pull == true){

            pull = false;
            anim.SetBool("Pull", pull); 
        }

    }
}
