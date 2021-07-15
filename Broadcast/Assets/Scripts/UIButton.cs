using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

[RequireComponent(typeof(Button))]
public class UIButton : MonoBehaviour {

    //public Sprite regular;
    //public Sprite mouseOver;
    //public Sprite mouseClicked;
    //public TextMeshPro buttonText;

    private void OnMouseDown(){
        
        Debug.Log("Clicked");
        gameObject.GetComponent<Button>().onClick.Invoke();
    }

    private void OnMouseEnter(){

    }

    private void OnMouseExit(){

    }

    private void OnMouseUpAsButton(){

    }
}