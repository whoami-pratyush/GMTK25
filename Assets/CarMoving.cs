using UnityEngine;

public class CarMoving : MonoBehaviour
{
    public float movespeed;
    public float deadzone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * movespeed) * Time.deltaTime;
        if(transform.position.x > deadzone)
        {
            Destroy(gameObject);
        }
    }
}
