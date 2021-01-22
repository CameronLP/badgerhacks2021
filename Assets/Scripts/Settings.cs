using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume (float volume) {
        if (volume > -30) {
            audioMixer.SetFloat("Volume", volume);
        } else {
            audioMixer.SetFloat("Volume", -80);
        }
    }
}
