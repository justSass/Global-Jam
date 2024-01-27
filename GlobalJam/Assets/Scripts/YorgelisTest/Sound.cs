using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class Sound
{

    public string nameClip;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;

}
