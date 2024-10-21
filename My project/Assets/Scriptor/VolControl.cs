using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolControl : MonoBehaviour
{
    public AudioSource Music;
    public Slider VolSlider;

    private void Start()
    {
        VolSlider.value = Music.volume;
        VolSlider.onValueChanged.AddListener(AdjustVolume);
    }

    public void AdjustVolume(float newVolume)
    {
        Music.volume = newVolume;
    }
}
