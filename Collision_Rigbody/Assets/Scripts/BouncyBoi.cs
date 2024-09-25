using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBoi : MonoBehaviour
{
    public float bounceForce = 5f;

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}