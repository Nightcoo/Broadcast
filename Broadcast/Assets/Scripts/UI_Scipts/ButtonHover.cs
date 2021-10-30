using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
    Button Right;
    public int toWhere;
    public GameObject gameManager;
    void Update()
    {
        //if(Right.OnMouseEnter(true))
    }

    void OnMouseEnter(){

        //Right.OnClick();
        Right.onClick.Invoke();
    }

    public void Transistion(){

        Debug.Log("Before");
        gameManager.GetComponent<StationControl>().SwitchStation(toWhere);
        Debug.Log("After");
    }
}
