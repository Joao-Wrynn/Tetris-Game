using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicsettor : MonoBehaviour
{
    public void SetMusic(AudioClip clip)
    {
        //Find BGM gameobject
        //Get the audiosource Component from the BGM
        //Set the audiosource clip to be the clip

        GameObject bgm = GameObject.Find("BGM");
        AudioSource audiosource = bgm.GetComponent<AudioSource>();


        audiosource.clip = clip;
    }

}
