using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioHandler : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    public void UpdateVolume()
    {
        float newVolume = volumeSlider.value;
        audioSource.volume = newVolume;
    }
}
