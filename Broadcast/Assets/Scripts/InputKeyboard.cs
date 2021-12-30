using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputKeyboard : MonoBehaviour
{
    public static string keyboardText = "";
    public static bool usingKeyboard = false;
    public GameObject screentext;

    void Update()
    {
        if(usingKeyboard == true){

            Type();
        }

        if(Input.GetKeyDown(KeyCode.Escape) && usingKeyboard == true){ 
            
            usingKeyboard = false;
        }
    }

    public void useKeyboardtoType(){

        usingKeyboard = true;
        // Debug.Log("Keyboard activated");

    }
    void Type(){

        //letters
       if(Input.GetKeyDown(KeyCode.A)) keyboardText = keyboardText + "a";
       else if(Input.GetKeyDown(KeyCode.B)) keyboardText = keyboardText + "b";
       else if(Input.GetKeyDown(KeyCode.C)) keyboardText = keyboardText + "c";
       else if(Input.GetKeyDown(KeyCode.D)) keyboardText = keyboardText + "d";
       else if(Input.GetKeyDown(KeyCode.E)) keyboardText = keyboardText + "e";
       else if(Input.GetKeyDown(KeyCode.F)) keyboardText = keyboardText + "f";
       else if(Input.GetKeyDown(KeyCode.G)) keyboardText = keyboardText + "g";
       else if(Input.GetKeyDown(KeyCode.H)) keyboardText = keyboardText + "h";
       else if(Input.GetKeyDown(KeyCode.I)) keyboardText = keyboardText + "i";
       else if(Input.GetKeyDown(KeyCode.J)) keyboardText = keyboardText + "j";
       else if(Input.GetKeyDown(KeyCode.K)) keyboardText = keyboardText + "k";
       else if(Input.GetKeyDown(KeyCode.L)) keyboardText = keyboardText + "l";
       else if(Input.GetKeyDown(KeyCode.M)) keyboardText = keyboardText + "m";
       else if(Input.GetKeyDown(KeyCode.N)) keyboardText = keyboardText + "n";
       else if(Input.GetKeyDown(KeyCode.O)) keyboardText = keyboardText + "o";
       else if(Input.GetKeyDown(KeyCode.P)) keyboardText = keyboardText + "p";
       else if(Input.GetKeyDown(KeyCode.Q)) keyboardText = keyboardText + "q";
       else if(Input.GetKeyDown(KeyCode.R)) keyboardText = keyboardText + "r";
       else if(Input.GetKeyDown(KeyCode.S)) keyboardText = keyboardText + "s";
       else if(Input.GetKeyDown(KeyCode.T)) keyboardText = keyboardText + "t";
       else if(Input.GetKeyDown(KeyCode.U)) keyboardText = keyboardText + "u";
       else if(Input.GetKeyDown(KeyCode.V)) keyboardText = keyboardText + "v";
       else if(Input.GetKeyDown(KeyCode.W)) keyboardText = keyboardText + "w";
       else if(Input.GetKeyDown(KeyCode.X)) keyboardText = keyboardText + "x";
       else if(Input.GetKeyDown(KeyCode.Y)) keyboardText = keyboardText + "y";
       else if(Input.GetKeyDown(KeyCode.Z)) keyboardText = keyboardText + "z";

        //numbers
       else if(Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) keyboardText = keyboardText + "0";
       else if(Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) keyboardText = keyboardText + "1";
       else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) keyboardText = keyboardText + "2";
       else if(Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) keyboardText = keyboardText + "3";
       else if(Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) keyboardText = keyboardText + "4";
       else if(Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) keyboardText = keyboardText + "5";
       else if(Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) keyboardText = keyboardText + "6";
       else if(Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) keyboardText = keyboardText + "7";
       else if(Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) keyboardText = keyboardText + "8";
       else if(Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) keyboardText = keyboardText + "9";

        //space
       else if(Input.GetKeyDown(KeyCode.Space)) keyboardText = keyboardText + " ";

        //quotation
       else if(Input.GetKeyDown(KeyCode.Question)) keyboardText = keyboardText + "?";
       else if(Input.GetKeyDown(KeyCode.Period)) keyboardText = keyboardText + ".";
       else if(Input.GetKeyDown(KeyCode.Exclaim)) keyboardText = keyboardText + "!";

       else if(Input.GetKeyDown(KeyCode.Backspace)) keyboardText = "";

        //put text on the screen
       screentext.GetComponent<TextMesh>().text = keyboardText;
    }

}
