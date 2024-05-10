using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientopersonaje : MonoBehaviour
{
    public float speed = 1.0f;
    public float RotationSpeed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime);

        float rotacionY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotacionY * Time.deltaTime * RotationSpeed, 0));

    }
}
