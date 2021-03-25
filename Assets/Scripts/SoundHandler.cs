using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public AudioSource[] gameSounds;
    public AudioSource pistol;
    public AudioSource rifle;
    // Start is called before the first frame update
    void Start()
    {
        gameSounds = GetComponents<AudioSource>();
    }

    public void PlayPistolSound()
    {
        pistol.Play();
    }

    public void PlayRifleSound()
    {
        rifle.Play();
    }

}
