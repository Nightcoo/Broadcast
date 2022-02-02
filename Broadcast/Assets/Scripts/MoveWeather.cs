using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class MoveWeather : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * -speed;

        if(Input.GetKeyDown(KeyCode.Z)) Destroy(gameObject);
    }
}
