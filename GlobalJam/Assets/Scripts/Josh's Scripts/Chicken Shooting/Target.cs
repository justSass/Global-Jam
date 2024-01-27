using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;
    public static int killCount = 0;
    public GameObject God;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    private void Update()
    {
        if(killCount == 5)
        {
            print("All Chickens have been killed!!!");
            Instantiate(God, new Vector3(0, 2, 0), Quaternion.identity);
        }
    }

    void Die()
    {
        killCount++;
        Update();
        Destroy(gameObject);
    }
}
