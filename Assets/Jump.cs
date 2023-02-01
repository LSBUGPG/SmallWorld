using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody physics;
    public float force = 1.0f;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            physics.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
