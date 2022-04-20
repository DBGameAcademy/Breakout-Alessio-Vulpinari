using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource[] Sources;

    private void Awake()
    {
        Sources = GetComponents<AudioSource>();
    }

    public void PlayClip(AudioClip _Clip)
    {
        for (int i = 0; i < Sources.Length; i++)
        {
            if (!Sources[i].isPlaying)
            {
                Sources[i].clip = _Clip;
                Sources[i].Play();
                break;
            }
        }
    }
}
