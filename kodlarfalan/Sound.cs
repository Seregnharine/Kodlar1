using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource music;
    bool mute;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("mute"))
        {
            PlayerPrefs.SetInt("mute", 0);
            load();
        }
        else
        {
            load();
        }

    }
    public void musicup()
    {
        if (!mute)
        {
            mute = true;
            AudioListener.pause = true;
        }
        else
        {
            mute = false;
            AudioListener.pause = false;
        }
        save();

    }
    private void load()
    {
        mute = PlayerPrefs.GetInt("mute") == 1;
    }

    private void save()
    {
        PlayerPrefs.SetInt("mute", mute ? 1 : 0);
    }
}
