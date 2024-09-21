using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class object_movement : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        transform.Rotate(xAngle:30,yAngle:rotationSpeed * Time.deltaTime,zAngle:0);
        var x = Mathf.PingPong(Time.time, 5); transform.position = new Vector3(x, 1, 1);
=======
        transform.Rotate(xAngle:0,yAngle:rotationSpeed * Time.deltaTime,zAngle:0);
>>>>>>> origin/main
    }

    void resetScene()
    {
        SceneManager.LoadScene(0);
    }
}
