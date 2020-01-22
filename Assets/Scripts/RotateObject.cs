using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(transform.rotation.eulerAngles.x, 1f, transform.rotation.eulerAngles.z * 1.5f);
    }
}
