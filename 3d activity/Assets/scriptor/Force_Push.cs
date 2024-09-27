using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force_Push : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * 500);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected wtih " + collision.gameObject.name);
    }
}
