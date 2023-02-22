using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward_Reverse : MonoBehaviour
{
    // int animSpeed = -1;
    Animator anim;
    bool direction;

    void Start(){

        direction = false;
        anim = gameObject.GetComponent<Animator>();
    }
    
    public void SetDirection(){

        // if (animSpeed == -1) animSpeed = 1;
        // else if (animSpeed == 1) animSpeed =-1;
        // //gameObject.GetComponent<Animation>().speed = animSpeed;

      if(direction == false){
       
        anim.SetBool("Flip", true);
        direction = true;
        
    } else if (direction == true){ 
       
        anim.SetBool("Flip", false); 
        direction = false;
        
        }
     }
}
