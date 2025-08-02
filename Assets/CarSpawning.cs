using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public float timer = 0f;
    public float spawnrate;
    public GameObject car;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer< spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(car,transform.position,transform.rotation);
            timer = 0f;
            spawnrate = Random.Range(0, 35);
        }
    }
}
