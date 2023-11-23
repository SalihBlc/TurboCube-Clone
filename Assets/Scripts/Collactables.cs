using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Collactables : MonoBehaviour
{
    bool isCollect;
    float index;
    public Picker picker;


    void Start()
    {
        isCollect = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isCollect == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);

            }
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "block" && picker.height > 0)
        {
            picker.DropHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }

    }
    public bool isCollectable()
    {
        return isCollect;
    }
    public void GetCollect()
    {
        isCollect = true;
    }
    public void Index(float index)
    {
        this.index = index;
    }
}
