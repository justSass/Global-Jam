using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public GameObject enemy;

    public void spawner()
    {
      
            Instantiate(enemy, new Vector3(-12, 2, 12), Quaternion.identity);
            Instantiate(enemy, new Vector3(0, 2, 12), Quaternion.identity);
            Instantiate(enemy, new Vector3(12, 2, 12), Quaternion.identity);
            Instantiate(enemy, new Vector3(-5, 2, 6), Quaternion.identity);
            Instantiate(enemy, new Vector3(5, 2, 6), Quaternion.identity);
        
    }
}