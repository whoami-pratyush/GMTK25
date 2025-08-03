using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework;
using System.Collections.Generic;

public class DialogueSystem : MonoBehaviour
{
    [TextArea(3,10)]
    public string[] dialogues;
    private int dialogueIndex = 0;
    public int startlength ;
    public int loopstart ;
    private int end = 25;
    private bool loopbool = false;
    public CustomerController cc;
    private List<string> list;
    int i = 0;

    public TextMeshProUGUI dialogueText;
    public Button nextButton;

    void Start()
    {

        dialogueText.text = "";
        list = cc.getmasterlist();
        if (list == null || list.Count == 0)
        {
            Debug.LogWarning("Masterlist not ready. Generating fallback list.");
            list = cc.customerlist();
        }

        // Optional: limit 'end' to avoid going beyond ingredient list + dialogue
        end = Mathf.Min(end, startlength + list.Count);

        nextButton.onClick.AddListener(ShowNextDialogue);
        ShowNextDialogue();

    }

    void ShowNextDialogue()
    {
        
        
        if (dialogueIndex < startlength)
        {
            dialogueText.text = dialogues[dialogueIndex];
            dialogueIndex++;
        }
       else if (dialogueIndex < end && dialogueIndex == loopstart)
        {
            dialogueText.text = "First you, " + list[i] + "and then we will go from there.";
            loopbool = true;
            dialogueIndex++;
            i++;
            Debug.Log(i);
        }
        else if(loopbool && i == 1)
        {
            dialogueText.text = "Oh sorry, can you please startover and  " + list[i] + " too, I am so forgetful! I'll pay more for the stuff though.";
            i++;
        }
        else if (i < end && loopbool)
        {
            dialogueText.text = "That's what I wanted but you'll need to start over again.Also this time can you please, " + list[i] + "?";
            dialogueIndex++;
            i++;
            Debug.Log(i);
        }
        else
        {
            dialogueText.text = "";
            nextButton.interactable = false;
        }
    }
}
