using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    public GameObject chicken;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        chicken = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {
        Vector3 direction = chicken.transform.position - this.transform.position;
        transform.position += direction * speed * Time.deltaTime; 
    }
}
