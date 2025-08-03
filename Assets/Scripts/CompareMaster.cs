using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompareMaster : MonoBehaviour
{
    public CustomerController cc;
    public ButtonScript pp;
    private List<string> master = new List<string>();
    private List<string> finalplayer = new List<string>();
    public bool check;
    public DialogueSystem index;
    private int i;
    
    public bool AreEqual(List<string> customer, List<string> player, int n)
    {
        if (customer.Count < n || player.Count < n)
        {
            return false;
        }
        for (int i = 0; i < n; i++)
        {
            if (player[i] != customer[i])
            {
                return false;
            }
        }
        return true;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i = index.geti();
        finalplayer = pp.Getplayerlist();
        check = AreEqual(finalplayer, finalplayer, i);

        PlayerPrefs.SetInt("Check", Convert.ToInt32(check));
        }
    private void Awake()
    {
        DontDestroyOnLoad(this);
        master = cc.getmasterlist();
        
    }
    


}
