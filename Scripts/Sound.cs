using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string name;

    public AudioClip clip;
    public AudioMixerGroup mixer;

    [Range(0,2)]
    public float volume;
    [Range(.1f,3)]
    public float pitch;

    public bool loop;
    public bool playAwake;

    [HideInInspector]
    public AudioSource source;
}
