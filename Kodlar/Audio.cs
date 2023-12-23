using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slide1;






    private void Start()
    {
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            loadvolume();
        }
        else
        {
            musicvolume();
        }
    }


    public void musicvolume()
    {
        float volume = slide1.value;
        mixer.SetFloat("SFX",Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("SFXVolume",volume);
    }



    private void loadvolume()
    {
        slide1.value = PlayerPrefs.GetFloat("SFXVolume");
        musicvolume();
    }
}
