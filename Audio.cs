using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource ONSound;
    public void startSound()
    {
        ONSound.Play();
    }
    public void stopSound()
    {
        ONSound.Stop();
    }
}
