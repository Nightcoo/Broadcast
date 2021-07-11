using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeSeat : MonoBehaviour
{

    public float step = 2000;
    private bool isSeated;
    // Start is called before the first frame update
    
   void Update(){

       if(isSeated = true && (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0)){
           
            isSeated = false;
            gameObject.GetComponent<Collider>().enabled = true;
       }
   } 
    
    void OnTriggerStay(Collider col){

        if(col.gameObject.tag == "Seat" && Input.GetKeyDown(KeyCode.Q) && isSeated == false){

            Transform target = col.transform.GetChild(0).transform;

            gameObject.GetComponent<Collider>().enabled = false;
            
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            isSeated = true;
        }
    }
}
