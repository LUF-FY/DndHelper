using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] Sounds;

    public AudioSource Sound;


    public void OnSound()
    {
        int n=Random.Range(0, Sounds.Length);
        Sound.clip = Sounds[n]; 
        Sound.Play();
    }

    public void OnEnable()
    {
        this.OnSound();
    }
}
