using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;
    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }
}
