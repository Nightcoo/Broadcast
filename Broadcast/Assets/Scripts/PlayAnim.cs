using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public int which = 0;
    
    
    public void PlayAnimation(){

        // if(which == 0){ 
            
        //     gameObject.GetComponent<Animation>().Play();
        //     which = 1; 
        //     Debug.Log("drawer open");
        //     }

        // else if (which == 1){

        //     gameObject.GetComponent<Animation>().Rewind();
        //     // which = 0; 
        //     Debug.Log("drawer closed");
        // }

        switch(which){

            case 0:
               
                gameObject.GetComponent<Animation>().Play();
                which = 1; 
                Debug.Log("drawer open");
                break;

            case 1:

                gameObject.GetComponent<Animation>().Rewind();
                which = 0; 
                Debug.Log("drawer closed");
                break;
        }

        
    }
}
