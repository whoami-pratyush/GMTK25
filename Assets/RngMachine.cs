using UnityEngine;
using UnityEngine.Rendering.Universal;

public class RngMachine : MonoBehaviour
{

    public int[] rollarray;
    private int arraylength = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int[] generateseed()
    {
        int tempseed = (int)(System.DateTime.Now.Ticks.GetHashCode());
        UnityEngine.Random.InitState(tempseed);
        rollarray = new int[arraylength];

        for (int i = 0; i < arraylength; i++)
        {
            int roll = UnityEngine.Random.Range(0, 100);
            rollarray[i] = roll;
        }
        return rollarray;
        
    }

}
