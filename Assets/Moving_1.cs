using UnityEngine;

public class Moving_1 : MonoBehaviour
{
    public float movespeed = 2.5f;
    public float deadzone = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * movespeed) * Time.deltaTime;
        if(transform.position.x > deadzone)
        {
            Destroy(gameObject);
        }
    }
}
