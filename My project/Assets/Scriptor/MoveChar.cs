using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveChar : MonoBehaviour
{
    public float gravity = -9.81f;
    public float jumphight = 1.5f;
    public float jumpforce = 8f;
    public float moveSpeed = 5f;
    private Rigidbody2D controller;
    private Transform thisTransform;
    private Vector2 velocity;
    private Vector2 movementVector = Vector2.zero;
    [SerializeField] private float speed;
        
    private void Start()
    {
        controller = GetComponent<Rigidbody2D>();
        thisTransform = transform;
    }
    void Update()
    {
        MoveCharacter();
        KeepCharacterOnAxis();
        quitgame();
    }

    
    private void Jumping()
    {
        controller.velocity = new Vector2(controller.velocity.x, jumphight);
        velocity.y = Mathf.Sqrt(jumpforce * -2f * gravity);
    }
    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, controller.velocity.y);
        if (Input.GetButtonDown("Jump"))
            Jumping();
    }
    
    private void KeepCharacterOnAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

    public void quitgame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}

