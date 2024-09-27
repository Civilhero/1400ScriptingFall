using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public Color newColor = Color.red;
    public float shrinkFactor = 0.5f;
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
        transform.localScale *= shrinkFactor;
    }
}
