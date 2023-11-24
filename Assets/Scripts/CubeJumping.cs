using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumping : MonoBehaviour
{
    [SerializeField] float yRange;
    [SerializeField] float yFlipRange;


    public float moveSpeed = 5f;

    void Update()
    {

        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);


        if (transform.localPosition.y >= yRange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed);
        }


        if (transform.localPosition.y <= -yFlipRange)
        {
            moveSpeed = Mathf.Abs(moveSpeed);
        }
    }
}
