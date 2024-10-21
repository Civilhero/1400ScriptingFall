using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlaynPause : MonoBehaviour
{
    public AudioSource Music;
    public void ToggleMusic()
    {
        if (Music.isPlaying)
        {
            Music.Pause();
        }
        else
        {
            Music.Play();
        }
    }
}
