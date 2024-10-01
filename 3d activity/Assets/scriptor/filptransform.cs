using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filptransform : MonoBehaviour
{
    public KeyCode key1 = KeyCode.A, key2 = KeyCode.D;
    public float direction1 = 0, direction2 = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(x:0, y: direction1, z: direction2);
        }

        if (!Input.GetKeyDown(key2)) return;
        transform.rotation = Quaternion.Euler(x:0, y: direction2, z:0);
    }
}
