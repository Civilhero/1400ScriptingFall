using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCont : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAnimations();
    }
    
    private void HandleAnimations()
    { 
        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger(name:"JumpTrig");    
        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger(name:"DjumpTrig");
        }
            
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger(name:"WallJumpTrig");
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger(name:"FallTrig");
        }
         float HorizontalInput = Input.GetAxis("Horizontal");
         animator.SetBool(name:"RunTrig", HorizontalInput != 0);
    }
}
