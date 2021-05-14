using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;

    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        translation = Input.GetAxis("Vertical") * moveSpeed;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        transform.Translate(0, 0, translation * Time.deltaTime);
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
