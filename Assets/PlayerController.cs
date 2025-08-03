using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public CustomerController cc;
    private List<string> list;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        list = cc.getmasterlist();
        foreach (var item in list)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<string> GetList()
    {
        return list;
    }
}
