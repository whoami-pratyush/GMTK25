using UnityEngine;

public class CustomerController: MonoBehaviour
{
    [SerializeField]
    private RngMachine rngmachine;
    private int[] roll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        roll = new int[25];
        roll = rngmachine.generateseed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
