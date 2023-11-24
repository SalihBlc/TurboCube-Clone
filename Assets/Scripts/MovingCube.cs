using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField] float xRange;
    [SerializeField] float xRang;



    public float moveSpeed = 5f;

    void Update()
    {

        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);


        if (transform.localPosition.x >= xRange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed);
        }


        if (transform.localPosition.x <= -xRang)
        {
            moveSpeed = Mathf.Abs(moveSpeed);
        }
    }
}
