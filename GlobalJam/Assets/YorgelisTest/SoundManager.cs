using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class SoundManager : MonoBehaviour
{

    private static SoundManager _instance;

    public static SoundManager myInstance { get { return _instance; } }

    public List<Sound> sounds, music;
    public AudioSource clipSfx, sfxSource;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
         musicSfx(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void playSfx(string _sfxSound)
    {
        Sound sound =  sounds.Find( x => x.nameClip == _sfxSound);

        if(sound != null) { clipSfx.clip = sound.clip; clipSfx.PlayOneShot(sound.clip); } else { Debug.Log("Not found"); }
    }

    public void musicSfx(int _sfxMusic)
    {
        Sound sound = music.Find(x => x.musisScene == _sfxMusic);

        if (sound != null) { sfxSource.clip = sound.clip; sfxSource.Play(); clipSfx.volume = sound.volume; } else { Debug.Log("Not found"); }
    }
}
