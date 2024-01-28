using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherExplosion : MonoBehaviour
{
    public ParticleSystem explosion;
    public AudioSource boomSound;
    public LTGChicken lTGChicken;


    public void byeFather()
    {
        explosion.Play();
        boomSound.Play();
        lTGChicken.OnChickenDie();
    }
}
