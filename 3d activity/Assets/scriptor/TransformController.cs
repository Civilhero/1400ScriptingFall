using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x: 0, y: x, z: 0);
        transform.position = p;

        transform.Rotate(new Vector3(x: 0, y: 30, z: 0) * Time.deltaTime);
    }
}
