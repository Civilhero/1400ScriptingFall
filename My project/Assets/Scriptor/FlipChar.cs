using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipChar : MonoBehaviour
{
    public KeyCode key1 = KeyCode.D, key2 = KeyCode.A;
    public float direction1 = 0, direction2 = 180;

    private void Update()
    {
        if (Input.GetKeyDown(key2))
        {
            transform.rotation = Quaternion.Euler(x:0, y:direction1, z:0);
        }

        if (!Input.GetKeyDown(key1)) return;
        transform.rotation = Quaternion.Euler(x:0, y:direction2, z:0);
    }
}
