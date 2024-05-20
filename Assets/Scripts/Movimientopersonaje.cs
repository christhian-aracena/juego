using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientopersonaje : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public float lookSpeed = 2f; // Velocidad de rotaci�n de la c�mara

    void Update()
    {
        // Control del movimiento del jugador
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);

        // Control de la rotaci�n de la c�mara con el rat�n
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX * lookSpeed);

        // Rotaci�n de la c�mara alrededor del jugador
        Camera.main.transform.RotateAround(transform.position, transform.right, -mouseY * lookSpeed);
    }
}
