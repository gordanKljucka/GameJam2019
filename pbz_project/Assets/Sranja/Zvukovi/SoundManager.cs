using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip spawn;
    public AudioClip gubitak;
    public AudioClip bod;
    public AudioClip muzika;

    public void Bod()
    {
        audio.PlayOneShot(bod);
    }

    public void Gubitak()
    {
        audio.PlayOneShot(gubitak);
    }

    public void Spawn()
    {
        audio.PlayOneShot(spawn);
    }

    public void Muzika()
    {

    }
}
