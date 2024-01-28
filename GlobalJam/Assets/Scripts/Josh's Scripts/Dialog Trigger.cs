using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField] private List<dialogueString> dialogueStrings = new List<dialogueString>();
    [SerializeField] private Transform NPCTransform;

    private bool hasSpoken = false;


    public void OnTriggerEnter(Collider other)
    {
     if(other.CompareTag("Player") && !hasSpoken)
        {
            other.gameObject.GetComponent<DialogManager>().DialogueStart(dialogueStrings, NPCTransform);
            hasSpoken = true;
        }

    }

}

[System.Serializable]

public class dialogueString
{
    public string text; //npc dialogue
    public bool isEnd; //end of dialogue.

    [Header("Branch")]

    public bool isQuestion; //continue dialogue.

    public string answerOption1;
    public string answerOption2;

    public int option1Index;
    public int option2Index;

    [Header("Triggered Events")]
    public UnityEvent startDialogueEvent;
    public UnityEvent endDialogueEvent;




}
