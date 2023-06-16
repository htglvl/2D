using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class soundPlayer
{
    public string name;
    public AudioClip clip;

    [Range(0f,1f)]
    public float volume = 1f;

    [Range(-3f,3f)]
    public float pitch = 1f;

    [HideInInspector]
    public AudioSource source;

}
