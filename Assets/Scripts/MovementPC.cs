using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Movement : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float horizontalSpeed = 20f;
    public float moveRangeX = 5.0f;
    public GameObject character;

    void Update()
    {
        StartMove();

    }
    public void StartMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float newPositionXX = character.transform.position.x + horizontal * horizontalSpeed * Time.deltaTime;
        newPositionXX = Mathf.Clamp(newPositionXX, -moveRangeX, moveRangeX);
        character.transform.position = new Vector3(newPositionXX, transform.position.y, transform.position.z);
        character.transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
    }
}
