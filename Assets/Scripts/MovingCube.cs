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
        // X ekseni boyunca yerel koordinat sistemine göre hareket et
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);

        // Eğer nesne x = xRange birimine ulaştıysa, geriye dön
        if (transform.localPosition.x >= xRange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed); // Negatif hızla geriye doğru hareket
        }

        // Eğer nesne x = -xRange birimine ulaştıysa, ileriye dön
        if (transform.localPosition.x <= -xRang)
        {
            moveSpeed = Mathf.Abs(moveSpeed); // Pozitif hızla ileriye doğru hareket
        }
    }
}
