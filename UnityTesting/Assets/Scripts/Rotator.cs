using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * rotationSpeed);
    }
}
