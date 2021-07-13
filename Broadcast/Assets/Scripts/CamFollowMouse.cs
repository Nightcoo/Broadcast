using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowMouse : MonoBehaviour
{

    //EXPERIMENTAL AND NON FUNCTIONING
    public Vector3 mousePos;
    public int xMaxRot = 10;
    public int yMaxRot= 14;

    void Update()
    {
        mousePos = Input.mousePosition - new Vector3(Screen.width /2, Screen.height /2, 0);
        mousePos = new Vector3(mousePos.x / (Screen.width /2), mousePos.y /(Screen.height /2), 0);

        mousePos = new Vector3 (mousePos.x * xMaxRot, mousePos.y * yMaxRot, 1);

        //Vector3 relativePos = mousePos - transform.position;

        Quaternion lookRot = Quaternion.LookRotation(mousePos, Vector3.up);

        //Quaternion lookRot = Quaternion(mousePos.x, mousePos.y, transform.rotation.z, transform.rotation.w);

        transform.SetPositionAndRotation(transform.position, lookRot);

        //transform.rotation = lookRot;
    }
}
