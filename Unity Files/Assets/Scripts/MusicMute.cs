using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMute : MonoBehaviour
{
    public void PlayMute()
    {
        GameObject Audio = GameObject.FindGameObjectWithTag("Sound");
        Transform sound = Audio.transform.Find("BGMusic");
        AudioSource bg = sound.GetComponent<AudioSource>();
        if (bg.volume==0)
        {
            bg.volume= 1;
        }
        else if(bg.volume==1)
        {
            bg.volume = 0;
        }
        
    }
       
}
