using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class damgScr : MonoBehaviour
{
  private Animator animator;
  private void Start()
  {
    animator = GetComponent<Animator>();
  }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("Player"))
      {
        animator.SetBool("HitTrig", "Player" == collision.gameObject.name);
      }
    }
  }
