using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotationSpeed;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(direction * rotationSpeed * Time.deltaTime);
    }
}
