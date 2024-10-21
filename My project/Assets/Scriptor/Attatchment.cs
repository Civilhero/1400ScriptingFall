using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attatchment : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        transform.parent = collision.transform;
    }

}
