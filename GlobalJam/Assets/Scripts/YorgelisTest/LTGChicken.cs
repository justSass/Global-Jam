using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LTGChicken : MonoBehaviour
{

  [SerializeField] private Image ltgChicken;
  [SerializeField] private float showTime;
  [SerializeField] private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) { OnChickenDie(); }
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            ltgChicken.enabled = true;
        }
        else if(timer < 0) { ltgChicken.enabled = false; }
    }

    public void OnChickenDie()
    {
       if(ltgChicken.enabled == true) { timer += showTime;  }
       else if(ltgChicken.enabled == false) { timer = showTime; }
        SoundManager.myInstance.playSfx("Vine boom");
    }
}
