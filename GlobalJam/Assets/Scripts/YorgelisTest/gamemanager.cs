using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using TMPro;
using UnityEngine.Rendering;
public class gamemanager : MonoBehaviour
{

    private static gamemanager _instance;

    public static gamemanager myInstance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Not found");
                _instance = FindObjectOfType<gamemanager>();


                if (_instance == null)
                {
                    //   Debug.Log("not found again");
                    // GameObject myGo = new GameObject("gamemanager");
                    // _instance = myGo.AddComponent<gamemanager>();
                    //  DontDestroyOnLoad(myGo.gameObject);

                }
            }

            return _instance;
        }
    }
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)] //this spawns the game manager before the scene loads
    public static void InitializeFramework()
    {//we need to declare a function to run in .BeforeSceneLoad


        gamemanager newMgr = gamemanager.myInstance; //finally, we have a new instance of our gameManager






    }

    public float inGameTimer;
    public enum GameState
    {
        MENU,
        GAMESTART,
        GAMEOVER,
        WIN
    }

    public GameState gameState;

    public GameObject exitButton;
    public UnityEvent exit;
    public GameObject spriteSelected;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        gameState = GameState.MENU;
       

        //Remember to play menu song
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        switch (gameState)
        {

            case GameState.MENU:

                break;
            case GameState.GAMESTART:
    
                inGameTimer += Time.deltaTime;
                break;
            case GameState.GAMEOVER:
                


                break;
            case GameState.WIN:

                break;
        }

    }
    public void SwitchScene()
    {
      
    }

    public void ExitScene()
    {
        
    }

    public void EndScene()
    {
       
    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SoundManager.myInstance.musicSfx((SceneManager.GetActiveScene().buildIndex + 1));

        
    }
   

}