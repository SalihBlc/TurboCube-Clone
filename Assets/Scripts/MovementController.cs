using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float moveRangeX = 5.0f; // X ekseni boyunca izin verilen maksimum hareket mesafesi

    void Update()
    {
        // Dokunmatik ekranın üzerindeki her dokunmatik girdiyi kontrol et
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            if (touch.position.x < Screen.width / 2)
            {
                // Ekranın sol yarısına dokunulduysa sola git
                MoveLeft();
            }
            else if (touch.position.x >= Screen.width / 2)
            {
                // Ekranın sağ yarısına dokunulduysa sağa git
                MoveRight();
            }
        }

        // İleri gitme işlemi
        MoveForward();
    }

    void MoveLeft()
    {
        // Sola gitme işlemi burada gerçekleştirilir
        float newPositionX = transform.position.x - moveSpeed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -moveRangeX, moveRangeX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    void MoveRight()
    {
        // Sağa gitme işlemi burada gerçekleştirilir
        float newPositionX = transform.position.x + moveSpeed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -moveRangeX, moveRangeX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    void MoveForward()
    {
        // İleri gitme işlemi burada gerçekleştirilir
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    public void NotForward()
    {
        moveSpeed = 0;


    }
}
