using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Kaynak")]
    public AudioSource music;
    public AudioSource SFX;

    [Header("Sesler)")]
    public AudioClip tankates;
    public AudioClip tankpatlama;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Playsfx(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
