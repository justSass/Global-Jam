using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningChicken : MonoBehaviour
{
   public GameObject chickenspawn3d;


    public void chicken3Dspawn()
    {
        Instantiate(chickenspawn3d, new Vector3(11, 0, 11), Quaternion.identity);
    }
}
