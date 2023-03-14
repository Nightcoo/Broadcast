using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CamFollowMouse : MonoBehaviour
{

    //EXPERIMENTAL AND NON FUNCTIONING  
    // [SerializeField] private MouseLook m_MouseLook;
    // private Camera m_Camera;

    public float xMaxRot = 0.2f;
    public float yMaxRot= 0.6f;
    public Vector3 mousePos;
 
    void Start(){

        // m_Camera = Camera.main;

        // m_MouseLook.Init(transform , m_Camera.transform);

        // mycam = gameobject.GetComponent<Camera>();

        // mycam = gameObject.GetComponent<Camera>();
        // vp = mycam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane));
    }   

    void Update()
    {
        mousePos = Input.mousePosition - new Vector3(Screen.width /2, Screen.height /2, 1); //track mouse position on screen
        
        mousePos = new Vector3(mousePos.x / (Screen.width /2), mousePos.y /(Screen.height /2), 1);  //scales the values to the screen so that numbers are small

        mousePos = new Vector3(Mathf.Clamp(mousePos.x, -xMaxRot, xMaxRot), Mathf.Clamp(mousePos.y, -yMaxRot, yMaxRot), 1); //locks values within a Max possible

        mousePos = new Vector3(mousePos.x * xMaxRot, mousePos.y * yMaxRot, 1); //scales the mouse position to the confines

        //Vector3 relativePos = mousePos - transform.position;

        Quaternion lookRot = Quaternion.LookRotation(mousePos, Vector3.up); // creates the mathemataical angle to look in

        //Quaternion lookRot = Quaternion(mousePos.x, mousePos.y, transform.rotation.z, transform.rotation.w);

        // transform.SetPositionAndRotation(transform.position, lookRot);

        transform.localRotation = lookRot; //actually moves the camera

    }

    // void FixedUpdate(){

    //     m_MouseLook.UpdateCursorLock();
    // }

    // private void RotateView()
    //     {
    //         m_MouseLook.LookRotation (transform, m_Camera.transform);
    //     }
}
