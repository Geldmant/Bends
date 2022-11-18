using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource prankSong;

    private void OnTriggerEnter(Collider other)
    {
        prankSong.Play();
    }
}
