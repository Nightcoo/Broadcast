using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class MoveWeather : MonoBehaviour
{
    public float regSpeed = 20;
    public float slowSpeed = 5;
    private float currentSpeed;
    private Rigidbody rb;

    public string WeatherType;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        currentSpeed = regSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * -currentSpeed;

        if(Input.GetKeyDown(KeyCode.Z)) Destroy(gameObject);
    }

    void OnTriggerEnter(Collider col){

       if(col.gameObject.tag == "Slow") currentSpeed = slowSpeed;
    }

    void OnTriggerExit(Collider col){

       if(col.gameObject.tag == "Slow") currentSpeed = regSpeed;
    }
}
