using UnityEngine;

public class SpawningLeft : MonoBehaviour
{
    public GameObject spawningleft;
    public float spawnrate = 5f;
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(spawningleft,transform.position,transform.rotation);
            timer = 0;
            spawnrate = Random.Range(5, 25);
        }

    }
}
