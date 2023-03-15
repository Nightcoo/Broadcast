using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Button))]
public class ButtonHover : MonoBehaviour
{
    Button butt;

    void Awake()
    {
       // Debug.Log("woke mob");
        butt = gameObject.GetComponent<Button>();
    }

    public void HoverTrigger(){

       // Debug.Log("hover triggered");
        butt.onClick.Invoke();
    }
}
