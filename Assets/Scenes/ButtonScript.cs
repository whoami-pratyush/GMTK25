using UnityEngine;
using System.Collections.Generic;

public class ButtonScript : MonoBehaviour
{
    public List<string> finallist = new List<string>();
    public List<string> tempdrink = new List<string>();

    public void OnButtonClickIngredient(string selectedIngredient)
    {
        tempdrink.Add(selectedIngredient);
        Debug.Log("Added: " + selectedIngredient);
    }

    public void OnConfirmClick()
    {
        finallist = new List<string>(tempdrink);
        Debug.Log("Confirmed Final List: " + string.Join(", ", finallist));
    }

    public List<string> Getplayerlist()
    {
        return finallist;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}