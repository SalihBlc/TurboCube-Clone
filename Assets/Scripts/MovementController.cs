using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float moveRangeX = 5.0f;

    void Update()
    {

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            if (touch.position.x < Screen.width / 2)
            {

                MoveLeft();
            }
            else if (touch.position.x >= Screen.width / 2)
            {

                MoveRight();
            }
        }


        MoveForward();
    }

    void MoveLeft()
    {

        float newPositionX = transform.position.x - moveSpeed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -moveRangeX, moveRangeX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    void MoveRight()
    {

        float newPositionX = transform.position.x + moveSpeed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -moveRangeX, moveRangeX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    void MoveForward()
    {

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    public void NotForward()
    {
        moveSpeed = 0;


    }
}
