using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherExplosion : MonoBehaviour
{
    //public ParticleSystem explosion;
    public AudioSource boomSound;


    public void byeFather()
    {
        //explosion.Play();
        boomSound.Play();
    }
}
