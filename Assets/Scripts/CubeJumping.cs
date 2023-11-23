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
        // X ekseni boyunca yerel koordinat sistemine göre hareket et
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);

        // Eğer nesne x = xRange birimine ulaştıysa, geriye dön
        if (transform.localPosition.y >= yRange)
        {
            moveSpeed = -Mathf.Abs(moveSpeed); // Negatif hızla geriye doğru hareket
        }

        // Eğer nesne x = -xRange birimine ulaştıysa, ileriye dön
        if (transform.localPosition.y <= -yFlipRange)
        {
            moveSpeed = Mathf.Abs(moveSpeed); // Pozitif hızla ileriye doğru hareket
        }
    }
}
