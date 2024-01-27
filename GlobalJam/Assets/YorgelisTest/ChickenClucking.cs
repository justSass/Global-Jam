using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenClucking : MonoBehaviour
{
    [SerializeField] private KeyCode Cluck;
    [SerializeField] private float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Cluck)) { Debug.Log("cluck");chickenDie(); }

        transform.Rotate(new Vector3(0, 0, 1) * rotSpeed * Time.deltaTime);
    }

    public void chickenDie()
    {
        SoundManager.myInstance.playSfx("chickenDeath");
        Destroy(this.gameObject);
    }
}
