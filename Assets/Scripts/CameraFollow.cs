using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * 10);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
