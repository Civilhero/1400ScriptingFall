using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundTrig : MonoBehaviour
{
    private AudioSource audioJung;
    
    private void Start()
    {
        audioJung = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioJung.Play();
    }
}
