using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken3D : MonoBehaviour
{

    public GameObject chicken2D;


    public void Chicken2DSpawn()
    {
        Instantiate(chicken2D, new Vector3(-16, 0, -17), Quaternion.identity);

    }
}
