using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncyBoi : MonoBehaviour
{
    public float bounceForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
    }
}
